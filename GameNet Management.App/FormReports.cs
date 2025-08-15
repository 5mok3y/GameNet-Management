using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.Utilities.Convertors;
using GameNet_Management.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.StiOptions;

namespace GameNet_Management.App
{
    public partial class FormReports : Form
    {
        int? selectedCustomerID = null;
        public FormReports()
        {
            InitializeComponent();
        }

        private void BindComboBox()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var servicesList = db.ServicesRepository.Get().Select(s => new ServiceNamesViewModel()
                    {
                        ServiceID = s.ServiceID,
                        ServiceName = s.Name
                    }
                    ).ToList();

                    servicesList.Insert(0, new ServiceNamesViewModel()
                    {
                        ServiceID = -1,
                        ServiceName = "انتخاب سرویس"
                    });

                    var DevicesList = db.DevicesRepository.Get().Select(d => new DeviceDataViewModel()
                    {
                        DeviceID = d.DeviceID,
                        DeviceName = d.Name,
                        ServiceID = d.ServiceID
                    }
                    ).OrderBy(d => d.ServiceID).ToList();

                    DevicesList.Insert(0, new DeviceDataViewModel()
                    {
                        DeviceID = -1,
                        DeviceName = "انتخاب دستگاه"
                    });

                    cbServiceName.DataSource = servicesList;
                    cbServiceName.ValueMember = "ServiceID";
                    cbServiceName.DisplayMember = "ServiceName";

                    cbDeviceName.DataSource = DevicesList;
                    cbDeviceName.ValueMember = "DeviceID";
                    cbDeviceName.DisplayMember = "DeviceName";
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
           
        }

        private void CheckDeviceComboBox()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (cbServiceName.SelectedValue.ToString() != "-1")
                    {

                        int.TryParse(cbServiceName.SelectedValue.ToString(), out int selectedService);
                        var DevicesList = db.DevicesRepository.Get(d => d.ServiceID == selectedService).Select(d => new DeviceDataViewModel()
                        {
                            DeviceID = d.DeviceID,
                            DeviceName = d.Name,
                            ServiceID = d.ServiceID
                        }
                       ).OrderBy(d => d.ServiceID).ToList();

                        DevicesList.Insert(0, new DeviceDataViewModel()
                        {
                            DeviceID = -1,
                            DeviceName = "انتخاب دستگاه"
                        });

                        cbDeviceName.DataSource = DevicesList;
                        cbDeviceName.ValueMember = "DeviceID";
                        cbDeviceName.DisplayMember = "DeviceName";
                    }
                    else
                    {
                        BindComboBox();
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

        private void FormReports_Load(object sender, EventArgs e)
        {
            dgvReports.AutoGenerateColumns = false;
            Filter();
            BindComboBox();
        }


        private void cbServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckDeviceComboBox();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormSelectCustomerReports formSelectCustomerReports = new FormSelectCustomerReports();
            if (formSelectCustomerReports.ShowDialog() == DialogResult.OK)
            {
                if (formSelectCustomerReports.selectedCustomerID != -1)
                {
                    this.selectedCustomerID = formSelectCustomerReports.selectedCustomerID;
                    btnCustomer.Text = formSelectCustomerReports.selectedCustomerName.ToString();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectedCustomerID = null;
            btnCustomer.Text = "انتخاب مشتری";
            BindComboBox();
            Filter();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    DateTime? miladiStartDate;
                    DateTime? miladiEndDate;

                    var filteredSessions = db.SessionsRepository.Get();

                    if (selectedCustomerID != null)
                    {
                        filteredSessions = filteredSessions.Where(s => s.CustomerID == selectedCustomerID);
                    }

                    if (cbServiceName.SelectedValue != null && cbServiceName.SelectedIndex != 0)
                    {
                        filteredSessions = filteredSessions.Where(s => s.ServiceOptions.ServiceID == (int)cbServiceName.SelectedValue);
                    }

                    if (cbDeviceName.SelectedValue != null && cbDeviceName.SelectedIndex != 0)
                    {
                        filteredSessions = filteredSessions.Where(s => s.DeviceID == (int)cbDeviceName.SelectedValue);
                    }

                    if (txtStartDate.Text != "    /  /")
                    {
                        miladiStartDate = Convert.ToDateTime(txtStartDate.Text);
                        miladiStartDate = DateConvertor.ToMiladi(miladiStartDate.Value);
                        filteredSessions = filteredSessions.Where(s => s.StartTime.ToMiladi() >= miladiStartDate.Value); // this ToMiladi's ensures proper filter if user's system date format isn't miladi
                    }

                    if (txtEndDate.Text != "    /  /")
                    {
                        miladiEndDate = Convert.ToDateTime(txtEndDate.Text);
                        miladiEndDate = DateConvertor.ToMiladi(miladiEndDate.Value);
                        filteredSessions = filteredSessions.Where(s => s.EndTime.HasValue && s.EndTime.Value.ToMiladi() <= miladiEndDate.Value); // this ToMiladi's ensures proper filter if user's system date format isn't miladi
                    }

                    var filteredSessionsData = filteredSessions.Select(s => new SessionsDataViewModel()
                    {
                        SessionID = s.SessionID,
                        CustomerName = s.Customers.FullName,
                        DeviceName = s.Devices.Name,
                        OptionName = s.ServiceOptions.Description,
                        TotalPrice = (s.TotalPrice.HasValue) ? s.TotalPrice.Value.ToTooman() : "پرداخت نشده",
                        Duration = (s.TotalMinutes.HasValue) ? TimeSpan.FromMinutes(s.TotalMinutes.Value).ToString(@"hh\:mm") : "در جریان",
                        StartDate = s.StartTime.ToShamsi(),
                        StartTime = s.StartTime.ToString("HH:mm:ss"),
                        EndTime = (s.EndTime.HasValue) ? s.EndTime.Value.ToString("HH:mm:ss") : "نامشخص"
                    }
                    ).ToList();

                    dgvReports.DataSource = filteredSessionsData;
                }
            }
            catch
            {
                RtlMessageBox.Show("خطا در بارگیری اطلاعات نشست‌ها", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }     
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("SessionID");
            dtPrint.Columns.Add("CustomerName");
            dtPrint.Columns.Add("DeviceName");
            dtPrint.Columns.Add("OptionName");
            dtPrint.Columns.Add("TotalPrice");
            dtPrint.Columns.Add("Duration");
            dtPrint.Columns.Add("StartDate");
            dtPrint.Columns.Add("StartTime");
            dtPrint.Columns.Add("EndTime");

            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                dtPrint.Rows.Add(

                    row.Cells["SessionID"].Value.ToString(),
                    row.Cells["CustomerName"].Value.ToString(),
                    row.Cells["DeviceName"].Value.ToString(),
                    row.Cells["OptionName"].Value.ToString(),
                    row.Cells["TotalPrice"].Value.ToString(),
                    row.Cells["Duration"].Value.ToString(),
                    row.Cells["StartDate"].Value.ToString(),
                    row.Cells["StartTime"].Value.ToString(),
                    row.Cells["EndTime"].Value.ToString()
                    );
            }

            stiPrint.Load(Path.Combine(Application.StartupPath, "Report.mrt"));
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();
        }
    }
}
