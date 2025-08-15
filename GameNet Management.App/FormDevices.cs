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
    public partial class FormDevices : FormManagerBase
    {
        public FormDevices()
        {
            InitializeComponent();
            this.Text = "دستگاه‌ها";
            dgvData.Columns.Clear();
            AddGridColumn("DeviceID", "شناسه");
            dgvData.Columns["DeviceID"].Visible = false;
            AddGridColumn("DeviceName", "شرح دستگاه", DataGridViewAutoSizeColumnMode.Fill);
            AddGridColumn("ServiceName", "سرویس", DataGridViewAutoSizeColumnMode.Fill);
            AddGridColumn("Status", "وضعیت", DataGridViewAutoSizeColumnMode.Fill);
            AddGridColumn("IsActive", "وضعیت فعال بودن", DataGridViewAutoSizeColumnMode.Fill);
        }

        protected override void BindGrid()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var devicesData = db.DevicesRepository.Get().Select(d => new DeviceDataViewModel()
                    {
                        DeviceID = d.DeviceID,
                        DeviceName = d.Name,
                        ServiceName = d.Services.Name,
                        Status = (d.Status == DeviceStatus.Available.ToString()) ? "آزاد" : "درحال استفاده",
                        IsActive = (d.IsActive == true) ? "فعال" : "غیرفعال"
                    }
                    ).OrderBy(d => d.ServiceName).ToList();

                    dgvData.DataSource = devicesData;
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
            FormAddOrEditDevices formAddDevice = new FormAddOrEditDevices(null);
            if (formAddDevice.ShowDialog() == DialogResult.OK)
            {
                SuccessMessage("افزودن دستگاه");
                BindGrid();
            }
        }

        protected override void PerformDelete()
        {
            if (dgvData.CurrentRow != null)
            {
                try
                {
                    var selectedDeviceID = int.Parse(dgvData.CurrentRow.Cells["DeviceID"].Value.ToString());
                    var selectedDeviceName = dgvData.CurrentRow.Cells["DeviceName"].Value.ToString();

                    if (RtlMessageBox.Show($"آیا از حذف کردن این دستگاه اطمینان دارید؟ \n {selectedDeviceName}", "حذف کردن دستگاه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            bool isDeleted = false;

                            if (db.SessionsRepository.Get(s => s.DeviceID == selectedDeviceID).Any())
                            {
                                if (RtlMessageBox.Show("شما نمی‌توانید این دستگاه را حذف کنید، این دستگاه دارای نشست در گزارش ها می‌باشد، آیا مایل به غیرفعال کردن این دستگاه هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    var deviceToUpdate = db.DevicesRepository.GetByID(selectedDeviceID);
                                    deviceToUpdate.IsActive = false;
                                    db.DevicesRepository.Update(deviceToUpdate);
                                    isDeleted = true;
                                    SuccessMessage("غیرفعال کردن دستگاه");
                                }
                            }
                            else
                            {
                                db.DevicesRepository.Delete(selectedDeviceID);
                                isDeleted = true;
                                SuccessMessage("حذف کردن دستگاه");
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
                    FailedMessage("حذف کردن دستگاه");
                    return;
                }
            }
        }

        protected override void PerformEdit()
        {
            if (dgvData.CurrentRow != null)
            {
                var selectedDeviceID = int.Parse(dgvData.CurrentRow.Cells["DeviceID"].Value.ToString());
                FormAddOrEditDevices formEditDevice = new FormAddOrEditDevices(selectedDeviceID);
                if (formEditDevice.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("ویرایش دستگاه");
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
                        var devicesData = db.DevicesRepository.Get(d => d.Name.Contains(txtFilter.Text)).Select(d => new DeviceDataViewModel()
                        {
                            DeviceID = d.DeviceID,
                            DeviceName = d.Name,
                            ServiceName = d.Services.Name,
                            Status = (d.Status == DeviceStatus.Available.ToString()) ? "آزاد" : "درحال استفاده"
                        }
                        ).ToList();

                        dgvData.DataSource = devicesData;
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
    }
}
