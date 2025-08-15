namespace GameNet_Management.App
{
    partial class FormAddOrEditCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditCustomers));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerRegDateValue = new System.Windows.Forms.Label();
            this.lblCustomerRegDate = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.picCustomerImage = new System.Windows.Forms.PictureBox();
            this.lblCustomerDescription = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerDescription = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.ValidName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.ValidPhone = new ValidationComponents.CustomValidator(this.components);
            this.gbCustomerInfo.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::GameNet_Management.App.Properties.Resources.check;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(165, 340);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(140, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "افزودن ";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancell.Image = global::GameNet_Management.App.Properties.Resources.remove;
            this.btnCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancell.Location = new System.Drawing.Point(322, 340);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Padding = new System.Windows.Forms.Padding(30, 0, 35, 0);
            this.btnCancell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancell.Size = new System.Drawing.Size(140, 50);
            this.btnCancell.TabIndex = 5;
            this.btnCancell.Text = "لغو";
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.btnSubmit);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerRegDateValue);
            this.gbCustomerInfo.Controls.Add(this.btnCancell);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerRegDate);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerPhone);
            this.gbCustomerInfo.Controls.Add(this.chbIsActive);
            this.gbCustomerInfo.Controls.Add(this.gbImage);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerDescription);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerEmail);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerDescription);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerPhone);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerName);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerName);
            this.gbCustomerInfo.Location = new System.Drawing.Point(12, 8);
            this.gbCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbCustomerInfo.Size = new System.Drawing.Size(626, 400);
            this.gbCustomerInfo.TabIndex = 0;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "اطلاعات مشتری";
            // 
            // lblCustomerRegDateValue
            // 
            this.lblCustomerRegDateValue.Location = new System.Drawing.Point(212, 289);
            this.lblCustomerRegDateValue.Name = "lblCustomerRegDateValue";
            this.lblCustomerRegDateValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerRegDateValue.Size = new System.Drawing.Size(258, 26);
            this.lblCustomerRegDateValue.TabIndex = 5;
            this.lblCustomerRegDateValue.Text = "DateTime";
            this.lblCustomerRegDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerRegDate
            // 
            this.lblCustomerRegDate.AutoSize = true;
            this.lblCustomerRegDate.Location = new System.Drawing.Point(483, 289);
            this.lblCustomerRegDate.Name = "lblCustomerRegDate";
            this.lblCustomerRegDate.Size = new System.Drawing.Size(137, 26);
            this.lblCustomerRegDate.TabIndex = 5;
            this.lblCustomerRegDate.Text = "تاریخ ثبت‌نام مشتری:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(212, 84);
            this.txtCustomerPhone.Mask = "\\0\\900 000 0000";
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.PromptChar = ' ';
            this.txtCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerPhone.Size = new System.Drawing.Size(253, 31);
            this.txtCustomerPhone.TabIndex = 1;
            this.txtCustomerPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCustomerPhone.Enter += new System.EventHandler(this.txtCustomerPhone_Enter);
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Location = new System.Drawing.Point(404, 234);
            this.chbIsActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(61, 30);
            this.chbIsActive.TabIndex = 3;
            this.chbIsActive.Text = "فعال";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.picCustomerImage);
            this.gbImage.Location = new System.Drawing.Point(16, 21);
            this.gbImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbImage.Name = "gbImage";
            this.gbImage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbImage.Size = new System.Drawing.Size(180, 234);
            this.gbImage.TabIndex = 4;
            this.gbImage.TabStop = false;
            // 
            // picCustomerImage
            // 
            this.picCustomerImage.Image = global::GameNet_Management.App.Properties.Resources.default_avatar;
            this.picCustomerImage.Location = new System.Drawing.Point(5, 17);
            this.picCustomerImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCustomerImage.Name = "picCustomerImage";
            this.picCustomerImage.Size = new System.Drawing.Size(170, 211);
            this.picCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomerImage.TabIndex = 2;
            this.picCustomerImage.TabStop = false;
            // 
            // lblCustomerDescription
            // 
            this.lblCustomerDescription.AutoSize = true;
            this.lblCustomerDescription.Location = new System.Drawing.Point(547, 133);
            this.lblCustomerDescription.Name = "lblCustomerDescription";
            this.lblCustomerDescription.Size = new System.Drawing.Size(73, 26);
            this.lblCustomerDescription.TabIndex = 0;
            this.lblCustomerDescription.Text = "توضیحات:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(556, 234);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(64, 26);
            this.lblCustomerEmail.TabIndex = 0;
            this.lblCustomerEmail.Text = "وضعیت:";
            // 
            // txtCustomerDescription
            // 
            this.txtCustomerDescription.Location = new System.Drawing.Point(212, 130);
            this.txtCustomerDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerDescription.Multiline = true;
            this.txtCustomerDescription.Name = "txtCustomerDescription";
            this.txtCustomerDescription.Size = new System.Drawing.Size(253, 87);
            this.txtCustomerDescription.TabIndex = 2;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(526, 87);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(94, 26);
            this.lblCustomerPhone.TabIndex = 0;
            this.lblCustomerPhone.Text = "شماره تلفن: *";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(489, 42);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(131, 26);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "نام و نام خانوادگی: *";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(212, 39);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(253, 31);
            this.txtCustomerName.TabIndex = 0;
            // 
            // ValidName
            // 
            this.ValidName.CancelFocusChangeWhenInvalid = false;
            this.ValidName.ControlToValidate = this.txtCustomerName;
            this.ValidName.ErrorMessage = "لطفا نام و نام خانوادگی را وارد کنید";
            this.ValidName.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidName.Icon")));
            // 
            // ValidPhone
            // 
            this.ValidPhone.CancelFocusChangeWhenInvalid = false;
            this.ValidPhone.ControlToValidate = this.txtCustomerPhone;
            this.ValidPhone.ErrorMessage = "لطفا شماره تلفن را وارد کنید";
            this.ValidPhone.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidPhone.Icon")));
            this.ValidPhone.IsValidated = false;
            this.ValidPhone.OnValidate += new System.EventHandler(this.ValidPhone_OnValidate);
            // 
            // FormAddOrEditCustomers
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancell;
            this.ClientSize = new System.Drawing.Size(650, 421);
            this.Controls.Add(this.gbCustomerInfo);
            this.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FormAddOrEditCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن مشتری";
            this.Load += new System.EventHandler(this.FormAddOrEditCustomers_Load);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox picCustomerImage;
        private System.Windows.Forms.Label lblCustomerDescription;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerDescription;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.MaskedTextBox txtCustomerPhone;
        private ValidationComponents.RequiredFieldValidator ValidName;
        private ValidationComponents.CustomValidator ValidPhone;
        private System.Windows.Forms.Label lblCustomerRegDate;
        private System.Windows.Forms.Label lblCustomerRegDateValue;
    }
}