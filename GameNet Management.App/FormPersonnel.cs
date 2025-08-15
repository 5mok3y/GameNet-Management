using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.Utilities.Convertors;
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
    public partial class FormPersonnel : FormManagerBase
    {
        public FormPersonnel()
        {
            InitializeComponent();
            this.Text = "کاربران";
            dgvData.Columns.Clear();
            dgvData.AutoGenerateColumns = false;
            AddGridColumn("PersonnelID", "شناسه");
            dgvData.Columns["PersonnelID"].Visible = false;
            AddGridColumn("Username", "نام کاربری", DataGridViewAutoSizeColumnMode.Fill);
            AddGridColumn("Role", "نقش", DataGridViewAutoSizeColumnMode.Fill);
            AddGridColumn("IsActive", "وضعیت", DataGridViewAutoSizeColumnMode.Fill);
            AddGridColumn("RegisterDate", "تاریخ ثبت", DataGridViewAutoSizeColumnMode.Fill);
        }

        protected override void BindGrid()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var personnelList = db.PersonnelRepository.Get();
                    var personnelDataList = personnelList.Select(p => new PersonnelDataViewmodel
                    {
                        PersonnelID = p.PersonnelID,
                        Username = p.Username,
                        Role = (p.Role == "Admin") ? "مدیر" : "پرسنل",
                        IsActive = p.IsActive ? "فعال" : "غیرفعال",
                        RegisterDate = p.RegisterDate.ToShamsi()
                    }
                    ).ToList();

                    dgvData.DataSource = personnelDataList;
                }
            }
            catch (Exception)
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }           
        }

        protected override void PerformAdd()
        {
            FormAuth formAddUser = new FormAuth();
            formAddUser.isInsert = true;
            if (formAddUser.ShowDialog() == DialogResult.OK)
            {
                SuccessMessage("افزودن کاربر");
                BindGrid();
            }

        }

        protected override void PerformDelete()
        {
            if (dgvData.CurrentRow != null)
            {
                try
                {
                    var selectedUserID = int.Parse(dgvData.CurrentRow.Cells["PersonnelID"].Value.ToString());
                    var selectedUserName = dgvData.CurrentRow.Cells["Username"].Value.ToString();

                    if (RtlMessageBox.Show($"آیا از حذف کردن این کاربر اطمینان دارید؟ \n {selectedUserName}", "حذف کردن کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            db.PersonnelRepository.Delete(selectedUserID);
                            db.Save();
                            SuccessMessage("حذف کردن کاربر");
                            BindGrid();
                        }
                    }
                }
                catch
                {
                    FailedMessage("حذف کردن کاربر");
                    return;
                }
            }
        }

        protected override void PerformEdit()
        {
            if (dgvData.CurrentRow != null)
            {
                var selectedUserID = int.Parse(dgvData.CurrentRow.Cells["PersonnelID"].Value.ToString());
                FormAuth formEditUser = new FormAuth();
                formEditUser.isEdit = true;
                formEditUser.userID = selectedUserID;
                if (formEditUser.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("ویرایش کاربر");
                    BindGrid();
                }
            }
        }

        protected override void PerformFilter()
        {
            if (!string.IsNullOrEmpty(txtFilter.Text) && txtFilter.Text != "جستجو")
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var personnelDataList = db.PersonnelRepository.Get(p => p.Username.Contains(txtFilter.Text)).Select(p => new PersonnelDataViewmodel
                        {
                            PersonnelID = p.PersonnelID,
                            Username = p.Username,
                            Role = (p.Role == "Admin") ? "مدیر" : "پرسنل",
                            IsActive = p.IsActive ? "فعال" : "غیرفعال",
                            RegisterDate = p.RegisterDate.ToShamsi()
                        }
                        ).ToList();

                        dgvData.DataSource = personnelDataList;
                    }
                }
                catch (Exception)
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
