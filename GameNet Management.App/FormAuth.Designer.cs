namespace GameNet_Management.App
{
    partial class FormAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbPersonnelRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.ValidUsername = new ValidationComponents.RequiredFieldValidator(this.components);
            this.ValidPassword = new ValidationComponents.CustomValidator(this.components);
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.chbIsActive);
            this.groupBoxInfo.Controls.Add(this.btnSubmit);
            this.groupBoxInfo.Controls.Add(this.cbPersonnelRole);
            this.groupBoxInfo.Controls.Add(this.txtPassword);
            this.groupBoxInfo.Controls.Add(this.txtUserName);
            this.groupBoxInfo.Controls.Add(this.lblIsActive);
            this.groupBoxInfo.Controls.Add(this.lblRole);
            this.groupBoxInfo.Controls.Add(this.lblPassword);
            this.groupBoxInfo.Controls.Add(this.lblUsername);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxInfo.Size = new System.Drawing.Size(520, 236);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "اطلاعات کاربری";
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Location = new System.Drawing.Point(62, 54);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(61, 30);
            this.chbIsActive.TabIndex = 2;
            this.chbIsActive.Text = "فعال";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::GameNet_Management.App.Properties.Resources.check;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(188, 181);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(30, 0, 35, 0);
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(145, 42);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "ورود";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbPersonnelRole
            // 
            this.cbPersonnelRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonnelRole.FormattingEnabled = true;
            this.cbPersonnelRole.Location = new System.Drawing.Point(19, 98);
            this.cbPersonnelRole.Name = "cbPersonnelRole";
            this.cbPersonnelRole.Size = new System.Drawing.Size(104, 34);
            this.cbPersonnelRole.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(218, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 31);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(218, 52);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 31);
            this.txtUserName.TabIndex = 0;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(135, 55);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(64, 26);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "وضعیت:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(153, 104);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 26);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "نقش:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(451, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 26);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "رمز عبور:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(440, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 26);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "نام کاربری:";
            // 
            // ValidUsername
            // 
            this.ValidUsername.CancelFocusChangeWhenInvalid = false;
            this.ValidUsername.ControlToValidate = this.txtUserName;
            this.ValidUsername.ErrorMessage = "لطفا نام کاربری را وارد کنید";
            this.ValidUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidUsername.Icon")));
            // 
            // ValidPassword
            // 
            this.ValidPassword.CancelFocusChangeWhenInvalid = false;
            this.ValidPassword.ControlToValidate = this.txtPassword;
            this.ValidPassword.ErrorMessage = "لطفا رمز عبور را وارد کنید";
            this.ValidPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidPassword.Icon")));
            this.ValidPassword.IsValidated = false;
            this.ValidPassword.OnValidate += new System.EventHandler(this.ValidPass_OnValidate);
            // 
            // FormAuth
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(544, 260);
            this.Controls.Add(this.groupBoxInfo);
            this.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به برنامه";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSubmit;
        private ValidationComponents.RequiredFieldValidator ValidUsername;
        private System.Windows.Forms.ComboBox cbPersonnelRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Label lblIsActive;
        private ValidationComponents.CustomValidator ValidPassword;
    }
}

