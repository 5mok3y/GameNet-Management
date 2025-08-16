using GameNet_Management.App.User;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameNet_Management.App
{
    public partial class FormAuth : Form
    {
        public bool isFirstUser = false;
        public bool isEdit = false;
        public bool isInsert = false;
        public int userID;

        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (isEdit)
                    {
                        InitialComboBox();
                        var selectedUser = db.PersonnelRepository.GetByID(userID);
                        txtUserName.Text = selectedUser.Username;
                        txtUserName.ReadOnly = true;
                        chbIsActive.Checked = selectedUser.IsActive;
                        cbPersonnelRole.SelectedValue = selectedUser.Role;
                        this.Text = "ویرایش کاربر";
                        this.btnSubmit.Text = "ذخیره";
                    }

                    else if (isInsert)
                    {
                        this.Text = "افزودن کاربر";
                        this.btnSubmit.Text = "ثبت";
                        InitialComboBox();
                        chbIsActive.Checked = true;
                        cbPersonnelRole.SelectedIndex = 1;

                        if (isFirstUser)
                        {
                            this.Text = "ایجاد اولین کاربر مدیر";
                            cbPersonnelRole.SelectedValue = "Admin";
                            cbPersonnelRole.Enabled = false;
                            chbIsActive.Enabled = false;
                        }

                    }
                    else
                    {
                        lblIsActive.Visible = false;
                        chbIsActive.Visible = false;
                        lblRole.Visible = false;
                        cbPersonnelRole.Visible = false;
                        this.groupBoxInfo.Size = new Size(458, 217);
                        this.Size = new Size(498, 280);
                        lblUsername.Location = new Point(365, 57);
                        txtUserName.Location = new Point(33, 54);
                        txtUserName.Size = new Size(311, 31);
                        lblPassword.Location = new Point(365, 110);
                        txtPassword.Location = new Point(33, 107);
                        txtPassword.Size = new Size(311, 31);
                        btnSubmit.Location = new Point(156, 162);
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
                        if (isEdit)
                        {
                            var selectedUser = db.PersonnelRepository.GetByID(userID);

                            if (selectedUser == null)
                            {
                                RtlMessageBox.Show("کاربری برای ویرایش یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                            {
                                selectedUser.PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                            }

                            selectedUser.IsActive = chbIsActive.Checked;
                            selectedUser.Role = cbPersonnelRole.SelectedValue.ToString();

                            db.PersonnelRepository.Update(selectedUser);
                            db.Save();
                            this.DialogResult = DialogResult.OK;
                        }

                        else if (isInsert)
                        {
                            if (db.PersonnelRepository.Get(p => p.Username == txtUserName.Text).Any())
                            {
                                RtlMessageBox.Show("این نام کاربری قبلاً استفاده شده است. لطفاً نام کاربری دیگری انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string username = txtUserName.Text;
                            string passwordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                            Personnel newUser = new Personnel()
                            {
                                Username = username,
                                PasswordHash = passwordHash,
                                Role = cbPersonnelRole.SelectedValue.ToString(),
                                RegisterDate = DateTime.Now,
                                IsActive = chbIsActive.Checked
                            };

                            db.PersonnelRepository.Insert(newUser);
                            db.Save();
                            this.DialogResult = DialogResult.OK;
                        }

                        else
                        {
                            var user = db.PersonnelRepository.Get(p => p.IsActive && p.Username.ToLower() == txtUserName.Text.ToLower()).SingleOrDefault();

                            if (user != null && BCrypt.Net.BCrypt.Verify(txtPassword.Text, user.PasswordHash))
                            {
                                CurrentUser.LoggedInUsername = user.Username;

                                if (Enum.TryParse(user.Role, true,out UserRole userRole))
                                {
                                    CurrentUser.Role = userRole;
                                }
                                
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                RtlMessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطا در ثبت و بررسی اطلاعات کاربری", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void InitialComboBox()
        {
            List<PersonnelRoleViewModel> personnelRoles = new List<PersonnelRoleViewModel>
                    {
                        new PersonnelRoleViewModel {Value = "Admin", DisplayName = "مدیر"},
                        new PersonnelRoleViewModel {Value = "Staff", DisplayName = "پرسنل"}
                    };
            cbPersonnelRole.DataSource = personnelRoles;
            cbPersonnelRole.DisplayMember = "DisplayName";
            cbPersonnelRole.ValueMember = "Value";
        }

        private void ValidPass_OnValidate(object sender, EventArgs e)
        {
            if (isEdit && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ValidPassword.IsValidated = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ValidPassword.IsValidated = false;
            }
            else
            {
                ValidPassword.IsValidated = true;
            }
        }
    }
}
