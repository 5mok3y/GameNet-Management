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
using ValidationComponents;

namespace GameNet_Management.App
{
    public partial class FormAddOrEditDevices : Form
    {
        private int? _selectedDeviceID; // null for add and else for edit
        public FormAddOrEditDevices(int? selectedDeviceID)
        {
            InitializeComponent();
            _selectedDeviceID = selectedDeviceID;
        }

        private void FormAddOrEditDevices_Load(object sender, EventArgs e)
        {
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
                    cbService.SelectedIndex = 0;
                    chbIsActive.Checked = true;

                    if (_selectedDeviceID.HasValue)
                    {
                        this.Text = "ویرایش دستگاه";
                        var selectedDevice = db.DevicesRepository.GetByID(_selectedDeviceID.Value);
                        if (selectedDevice != null)
                        {
                            txtDeviceName.Text = selectedDevice.Name;
                            cbService.SelectedValue = selectedDevice.ServiceID;
                            chbIsActive.Checked = selectedDevice.IsActive;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        if (_selectedDeviceID.HasValue) // edit mode
                        {
                            var deviceToUpdate = db.DevicesRepository.GetByID(_selectedDeviceID.Value);
                            if (deviceToUpdate != null)
                            {
                                deviceToUpdate.Name = txtDeviceName.Text;
                                deviceToUpdate.ServiceID = (int)cbService.SelectedValue;
                                deviceToUpdate.IsActive = chbIsActive.Checked;
                                db.DevicesRepository.Update(deviceToUpdate);
                            }
                        }
                        else // add mode
                        {
                            Devices newDevice = new Devices()
                            {
                                Name = txtDeviceName.Text,
                                ServiceID = (int)cbService.SelectedValue,
                                IsActive = chbIsActive.Checked,
                                Status = DeviceStatus.Available.ToString()
                            };
                            db.DevicesRepository.Insert(newDevice);
                        }
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطا در ثبت اطلاعات دستگاه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
    }
}
