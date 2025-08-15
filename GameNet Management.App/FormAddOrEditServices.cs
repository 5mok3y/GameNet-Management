using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace GameNet_Management.App
{
    public partial class FormAddOrEditServices : Form
    {
        private int? _serviceID; // null: add - else: edit
        public FormAddOrEditServices(int? serviceID)
        {
            InitializeComponent();
            _serviceID = serviceID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (!_serviceID.HasValue) // add mode
                        {
                            Services newService = new Services()
                            {
                                Name = txtServiceName.Text
                            };

                            db.ServicesRepository.Insert(newService);
                        }

                        else
                        {
                            var selectedService = db.ServicesRepository.GetByID(_serviceID.Value);

                            if (selectedService == null)
                            {
                                RtlMessageBox.Show("کاربری برای ویرایش پیدا نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            selectedService.Name = txtServiceName.Text;
                            db.ServicesRepository.Update(selectedService);
                        }
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطا در ثبت اطلاعات سرویس", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }            
        }

        private void FormAddOrEditServices_Load(object sender, EventArgs e)
        {
            if (_serviceID.HasValue)
            {
                this.Text = "ویرایش سرویس";

                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var service = db.ServicesRepository.GetByID(_serviceID.Value);
                        if (service != null)
                        {
                            txtServiceName.Text = service.Name;
                        }
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }                
            }
        }
    }
}
