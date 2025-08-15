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

namespace GameNet_Management.App
{
    public partial class FormSelectCustomerReports : Form
    {
        public int selectedCustomerID = -1;
        public string selectedCustomerName = "";
        public FormSelectCustomerReports()
        {
            InitializeComponent();
        }

        private void FormSelectCustomerReports_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var cutomersList = db.CustomerRepository.Get().Select(c => new CustomerSelectionViewModel()
                    {
                        CustomerID = c.CustomerID,
                        FullName = c.FullName,
                        Phone = c.Phone,
                    }
                    ).ToList();

                    dgvCustomers.DataSource = cutomersList;
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        private void txtFliter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var cutomersList = db.CustomerRepository.Get(c => c.FullName.Contains(txtFliter.Text) || c.Phone.Contains(txtFliter.Text)).Select(c => new CustomerSelectionViewModel()
                    {
                        CustomerID = c.CustomerID,
                        FullName = c.FullName,
                        Phone = c.Phone,
                    }
                    ).ToList();

                    dgvCustomers.DataSource = cutomersList;
                }
            }
            catch
            {
                RtlMessageBox.Show("خطا در بارگیری اطلاعات مشتری", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }       
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int.TryParse(dgvCustomers.CurrentRow.Cells["CustomerID"].Value.ToString(), out selectedCustomerID);
                selectedCustomerName = dgvCustomers.CurrentRow.Cells["FullName"].Value.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("لطفاً یک مشتری را از لیست انتخاب کنید", "خطا",   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
