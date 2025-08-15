using GameNet_Management.App.User;
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

namespace GameNet_Management.App
{
    public abstract partial class FormManagerBase : Form        // convert to non abstract if want to edit childs
    {
        public FormManagerBase()
        {
            if (IsInDesignMode()) return;
            InitializeComponent();         
        }

        protected bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }


        protected virtual void FailedMessage(string messageTitle)
        {
            RtlMessageBox.Show("عملیات ناموفق", messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected virtual void SuccessMessage(string messageTitle)
        {
            RtlMessageBox.Show("عملیات با موفقیت انجام شد", messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormManagerBase_Load(object sender, EventArgs e)
        {

            btnDelete.Enabled = CurrentUser.IsAdmin();
            btnEdit.Enabled = CurrentUser.IsAdmin();

            dgvData.AutoGenerateColumns = false;
            txtFilter_Leave(txtFilter, null);
            BindGrid();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            txtFilter.Clear();
            txtFilter_Leave(null, null);
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            PerformFilter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformAdd();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PerformEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PerformDelete();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CurrentUser.Role == UserRole.Admin)
            {
                PerformEdit();
            }
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatGridCells(e);
        }

        protected void AddGridColumn(string dataPropertyName, string headerText, DataGridViewAutoSizeColumnMode autoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, int minimumWidth = 50)
        {
            var newColumn = new DataGridViewTextBoxColumn
            {
                Name = dataPropertyName,
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                AutoSizeMode = autoSizeMode,
                MinimumWidth = minimumWidth
            };
            dgvData.Columns.Add(newColumn);
        }


        // convert these abstract methods to non abstract (virtual) if want to edit childs forms

        protected abstract void PerformAdd();
        protected abstract void PerformEdit();
        protected abstract void PerformDelete();
        protected abstract void PerformFilter();
        protected abstract void BindGrid();
        protected virtual void FormatGridCells(DataGridViewCellFormattingEventArgs e){}

    }
}