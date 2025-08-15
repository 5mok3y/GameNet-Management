using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.ViewModels;
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
    public partial class FormAddOrEditOptions : Form
    {
        private int? _optionID; // null: add  else: edit
        public FormAddOrEditOptions(int? optionID)
        {
            InitializeComponent();
            _optionID = optionID;
        }

        private void FormAddOrEditOptions_Load(object sender, EventArgs e)
        {
            txtPrice.Controls[0].Visible = false;

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var servicesList = db.ServicesRepository.Get();
                    var serviceViewList = servicesList.Select(s => new ServiceNamesViewModel()
                    {
                        ServiceID = s.ServiceID,
                        ServiceName = s.Name
                    }
                    ).ToList();

                    serviceViewList.Insert(0, new ServiceNamesViewModel()
                    {
                        ServiceID = -1,
                        ServiceName = "لطفا انتخاب کنید"
                    }
                    );

                    cbService.DataSource = serviceViewList;
                    cbService.ValueMember = "ServiceID";
                    cbService.DisplayMember = "ServiceName";

                    if (!_optionID.HasValue) // add mode
                    {
                        cbService.SelectedIndex = 0;
                    }
                    else
                    {
                        this.btnSubmit.Text = "ویرایش";
                        this.Text = "ویرایش تعرفه";

                        var selectedOption = db.ServiceOptionsRepository.GetByID(_optionID.Value);
                        if (selectedOption != null)
                        {
                            cbService.SelectedValue = selectedOption.ServiceID;
                            txtPrice.Value = selectedOption.PricePerHour;
                            txtDescription.Text = selectedOption.Description;
                        }
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

        private void ValidService_OnValidate(object sender, EventArgs e)
        {
            if (cbService.SelectedIndex != 0)
            {
                ValidService.IsValidated = true;
            }
            else
            {
                ValidService.IsValidated = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (!_optionID.HasValue) // add mode
                        {
                            ServiceOptions newOption = new ServiceOptions()
                            {
                                ServiceID = int.Parse(cbService.SelectedValue.ToString()),
                                Description = txtDescription.Text,
                                PricePerHour = txtPrice.Value,
                            };

                            db.ServiceOptionsRepository.Insert(newOption);
                        }

                        else // edit mode
                        {
                            var selectedOption = db.ServiceOptionsRepository.GetByID(_optionID);

                            if (selectedOption == null)
                            {
                                RtlMessageBox.Show("تعرفه ای برای ویرایش پیدا نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            selectedOption.ServiceID = int.Parse(cbService.SelectedValue.ToString());
                            selectedOption.Description = txtDescription.Text;
                            selectedOption.PricePerHour = txtPrice.Value;

                            db.ServiceOptionsRepository.Update(selectedOption);
                        }
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطا در ثبت اطلاعات تعرفه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
        }
    }
}
