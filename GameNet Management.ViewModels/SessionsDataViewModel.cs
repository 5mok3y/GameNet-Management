using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.ViewModels
{
    public class SessionsDataViewModel
    {
        public int SessionID { get; set; }
        public string CustomerName { get; set; }
        public string DeviceName { get; set; }
        public string OptionName { get; set; }
        public string TotalPrice { get; set; }
        public string Duration { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
