namespace GameNet_Management.App
{
    partial class FormAddOrEditOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditOptions));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblToman = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ValidDescription = new ValidationComponents.RequiredFieldValidator(this.components);
            this.ValidPrice = new ValidationComponents.RangeValidator(this.components);
            this.ValidService = new ValidationComponents.CustomValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::GameNet_Management.App.Properties.Resources.check;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(109, 271);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSubmit.Size = new System.Drawing.Size(140, 50);
            this.btnSubmit.TabIndex = 1;
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
            this.btnCancell.Location = new System.Drawing.Point(266, 271);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Padding = new System.Windows.Forms.Padding(30, 0, 35, 0);
            this.btnCancell.Size = new System.Drawing.Size(140, 50);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "لغو";
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.cbService);
            this.groupBox1.Controls.Add(this.lblService);
            this.groupBox1.Controls.Add(this.lblToman);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(491, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات تعرفه";
            // 
            // txtPrice
            // 
            this.txtPrice.InterceptArrowKeys = false;
            this.txtPrice.Location = new System.Drawing.Point(180, 121);
            this.txtPrice.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(157, 32);
            this.txtPrice.TabIndex = 1;
            // 
            // cbService
            // 
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(180, 58);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(157, 35);
            this.cbService.TabIndex = 0;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(405, 61);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(78, 27);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "سرویس: *";
            // 
            // lblToman
            // 
            this.lblToman.AutoSize = true;
            this.lblToman.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToman.Location = new System.Drawing.Point(135, 126);
            this.lblToman.Name = "lblToman";
            this.lblToman.Size = new System.Drawing.Size(39, 22);
            this.lblToman.TabIndex = 1;
            this.lblToman.Text = "تومان";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(354, 126);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(129, 27);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "قیمت هر ساعت: *";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(389, 186);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 27);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "شرح تعرفه: *";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(30, 183);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 32);
            this.txtDescription.TabIndex = 2;
            // 
            // ValidDescription
            // 
            this.ValidDescription.CancelFocusChangeWhenInvalid = false;
            this.ValidDescription.ControlToValidate = this.txtDescription;
            this.ValidDescription.ErrorMessage = "لطفا شرح را وارد کنید";
            this.ValidDescription.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidDescription.Icon")));
            // 
            // ValidPrice
            // 
            this.ValidPrice.CancelFocusChangeWhenInvalid = false;
            this.ValidPrice.ControlToValidate = this.txtPrice;
            this.ValidPrice.ErrorMessage = "لطفا مبلغ را وارد کنید";
            this.ValidPrice.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidPrice.Icon")));
            this.ValidPrice.MaximumValue = "9999999999999";
            this.ValidPrice.MinimumValue = "1";
            this.ValidPrice.Type = ValidationComponents.ValidationDataType.Integer;
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
            // FormAddOrEditOptions
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancell;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormAddOrEditOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن تعرفه";
            this.Load += new System.EventHandler(this.FormAddOrEditOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblToman;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbService;
        private ValidationComponents.RequiredFieldValidator ValidDescription;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private ValidationComponents.RangeValidator ValidPrice;
        private ValidationComponents.CustomValidator ValidService;
    }
}