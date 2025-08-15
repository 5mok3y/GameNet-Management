using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.ViewModels
{
    public class DeviceDataViewModel
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string ServiceName { get; set; }
        public int ServiceID { get; set; }
        public string Status { get; set; }
        public string IsActive { get; set; }
    }
}
