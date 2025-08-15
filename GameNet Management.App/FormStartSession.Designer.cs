namespace GameNet_Management.App
{
    partial class FormStartSession
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
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.gbSession = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServiceOptions = new System.Windows.Forms.ComboBox();
            this.gbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomers
            // 
            this.gbCustomers.Controls.Add(this.txtFilter);
            this.gbCustomers.Controls.Add(this.dgvCustomers);
            this.gbCustomers.Location = new System.Drawing.Point(12, 12);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbCustomers.Size = new System.Drawing.Size(505, 427);
            this.gbCustomers.TabIndex = 0;
            this.gbCustomers.TabStop = false;
            this.gbCustomers.Text = "انتخاب مشتری";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(493, 32);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Phone,
            this.StatusDisplay});
            this.dgvCustomers.Location = new System.Drawing.Point(6, 70);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 32;
            this.dgvCustomers.Size = new System.Drawing.Size(493, 351);
            this.dgvCustomers.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "شناسه";
            this.CustomerID.MinimumWidth = 75;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام‌خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "شماره تلفن";
            this.Phone.MinimumWidth = 115;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 115;
            // 
            // StatusDisplay
            // 
            this.StatusDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StatusDisplay.DataPropertyName = "StatusDisplay";
            this.StatusDisplay.HeaderText = "وضعیت";
            this.StatusDisplay.Name = "StatusDisplay";
            this.StatusDisplay.ReadOnly = true;
            this.StatusDisplay.Width = 87;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::GameNet_Management.App.Properties.Resources.check;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(13, 362);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(140, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "شروع";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancell.Image = global::GameNet_Management.App.Properties.Resources.remove;
            this.btnCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancell.Location = new System.Drawing.Point(166, 362);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Padding = new System.Windows.Forms.Padding(30, 0, 35, 0);
            this.btnCancell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancell.Size = new System.Drawing.Size(140, 50);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "لغو";
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // gbSession
            // 
            this.gbSession.Controls.Add(this.lblName);
            this.gbSession.Controls.Add(this.lblDeviceName);
            this.gbSession.Controls.Add(this.label2);
            this.gbSession.Controls.Add(this.cbServiceOptions);
            this.gbSession.Controls.Add(this.btnStart);
            this.gbSession.Controls.Add(this.btnCancell);
            this.gbSession.Location = new System.Drawing.Point(523, 12);
            this.gbSession.Name = "gbSession";
            this.gbSession.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbSession.Size = new System.Drawing.Size(319, 427);
            this.gbSession.TabIndex = 1;
            this.gbSession.TabStop = false;
            this.gbSession.Text = "انتخاب تعرفه";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(128, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 27);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "شروع نشست برای دستگاه:";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Font = new System.Drawing.Font("Vazirmatn SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(15, 107);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(297, 52);
            this.lblDeviceName.TabIndex = 6;
            this.lblDeviceName.Text = "lblDeviceName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "انتخاب تعرفه:";
            // 
            // cbServiceOptions
            // 
            this.cbServiceOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceOptions.FormattingEnabled = true;
            this.cbServiceOptions.Location = new System.Drawing.Point(13, 236);
            this.cbServiceOptions.Name = "cbServiceOptions";
            this.cbServiceOptions.Size = new System.Drawing.Size(293, 35);
            this.cbServiceOptions.TabIndex = 0;
            // 
            // FormStartSession
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancell;
            this.ClientSize = new System.Drawing.Size(854, 451);
            this.Controls.Add(this.gbSession);
            this.Controls.Add(this.gbCustomers);
            this.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormStartSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شروع نشست جدید";
            this.Load += new System.EventHandler(this.FormStartSession_Load);
            this.gbCustomers.ResumeLayout(false);
            this.gbCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbSession.ResumeLayout(false);
            this.gbSession.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.GroupBox gbSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServiceOptions;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDisplay;
    }
}