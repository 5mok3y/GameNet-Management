namespace GameNet_Management.App
{
    partial class FormReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtEndDate = new System.Windows.Forms.MaskedTextBox();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServiceName = new System.Windows.Forms.ComboBox();
            this.cbDeviceName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.SessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnCustomer);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbServiceName);
            this.groupBox1.Controls.Add(this.cbDeviceName);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1240, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::GameNet_Management.App.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(1, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(96, 82);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "چاپ گزارش";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(1071, 36);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(163, 36);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "انتخاب مشتری";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(121, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 35);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "بازخوانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(240, 36);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 35);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "جستجو";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(404, 37);
            this.txtEndDate.Mask = "0000/00/00";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEndDate.Size = new System.Drawing.Size(90, 32);
            this.txtEndDate.TabIndex = 5;
            this.txtEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(573, 37);
            this.txtStartDate.Mask = "0000/00/00";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStartDate.Size = new System.Drawing.Size(90, 32);
            this.txtStartDate.TabIndex = 4;
            this.txtStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "تا تاریخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ:";
            // 
            // cbServiceName
            // 
            this.cbServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceName.FormattingEnabled = true;
            this.cbServiceName.Location = new System.Drawing.Point(907, 37);
            this.cbServiceName.Name = "cbServiceName";
            this.cbServiceName.Size = new System.Drawing.Size(150, 35);
            this.cbServiceName.TabIndex = 2;
            this.cbServiceName.SelectedIndexChanged += new System.EventHandler(this.cbServiceName_SelectedIndexChanged);
            // 
            // cbDeviceName
            // 
            this.cbDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceName.FormattingEnabled = true;
            this.cbDeviceName.Location = new System.Drawing.Point(741, 37);
            this.cbDeviceName.Name = "cbDeviceName";
            this.cbDeviceName.Size = new System.Drawing.Size(150, 35);
            this.cbDeviceName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvReports);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1240, 564);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش‌ نشست ها";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SessionID,
            this.CustomerName,
            this.DeviceName,
            this.OptionName,
            this.TotalPrice,
            this.Duration,
            this.StartDate,
            this.StartTime,
            this.EndTime});
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(3, 28);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowTemplate.Height = 35;
            this.dgvReports.Size = new System.Drawing.Size(1234, 533);
            this.dgvReports.TabIndex = 0;
            // 
            // SessionID
            // 
            this.SessionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SessionID.DataPropertyName = "SessionID";
            this.SessionID.HeaderText = "شناسه";
            this.SessionID.Name = "SessionID";
            this.SessionID.ReadOnly = true;
            this.SessionID.Width = 80;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "مشتری";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "دستگاه";
            this.DeviceName.MinimumWidth = 120;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Width = 120;
            // 
            // OptionName
            // 
            this.OptionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OptionName.DataPropertyName = "OptionName";
            this.OptionName.HeaderText = "تعرفه";
            this.OptionName.MinimumWidth = 125;
            this.OptionName.Name = "OptionName";
            this.OptionName.ReadOnly = true;
            this.OptionName.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalPrice.HeaderText = "مبلغ";
            this.TotalPrice.MinimumWidth = 165;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 165;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Duration.DataPropertyName = "Duration";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Duration.DefaultCellStyle = dataGridViewCellStyle2;
            this.Duration.HeaderText = "زمان سپری شده";
            this.Duration.MinimumWidth = 140;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 140;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.StartDate.HeaderText = "تاریخ ایجاد";
            this.StartDate.MinimumWidth = 105;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 105;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartTime.DataPropertyName = "StartTime";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.StartTime.HeaderText = "زمان شروع";
            this.StartTime.MinimumWidth = 105;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 105;
            // 
            // EndTime
            // 
            this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EndTime.DataPropertyName = "EndTime";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EndTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.EndTime.HeaderText = "زمان پایان";
            this.EndTime.MinimumWidth = 105;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 105;
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "58499eb8961e4d90bbce2c2ec92d1d3f";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "گزارش ها";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MaskedTextBox txtEndDate;
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.ComboBox cbDeviceName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbServiceName;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private Stimulsoft.Report.StiReport stiPrint;
    }
}