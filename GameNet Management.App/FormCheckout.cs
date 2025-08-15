using GameNet_Management.App.Device;
using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.Utilities.Convertors;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GameNet_Management.App
{
    public partial class FormCheckout : Form
    {   
        private int _sessionID;

        decimal pricePerHour;
        DateTime endTime = DateTime.Now;
        TimeSpan duration;
        decimal totalPrice;
        // saving these date from form_load for preventing difference of values in time that form stays open
        public FormCheckout(int sessionID)
        {
            InitializeComponent();
            _sessionID = sessionID;
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var sessionToEnd = db.SessionsRepository.GetByID(_sessionID);

                    if (sessionToEnd == null)
                    {
                        RtlMessageBox.Show("نشست مورد نظر یافت نشد", "خطا");
                        this.Close();
                        return;
                    }

                    pricePerHour = sessionToEnd.ServiceOptions.PricePerHour;
                    duration = (TimeSpan)(endTime - sessionToEnd.StartTime);
                    totalPrice = PriceConvertor.RoundPrice((decimal)duration.TotalHours * pricePerHour);

                    this.lblCustomer.Text = sessionToEnd.Customers.FullName;
                    this.lblDevice.Text = sessionToEnd.Devices.Name;
                    this.lblDuration.Text = duration.ToString(@"hh\:mm\:ss");
                    this.lblPrice.Text = totalPrice.ToTooman();
                    this.lblOptionName.Text = sessionToEnd.ServiceOptions.Description;
                }
            }
            catch (Exception)
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }      
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (RtlMessageBox.Show("این نشست به عنوان پرداخت شده پایان می‌یابد، آیا از پایان نشست اطمینان دارید؟", "پایان نشست", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var sessionToEnd = db.SessionsRepository.GetByID(_sessionID);
                        var deviceToFree = db.DevicesRepository.GetByID(sessionToEnd.DeviceID);

                        
                        sessionToEnd.EndTime = endTime;
                        sessionToEnd.TotalPrice = totalPrice;
                        sessionToEnd.TotalMinutes = (int)duration.TotalMinutes;
                        sessionToEnd.IsPaid = true;
                        deviceToFree.Status = DeviceStatus.Available.ToString();

                        db.SessionsRepository.Update(sessionToEnd);
                        db.DevicesRepository.Update(deviceToFree);
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    RtlMessageBox.Show("خطایی غیر منتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
        }
    }
}
