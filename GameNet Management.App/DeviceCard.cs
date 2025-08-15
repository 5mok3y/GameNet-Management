using GameNet_Management.App.Device;
using GameNet_Management.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace GameNet_Management.App
{
    public partial class DeviceCard : UserControl
    {
        private DateTime? _sessionStartTime;
        public DeviceCard()
        {
            InitializeComponent();
        }

        

        public void SetDeviceData(Devices device, Sessions activeSession = null)
        {
            this.Tag = device.DeviceID;
            lblDeviceName.Text = device.Name;

            if (device.Status == DeviceStatus.Available.ToString())
            {
                _sessionStartTime = null;
                lblStatus.Text = "آزاد";
                lblCustomerName.Text = "-";
                lblTimer.Text = "-";
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.FromArgb(0x43, 0xA0, 0x47); //Green color


            }
            else
            {
                lblStatus.Text = "درحال استفاده";
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.FromArgb(0xE5, 0x39, 0x35); //Red color

                if (activeSession != null)
                {
                    _sessionStartTime = activeSession.StartTime;
                    lblCustomerName.Text = activeSession.Customers.FullName;
                    UpdateTimer();
                }
            }
        }

        public void UpdateTimer()
        {
            if (_sessionStartTime.HasValue)
            {
                TimeSpan duration = DateTime.Now - _sessionStartTime.Value;
                lblTimer.Text = duration.ToString(@"hh\:mm\:ss");
            }
        }

        private void Card_DoubleClick(object sender, MouseEventArgs e)
        {
            this.OnDoubleClick(e);
        }
    }
}
