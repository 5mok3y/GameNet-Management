using GameNet_Management.App.Device;
using GameNet_Management.App.User;
using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.Utilities.Convertors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameNet_Management.App
{
    public partial class FormMain : Form
    {
        private int? _currentFilterServiceID = null;

        public FormMain()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1400, 788);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToShamsiDateTime();
            lblHelloUser.Text = "خوش آمدید، " + CurrentUser.LoggedInUsername;
            btnAdminDashboard.Enabled = CurrentUser.IsAdmin();
            timerDateTime.Start();

            CreateFilterButtons();
            BindDevices(null);
            pnlDevices.AutoScroll = true;
            pnlFilterButtons.AutoScroll = true;
        }

        private void timerDateTime_Tick_1(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToShamsiDateTime();

            foreach (DeviceCard card in pnlDevices.Controls.OfType<DeviceCard>())
            {
                card.UpdateTimer();
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.ShowDialog();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
            BindDevices(_currentFilterServiceID);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void CreateFilterButtons()
        {
            Button btnAll = new Button();
            btnAll.Name = "btnAllServices";
            btnAll.Text = "همه دستگاه‌ها";
            btnAll.Tag = null;
            btnAll.Click += FilterButton_Click;
            StyleFilterButton(btnAll);

            pnlFilterButtons.Controls.Add(btnAll);

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var services = db.ServicesRepository.Get();
                    foreach (var service in services)
                    {
                        Button btnService = new Button();
                        btnService.Name = "btn" + service.Name;
                        btnService.Text = service.Name;
                        btnService.Tag = service.ServiceID;
                        btnService.Click += FilterButton_Click;
                        StyleFilterButton(btnService);

                        pnlFilterButtons.Controls.Add(btnService);
                    }
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
           
        }

        private void StyleFilterButton(Button btn)
        {
            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Vazirmatn SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Image = global::GameNet_Management.App.Properties.Resources.device_1_;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.RightToLeft = RightToLeft.No;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.UseVisualStyleBackColor = true;
            btn.Text = "  " + btn.Text;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            _currentFilterServiceID = (int?)clickedButton.Tag;

            BindDevices(_currentFilterServiceID);
        }

        private void BindDevices(int? serviceID)
        {
            pnlDevices.SuspendLayout();
            pnlDevices.Controls.Clear();

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    IEnumerable<Devices> devices = db.DevicesRepository.Get(d => d.IsActive == true);

                    if (serviceID.HasValue)
                    {
                        devices = devices.Where(d => d.ServiceID == serviceID.Value);
                    }

                    var activeSessions = db.SessionsRepository.Get(s => s.EndTime == null).ToList();

                    foreach (var device in devices.ToList())
                    {
                        DeviceCard deviceCard = new DeviceCard();

                        var sessionForDevice = activeSessions.FirstOrDefault(s => s.DeviceID == device.DeviceID);

                        deviceCard.SetDeviceData(device, sessionForDevice);
                        deviceCard.DoubleClick += DeviceCard_DoubleClick;

                        pnlDevices.Controls.Add(deviceCard);
                    }
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
            pnlDevices.ResumeLayout();
        }


        private void DeviceCard_DoubleClick(object sender, EventArgs e)
        {
            DeviceCard selectedCard = (DeviceCard)sender;
            int deviceID = (int)selectedCard.Tag;

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var device = db.DevicesRepository.GetByID(deviceID);

                    if (device.Status == DeviceStatus.Available.ToString()) //Device is Available
                    {
                        FormStartSession formStartSession = new FormStartSession(device.DeviceID, device.ServiceID);
                        if (formStartSession.ShowDialog() == DialogResult.OK)
                        {
                            RtlMessageBox.Show("نشست جدید با موفقیت شروع شد", "نشست جدید");
                        }
                    }
                    else // Device is InUse
                    {
                        var activeSession = db.SessionsRepository.Get(s => s.DeviceID == deviceID && s.EndTime == null).FirstOrDefault();

                        if (activeSession == null)
                        {
                            RtlMessageBox.Show("خطا: نشست فعالی برای این دستگاه پیدا نشد", "خطا");
                            return;
                        }

                        FormCheckout formCheckout = new FormCheckout(activeSession.SessionID);
                        if (formCheckout.ShowDialog() == DialogResult.OK)
                        {
                            RtlMessageBox.Show("نشست با موفقیت پایان یافت"); ;
                        }
                    }
                    BindDevices(_currentFilterServiceID);
                }
            }
            catch
            {
                RtlMessageBox.Show("خطا در بارگیری اطلاعات نشست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }        
    }
}
