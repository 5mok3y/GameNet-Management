using GameNet_Management.App.Device;
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

namespace GameNet_Management.App
{
    public partial class FormStartSession : Form
    {
        private int _deviceID;
        private int _serviceID;

        public FormStartSession(int deviceID, int serviceID)
        {
            InitializeComponent();

            _deviceID = deviceID;
            _serviceID = serviceID;
        }

        private void BindGrid()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customersSeclction = db.CustomerRepository.Get().Select(c => new CustomerSelectionViewModel()
                    {
                        CustomerID = c.CustomerID,
                        FullName = c.FullName,
                        Phone = c.Phone,
                        IsActive = c.IsActive,
                        StatusDisplay = c.IsActive ? "فعال" : "غیرفعال"
                    }).ToList();
                    dgvCustomers.AutoGenerateColumns = false;
                    dgvCustomers.DataSource = customersSeclction;
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }       
        }

        private void FormStartSession_Load(object sender, EventArgs e)
        {
            txtFilter_Leave(txtFilter, null);

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var device = db.DevicesRepository.GetByID(_deviceID);
                    lblDeviceName.Text = device.Name;

                    cbServiceOptions.DataSource = db.ServiceOptionsRepository.Get(so => so.ServiceID == _serviceID).ToList();
                    cbServiceOptions.DisplayMember = "Description";
                    cbServiceOptions.ValueMember = "OptionID";

                    BindGrid();
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            } 
        }


        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text) && txtFilter.Text != "جستجو")
            {
                dgvCustomers.AutoGenerateColumns = false;

                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var customerSelection = db.CustomerRepository.Get(c => c.FullName.Contains(txtFilter.Text) || c.CustomerID.ToString().Contains(txtFilter.Text)).Select(c => new CustomerSelectionViewModel()
                        {
                            CustomerID = c.CustomerID,
                            FullName = c.FullName,
                            IsActive = c.IsActive,
                            StatusDisplay = c.IsActive ? "فعال" : "غیرفعال"
                        }).ToList();

                        dgvCustomers.DataSource = customerSelection;
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطا در بارگیری اطلاعات مشتری", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }       
            }
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "جستجو")
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                BindGrid();
                txtFilter.Text = "جستجو";
                txtFilter.ForeColor = Color.Gray;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                RtlMessageBox.Show("لطفاً یک مشتری انتخاب کنید", "خطا");
                return;
            }
            if (cbServiceOptions.SelectedItem == null)
            {
                RtlMessageBox.Show("لطفاً یک تعرفه انتخاب کنید", "خطا");
                return;
            }

            var selectedCustomer = dgvCustomers.CurrentRow.DataBoundItem as CustomerSelectionViewModel;

            if (!selectedCustomer.IsActive)
            {
                RtlMessageBox.Show("امکان شروع نشست برای یک مشتری غیرفعال وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                int SelectedCustomerID = selectedCustomer.CustomerID;
                int SelectedOptionID = (int)cbServiceOptions.SelectedValue;

                using (UnitOfWork db = new UnitOfWork())
                {
                    var selectedDevice = db.DevicesRepository.GetByID(_deviceID);
                    selectedDevice.Status = DeviceStatus.InUse.ToString();

                    Sessions newSession = new Sessions()
                    {
                        CustomerID = SelectedCustomerID,
                        OptionID = SelectedOptionID,
                        DeviceID = _deviceID,
                        StartTime = DateTime.Now,
                        IsPaid = false
                    };

                    db.SessionsRepository.Insert(newSession);
                    db.DevicesRepository.Update(selectedDevice);
                    db.Save();
                }
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                RtlMessageBox.Show("خطا در شروع نشست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
        }
    }
}
