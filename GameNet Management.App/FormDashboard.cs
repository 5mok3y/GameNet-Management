using GameNet_Management.App.Reports;
using GameNet_Management.Utilities.Convertors;
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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }


        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            FormPersonnel formPersonnel = new FormPersonnel();
            formPersonnel.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            FormServices formServices = new FormServices();
            formServices.ShowDialog();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            FormDevices formDevices = new FormDevices();
            formDevices.ShowDialog();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            BindReports();
        }

        private void BindReports()
        {
            try
            {
                var report = ReportSummary.DashboardReports();

                lblTodayIncome.Text = report.TodayIncome.ToTooman();
                lblMonthIncome.Text = report.MonthIncome.ToTooman();
                lblTodayNewCustomers.Text = report.TodayNewCustomers.ToString() + " نفر";
                lblMonthNewCustomers.Text = report.MonthNewCustomers.ToString() + " نفر";

                dgvTopCustomers.DataSource = report.TopCustomers;
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
           
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();
            formReports.ShowDialog();
        }
    }
}
