namespace GameNet_Management.App
{
    partial class FormDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTodayIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTodayNewCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonthNewCustomers = new System.Windows.Forms.Label();
            this.groupBoxTopCustomers = new System.Windows.Forms.GroupBox();
            this.dgvTopCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSidebar.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxTopCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.groupBoxActions);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(953, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(311, 681);
            this.panelSidebar.TabIndex = 0;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnPersonnel);
            this.groupBoxActions.Controls.Add(this.btnClose);
            this.groupBoxActions.Controls.Add(this.btnServices);
            this.groupBoxActions.Controls.Add(this.btnDevices);
            this.groupBoxActions.Controls.Add(this.btnReports);
            this.groupBoxActions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(308, 678);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.Image = global::GameNet_Management.App.Properties.Resources.group2;
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(33, 42);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPersonnel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPersonnel.Size = new System.Drawing.Size(240, 80);
            this.btnPersonnel.TabIndex = 0;
            this.btnPersonnel.Text = "مدیریت پرسنل";
            this.btnPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonnel.UseVisualStyleBackColor = true;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GameNet_Management.App.Properties.Resources.logout1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(33, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClose.Size = new System.Drawing.Size(240, 80);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج از داشبورد";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnServices
            // 
            this.btnServices.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.Image = global::GameNet_Management.App.Properties.Resources.console;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(33, 171);
            this.btnServices.Name = "btnServices";
            this.btnServices.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnServices.Size = new System.Drawing.Size(240, 80);
            this.btnServices.TabIndex = 1;
            this.btnServices.Text = "خدمات";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevices.Image = global::GameNet_Management.App.Properties.Resources.device;
            this.btnDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevices.Location = new System.Drawing.Point(33, 302);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDevices.Size = new System.Drawing.Size(240, 80);
            this.btnDevices.TabIndex = 2;
            this.btnDevices.Text = "دستگاه ها";
            this.btnDevices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = global::GameNet_Management.App.Properties.Resources.business_report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(33, 431);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReports.Size = new System.Drawing.Size(240, 80);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "گزارش ها";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.lblTodayIncome);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.lblMonthIncome);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.lblTodayNewCustomers);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.lblMonthNewCustomers);
            this.groupBoxInfo.Location = new System.Drawing.Point(567, 3);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxInfo.Size = new System.Drawing.Size(383, 666);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "خلاصه وضعیت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "درآمد امروز:";
            // 
            // lblTodayIncome
            // 
            this.lblTodayIncome.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayIncome.Location = new System.Drawing.Point(67, 274);
            this.lblTodayIncome.Name = "lblTodayIncome";
            this.lblTodayIncome.Size = new System.Drawing.Size(298, 42);
            this.lblTodayIncome.TabIndex = 0;
            this.lblTodayIncome.Text = "مقدار درآمد امروز";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "درآمد این ماه:";
            // 
            // lblMonthIncome
            // 
            this.lblMonthIncome.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthIncome.Location = new System.Drawing.Point(68, 134);
            this.lblMonthIncome.Name = "lblMonthIncome";
            this.lblMonthIncome.Size = new System.Drawing.Size(297, 42);
            this.lblMonthIncome.TabIndex = 0;
            this.lblMonthIncome.Text = "مقدار درآمد این ماه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "مشتریان جدید امروز:";
            // 
            // lblTodayNewCustomers
            // 
            this.lblTodayNewCustomers.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayNewCustomers.Location = new System.Drawing.Point(68, 556);
            this.lblTodayNewCustomers.Name = "lblTodayNewCustomers";
            this.lblTodayNewCustomers.Size = new System.Drawing.Size(297, 42);
            this.lblTodayNewCustomers.TabIndex = 0;
            this.lblTodayNewCustomers.Text = "مقدار مشتریان جدید امروز";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشتریان جدید این ماه:";
            // 
            // lblMonthNewCustomers
            // 
            this.lblMonthNewCustomers.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthNewCustomers.Location = new System.Drawing.Point(67, 416);
            this.lblMonthNewCustomers.Name = "lblMonthNewCustomers";
            this.lblMonthNewCustomers.Size = new System.Drawing.Size(298, 42);
            this.lblMonthNewCustomers.TabIndex = 0;
            this.lblMonthNewCustomers.Text = "مقدار مشتریان جدید این ماه";
            // 
            // groupBoxTopCustomers
            // 
            this.groupBoxTopCustomers.Controls.Add(this.dgvTopCustomers);
            this.groupBoxTopCustomers.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTopCustomers.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTopCustomers.Name = "groupBoxTopCustomers";
            this.groupBoxTopCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxTopCustomers.Size = new System.Drawing.Size(549, 666);
            this.groupBoxTopCustomers.TabIndex = 2;
            this.groupBoxTopCustomers.TabStop = false;
            this.groupBoxTopCustomers.Text = "مشتریان برتر";
            // 
            // dgvTopCustomers
            // 
            this.dgvTopCustomers.AllowUserToAddRows = false;
            this.dgvTopCustomers.AllowUserToDeleteRows = false;
            this.dgvTopCustomers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.TotalSpent,
            this.SessionsCount});
            this.dgvTopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopCustomers.Location = new System.Drawing.Point(3, 28);
            this.dgvTopCustomers.Name = "dgvTopCustomers";
            this.dgvTopCustomers.ReadOnly = true;
            this.dgvTopCustomers.RowTemplate.Height = 30;
            this.dgvTopCustomers.Size = new System.Drawing.Size(543, 635);
            this.dgvTopCustomers.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "شناسه";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.MinimumWidth = 150;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // TotalSpent
            // 
            this.TotalSpent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSpent.DataPropertyName = "TotalSpent";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,0 تومان";
            this.TotalSpent.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalSpent.HeaderText = "مبلغ";
            this.TotalSpent.MinimumWidth = 100;
            this.TotalSpent.Name = "TotalSpent";
            this.TotalSpent.ReadOnly = true;
            // 
            // SessionsCount
            // 
            this.SessionsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SessionsCount.DataPropertyName = "SessionsCount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SessionsCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.SessionsCount.HeaderText = "تعداد نشست";
            this.SessionsCount.MinimumWidth = 115;
            this.SessionsCount.Name = "SessionsCount";
            this.SessionsCount.ReadOnly = true;
            this.SessionsCount.Width = 124;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBoxTopCustomers);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "داشبود مدیریت";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxTopCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblTodayIncome;
        private System.Windows.Forms.Label lblMonthIncome;
        private System.Windows.Forms.Label lblTodayNewCustomers;
        private System.Windows.Forms.Label lblMonthNewCustomers;
        private System.Windows.Forms.GroupBox groupBoxTopCustomers;
        private System.Windows.Forms.DataGridView dgvTopCustomers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionsCount;
    }
}