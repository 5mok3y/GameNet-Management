namespace GameNet_Management.App
{
    partial class FormAddOrEditServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditServices));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.ValidServiceName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblServiceName);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(491, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات سرویس";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(364, 84);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(101, 27);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "نام سرویس: *";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(25, 81);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(315, 32);
            this.txtServiceName.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::GameNet_Management.App.Properties.Resources.check;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(110, 187);
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
            this.btnCancell.Location = new System.Drawing.Point(267, 187);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Padding = new System.Windows.Forms.Padding(30, 0, 35, 0);
            this.btnCancell.Size = new System.Drawing.Size(140, 50);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "لغو";
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // ValidServiceName
            // 
            this.ValidServiceName.CancelFocusChangeWhenInvalid = false;
            this.ValidServiceName.ControlToValidate = this.txtServiceName;
            this.ValidServiceName.ErrorMessage = "لطفا نام سرویس را وارد کنید";
            this.ValidServiceName.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidServiceName.Icon")));
            // 
            // FormAddOrEditServices
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancell;
            this.ClientSize = new System.Drawing.Size(517, 270);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormAddOrEditServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن سرویس";
            this.Load += new System.EventHandler(this.FormAddOrEditServices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox txtServiceName;
        private ValidationComponents.RequiredFieldValidator ValidServiceName;
    }
}