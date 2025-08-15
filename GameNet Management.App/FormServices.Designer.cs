namespace GameNet_Management.App
{
    partial class FormServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvServiceOptions = new System.Windows.Forms.DataGridView();
            this.OptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteOption = new System.Windows.Forms.Button();
            this.btnEditOption = new System.Windows.Forms.Button();
            this.btnAddOption = new System.Windows.Forms.Button();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceOptions)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxService);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 561);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvServiceOptions);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(510, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعرفه های سرویس";
            // 
            // dgvServiceOptions
            // 
            this.dgvServiceOptions.AllowUserToAddRows = false;
            this.dgvServiceOptions.AllowUserToDeleteRows = false;
            this.dgvServiceOptions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvServiceOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OptionID,
            this.OptionDescription,
            this.PricePerHour});
            this.dgvServiceOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceOptions.Location = new System.Drawing.Point(3, 28);
            this.dgvServiceOptions.Name = "dgvServiceOptions";
            this.dgvServiceOptions.ReadOnly = true;
            this.dgvServiceOptions.RowTemplate.Height = 30;
            this.dgvServiceOptions.Size = new System.Drawing.Size(504, 422);
            this.dgvServiceOptions.TabIndex = 1;
            this.dgvServiceOptions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceOptions_CellDoubleClick);
            // 
            // OptionID
            // 
            this.OptionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OptionID.DataPropertyName = "OptionID";
            this.OptionID.HeaderText = "شناسه";
            this.OptionID.MinimumWidth = 75;
            this.OptionID.Name = "OptionID";
            this.OptionID.ReadOnly = true;
            this.OptionID.Visible = false;
            // 
            // OptionDescription
            // 
            this.OptionDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OptionDescription.DataPropertyName = "Description";
            this.OptionDescription.HeaderText = "شرح تعرفه";
            this.OptionDescription.Name = "OptionDescription";
            this.OptionDescription.ReadOnly = true;
            // 
            // PricePerHour
            // 
            this.PricePerHour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PricePerHour.DataPropertyName = "PricePerHour";
            dataGridViewCellStyle2.Format = " #,0 تومان";
            dataGridViewCellStyle2.NullValue = null;
            this.PricePerHour.DefaultCellStyle = dataGridViewCellStyle2;
            this.PricePerHour.HeaderText = "قیمت هر ساعت";
            this.PricePerHour.MinimumWidth = 170;
            this.PricePerHour.Name = "PricePerHour";
            this.PricePerHour.ReadOnly = true;
            this.PricePerHour.Width = 170;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteOption);
            this.panel2.Controls.Add(this.btnEditOption);
            this.panel2.Controls.Add(this.btnAddOption);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 87);
            this.panel2.TabIndex = 0;
            // 
            // btnDeleteOption
            // 
            this.btnDeleteOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteOption.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteOption.FlatAppearance.BorderSize = 0;
            this.btnDeleteOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOption.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOption.Image = global::GameNet_Management.App.Properties.Resources.delete_1_;
            this.btnDeleteOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOption.Location = new System.Drawing.Point(15, 17);
            this.btnDeleteOption.Name = "btnDeleteOption";
            this.btnDeleteOption.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDeleteOption.Size = new System.Drawing.Size(150, 57);
            this.btnDeleteOption.TabIndex = 2;
            this.btnDeleteOption.Text = "حذف تعرفه";
            this.btnDeleteOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteOption.UseVisualStyleBackColor = true;
            this.btnDeleteOption.Click += new System.EventHandler(this.btnDeleteOption_Click);
            // 
            // btnEditOption
            // 
            this.btnEditOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditOption.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditOption.FlatAppearance.BorderSize = 0;
            this.btnEditOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOption.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOption.Image = global::GameNet_Management.App.Properties.Resources.edit_1_;
            this.btnEditOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditOption.Location = new System.Drawing.Point(187, 17);
            this.btnEditOption.Name = "btnEditOption";
            this.btnEditOption.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEditOption.Size = new System.Drawing.Size(150, 57);
            this.btnEditOption.TabIndex = 1;
            this.btnEditOption.Text = "ویرایش تعرفه";
            this.btnEditOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditOption.UseVisualStyleBackColor = true;
            this.btnEditOption.Click += new System.EventHandler(this.btnEditOption_Click);
            // 
            // btnAddOption
            // 
            this.btnAddOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddOption.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddOption.FlatAppearance.BorderSize = 0;
            this.btnAddOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOption.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOption.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOption.Image")));
            this.btnAddOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOption.Location = new System.Drawing.Point(358, 17);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAddOption.Size = new System.Drawing.Size(150, 57);
            this.btnAddOption.TabIndex = 0;
            this.btnAddOption.Text = "افزودن تعرفه";
            this.btnAddOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOption.UseVisualStyleBackColor = true;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.dgvServices);
            this.groupBoxService.Location = new System.Drawing.Point(3, 93);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxService.Size = new System.Drawing.Size(506, 456);
            this.groupBoxService.TabIndex = 1;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "سرویس ها";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName});
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(3, 28);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowTemplate.Height = 30;
            this.dgvServices.Size = new System.Drawing.Size(500, 425);
            this.dgvServices.TabIndex = 1;
            this.dgvServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellDoubleClick);
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "شناسه";
            this.ServiceID.MinimumWidth = 75;
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.DataPropertyName = "Name";
            this.ServiceName.HeaderText = "نام سرویس";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteService);
            this.panel1.Controls.Add(this.btnEditService);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteService.FlatAppearance.BorderSize = 0;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.Image = global::GameNet_Management.App.Properties.Resources.delete_1_;
            this.btnDeleteService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteService.Location = new System.Drawing.Point(16, 17);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDeleteService.Size = new System.Drawing.Size(150, 57);
            this.btnDeleteService.TabIndex = 2;
            this.btnDeleteService.Text = "حذف سرویس";
            this.btnDeleteService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditService.FlatAppearance.BorderSize = 0;
            this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditService.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditService.Image = global::GameNet_Management.App.Properties.Resources.edit_1_;
            this.btnEditService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditService.Location = new System.Drawing.Point(185, 17);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(150, 57);
            this.btnEditService.TabIndex = 1;
            this.btnEditService.Text = "ویرایش سرویس";
            this.btnEditService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.Image")));
            this.btnAddService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.Location = new System.Drawing.Point(356, 17);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(150, 57);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "افزودن سرویس";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "سرویس ها";
            this.Load += new System.EventHandler(this.FormServices_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceOptions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteOption;
        private System.Windows.Forms.Button btnEditOption;
        private System.Windows.Forms.Button btnAddOption;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvServiceOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerHour;
    }
}