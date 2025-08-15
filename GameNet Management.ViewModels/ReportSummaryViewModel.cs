using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.ViewModels
{
    public class ReportSummaryViewModel
    {
        public int MonthNewCustomers { get; set; }
        public int TodayNewCustomers { get; set; }
        public int MonthIncome { get; set; }
        public int TodayIncome { get; set; }
        public List<TopCustomersViewModel> TopCustomers { get; set; }
    }
}
