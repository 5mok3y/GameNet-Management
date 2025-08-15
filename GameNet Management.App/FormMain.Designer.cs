namespace GameNet_Management.App
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHelloUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSidebar = new System.Windows.Forms.GroupBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblPic = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.pnlFilterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.groupBoxDevices = new System.Windows.Forms.GroupBox();
            this.pnlDevices = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBoxSidebar.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxDevices.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateTime,
            this.lblSpacer,
            this.lblHelloUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 722);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1384, 27);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Image = global::GameNet_Management.App.Properties.Resources.clock1;
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(82, 22);
            this.lblDateTime.Text = "DateTime";
            // 
            // lblSpacer
            // 
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(1212, 22);
            this.lblSpacer.Spring = true;
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloUser.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHelloUser.Size = new System.Drawing.Size(65, 22);
            this.lblHelloUser.Text = "HelloUser";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick_1);
            // 
            // groupBoxSidebar
            // 
            this.groupBoxSidebar.Controls.Add(this.pnlSidebar);
            this.groupBoxSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxSidebar.Location = new System.Drawing.Point(1058, 0);
            this.groupBoxSidebar.Name = "groupBoxSidebar";
            this.groupBoxSidebar.Size = new System.Drawing.Size(326, 722);
            this.groupBoxSidebar.TabIndex = 0;
            this.groupBoxSidebar.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.lblPic);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnAdminDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(3, 28);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(320, 691);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblPic
            // 
            this.lblPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPic.Image = global::GameNet_Management.App.Properties.Resources.game_over;
            this.lblPic.Location = new System.Drawing.Point(34, 415);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(255, 264);
            this.lblPic.TabIndex = 1;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Image = global::GameNet_Management.App.Properties.Resources.group2;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(34, 32);
            this.btnCustomers.MaximumSize = new System.Drawing.Size(255, 80);
            this.btnCustomers.MinimumSize = new System.Drawing.Size(255, 80);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCustomers.Size = new System.Drawing.Size(255, 80);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "مشتریان";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::GameNet_Management.App.Properties.Resources.logout1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(34, 287);
            this.btnLogout.MaximumSize = new System.Drawing.Size(255, 80);
            this.btnLogout.MinimumSize = new System.Drawing.Size(255, 80);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLogout.Size = new System.Drawing.Size(255, 80);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "خروج کاربر";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Vazirmatn SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashboard.Image = global::GameNet_Management.App.Properties.Resources.settings;
            this.btnAdminDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDashboard.Location = new System.Drawing.Point(34, 160);
            this.btnAdminDashboard.MaximumSize = new System.Drawing.Size(255, 80);
            this.btnAdminDashboard.MinimumSize = new System.Drawing.Size(255, 80);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdminDashboard.Size = new System.Drawing.Size(255, 80);
            this.btnAdminDashboard.TabIndex = 1;
            this.btnAdminDashboard.Text = "داشبورد مدیریت";
            this.btnAdminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminDashboard.UseVisualStyleBackColor = true;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // pnlFilterButtons
            // 
            this.pnlFilterButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterButtons.Location = new System.Drawing.Point(3, 28);
            this.pnlFilterButtons.Name = "pnlFilterButtons";
            this.pnlFilterButtons.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFilterButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlFilterButtons.Size = new System.Drawing.Size(1046, 94);
            this.pnlFilterButtons.TabIndex = 0;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.groupBoxDevices);
            this.groupBoxMain.Controls.Add(this.groupBoxFilters);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(1058, 722);
            this.groupBoxMain.TabIndex = 1;
            this.groupBoxMain.TabStop = false;
            // 
            // groupBoxDevices
            // 
            this.groupBoxDevices.Controls.Add(this.pnlDevices);
            this.groupBoxDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDevices.Location = new System.Drawing.Point(3, 153);
            this.groupBoxDevices.Name = "groupBoxDevices";
            this.groupBoxDevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxDevices.Size = new System.Drawing.Size(1052, 566);
            this.groupBoxDevices.TabIndex = 1;
            this.groupBoxDevices.TabStop = false;
            this.groupBoxDevices.Text = "دستگاه ها";
            // 
            // pnlDevices
            // 
            this.pnlDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDevices.Location = new System.Drawing.Point(3, 28);
            this.pnlDevices.Name = "pnlDevices";
            this.pnlDevices.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.pnlDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlDevices.Size = new System.Drawing.Size(1046, 535);
            this.pnlDevices.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.pnlFilterButtons);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFilters.Location = new System.Drawing.Point(3, 28);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxFilters.Size = new System.Drawing.Size(1052, 125);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "فیلترها";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1384, 749);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.groupBoxSidebar);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameNet Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxSidebar.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxDevices.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.ToolStripStatusLabel lblHelloUser;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.GroupBox groupBoxSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel pnlFilterButtons;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBoxDevices;
        private System.Windows.Forms.FlowLayoutPanel pnlDevices;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblPic;
    }
}