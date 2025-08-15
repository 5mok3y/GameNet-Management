namespace GameNet_Management.App
{
    partial class FormAddOrEditDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditDevices));
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ValidName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.ValidService = new ValidationComponents.CustomValidator(this.components);
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.chbIsActive);
            this.groupBoxInfo.Controls.Add(this.btnCancell);
            this.groupBoxInfo.Controls.Add(this.btnSubmit);
            this.groupBoxInfo.Controls.Add(this.cbService);
            this.groupBoxInfo.Controls.Add(this.txtDeviceName);
            this.groupBoxInfo.Controls.Add(this.lblIsActive);
            this.groupBoxInfo.Controls.Add(this.lblService);
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxInfo.Size = new System.Drawing.Size(453, 290);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "مشخصات دستگاه";
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Location = new System.Drawing.Point(272, 163);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(61, 31);
            this.chbIsActive.TabIndex = 2;
            this.chbIsActive.Text = "فعال";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnCancell
            // 
            this.btnCancell.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancell.Image = global::GameNet_Management.App.Properties.Resources.remove;
            this.btnCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancell.Location = new System.Drawing.Point(235, 223);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Padding = new System.Windows.Forms.Padding(30, 0, 35, 0);
            this.btnCancell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancell.Size = new System.Drawing.Size(140, 50);
            this.btnCancell.TabIndex = 4;
            this.btnCancell.Text = "لغو";
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::GameNet_Management.App.Properties.Resources.check;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(78, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(140, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "افزودن";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbService
            // 
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(24, 112);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(309, 35);
            this.cbService.TabIndex = 1;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(24, 62);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(309, 32);
            this.txtDeviceName.TabIndex = 0;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(380, 167);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(66, 27);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "وضعیت:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(380, 115);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(67, 27);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "سرویس:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(351, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 27);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "شرح دستگاه:";
            // 
            // ValidName
            // 
            this.ValidName.CancelFocusChangeWhenInvalid = false;
            this.ValidName.ControlToValidate = this.txtDeviceName;
            this.ValidName.ErrorMessage = "لطفا شرح دستگاه را وارد کنید";
            this.ValidName.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidName.Icon")));
            // 
            // ValidService
            // 
            this.ValidService.CancelFocusChangeWhenInvalid = false;
            this.ValidService.ControlToValidate = this.cbService;
            this.ValidService.ErrorMessage = "لطفا سرویس را انتخاب کنید";
            this.ValidService.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidService.Icon")));
            this.ValidService.IsValidated = false;
            this.ValidService.OnValidate += new System.EventHandler(this.ValidService_OnValidate);
            // 
            // FormAddOrEditDevices
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancell;
            this.ClientSize = new System.Drawing.Size(474, 314);
            this.Controls.Add(this.groupBoxInfo);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormAddOrEditDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن دستگاه";
            this.Load += new System.EventHandler(this.FormAddOrEditDevices_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancell;
        private ValidationComponents.RequiredFieldValidator ValidName;
        private ValidationComponents.CustomValidator ValidService;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Label lblIsActive;
    }
}