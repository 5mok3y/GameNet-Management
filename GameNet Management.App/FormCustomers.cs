using GameNet_Management.DataLayer.Context;
using GameNet_Management.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNet_Management.App
{
    public partial class FormCustomers : FormManagerBase
    {
        public FormCustomers()
        {
            InitializeComponent();
            this.Text = "مشتریان";
            dgvData.Columns.Clear();
            AddGridColumn("CustomerID", "شناسه");
            AddGridColumn("FullName", "نام و نام خانوادگی", minimumWidth: 160);
            AddGridColumn("Phone", "شماره تلفن", minimumWidth: 130);
            AddGridColumn("IsActive", "وضعیت", minimumWidth: 90);
            AddGridColumn("Description", "توضیحات", DataGridViewAutoSizeColumnMode.Fill);
        }



        protected override void BindGrid()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgvData.DataSource = db.CustomerRepository.Get();
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        protected override void PerformAdd()
        {
            FormAddOrEditCustomers formAddCustomer = new FormAddOrEditCustomers(null);
            if (formAddCustomer.ShowDialog() == DialogResult.OK)
            {
                SuccessMessage("افزودن مشتری");
                BindGrid();
            }
        }

        protected override void PerformDelete()
        {
            if (dgvData.CurrentRow != null)
            {
                try
                {
                    var selectedCustomerID = int.Parse(dgvData.CurrentRow.Cells["CustomerID"].Value.ToString());
                    var selectedCustomerName = dgvData.CurrentRow.Cells["FullName"].Value.ToString();

                    if (RtlMessageBox.Show($"آیا از حذف کردن این مشتری اطمینان دارید؟ \n {selectedCustomerName}", "حذف کردن شخص", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            bool isDeleted = false;

                            if (db.SessionsRepository.Get(s => s.CustomerID == selectedCustomerID).Any())
                            {
                                if (RtlMessageBox.Show("شما نمی‌توانید این مشتری را حذف کنید، این مشتری دارای نشست در گزارش ها می‌باشد، آیا مایل به غیرفعال کردن این مشتری هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    var customerToUpdate = db.CustomerRepository.GetByID(selectedCustomerID);
                                    customerToUpdate.IsActive = false;
                                    db.CustomerRepository.Update(customerToUpdate); 
                                    isDeleted = true;
                                    SuccessMessage("غیرفعال کردن مشتری");
                                }
                            }
                            else
                            {
                                db.CustomerRepository.Delete(selectedCustomerID);
                                isDeleted = true;
                                SuccessMessage("حذف کردن مشتری");
                            }

                            if (isDeleted)
                            {
                                db.Save();
                                BindGrid();
                            }
                        }
                    }
                }
                catch
                {
                    FailedMessage("حذف کردن مشتری");
                    return;
                }
            }
        }

        protected override void PerformEdit()
        {
            if (dgvData.CurrentRow != null)
            {
                var selectedCustomerID = int.Parse(dgvData.CurrentRow.Cells["CustomerID"].Value.ToString());
                FormAddOrEditCustomers formEditCustomer = new FormAddOrEditCustomers(selectedCustomerID);
                if (formEditCustomer.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("ویرایش مشتری");
                    BindGrid();
                }
            }
        }

        protected override void PerformFilter()
        {
            if (!string.IsNullOrEmpty(txtFilter.Text) && txtFilter.Text != "جستجو")
            {
                dgvData.AutoGenerateColumns = false;
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        dgvData.DataSource = db.CustomerRepository.Get(c => c.FullName.Contains(txtFilter.Text) || c.CustomerID.ToString().Contains(txtFilter.Text));
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }              
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void FormatGridCells(DataGridViewCellFormattingEventArgs e)
        {
            base.FormatGridCells(e);

            if (this.dgvData.Columns[e.ColumnIndex].Name == "IsActive")
            {
                if (e.Value is bool)
                {
                    e.Value = (bool)e.Value ? "فعال" : "غیرفعال";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
