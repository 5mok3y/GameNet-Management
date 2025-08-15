namespace GameNet_Management.App
{
    partial class DeviceCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDeviceName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(235, 217);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 1);
            this.label6.TabIndex = 12;
            this.label6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 1);
            this.label5.TabIndex = 11;
            this.label5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::GameNet_Management.App.Properties.Resources.hour_glass_1_;
            this.label3.Location = new System.Drawing.Point(201, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 30);
            this.label3.TabIndex = 3;
            this.label3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Vazirmatn SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(3, 179);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(192, 30);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GameNet_Management.App.Properties.Resources.user;
            this.label2.Location = new System.Drawing.Point(201, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 30);
            this.label2.TabIndex = 5;
            this.label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Vazirmatn SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(3, 124);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(192, 30);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "CustomerName";
            this.lblCustomerName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::GameNet_Management.App.Properties.Resources.question_mark;
            this.label1.Location = new System.Drawing.Point(201, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 7;
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 3);
            this.label4.TabIndex = 8;
            this.label4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Vazirmatn SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(192, 30);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            this.lblStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Font = new System.Drawing.Font("Vazirmatn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(8, 8);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeviceName.Size = new System.Drawing.Size(219, 44);
            this.lblDeviceName.TabIndex = 10;
            this.lblDeviceName.Text = "DeviceName";
            this.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDeviceName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            // 
            // DeviceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "DeviceCard";
            this.Size = new System.Drawing.Size(243, 225);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Card_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDeviceName;
    }
}
