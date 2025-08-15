using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.ViewModels
{
    public class TopCustomersViewModel
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public decimal TotalSpent { get; set; }
        public int SessionsCount { get; set; }
    }
}
