using GameNet_Management.DataLayer.Context;
using GameNet_Management.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNet_Management.App.Reports
{
    public static class ReportSummary
    {
        public static ReportSummaryViewModel DashboardReports()
        {
            try
			{
                ReportSummaryViewModel report = new ReportSummaryViewModel();
                using (UnitOfWork db = new UnitOfWork())
                {
                    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    DateTime monthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                    DateTime monthEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, daysInMonth, 23, 59, 59);

                    DateTime dayStart = DateTime.Today;
                    DateTime dayEnd = dayStart.AddDays(1).AddTicks(-1);

                    var topCustomers = db.CustomerRepository.Get().Select(c => new TopCustomersViewModel()
                    {
                        CustomerID = c.CustomerID,
                        FullName = c.FullName,
                        TotalSpent = c.Sessions.Where(s => s.IsPaid == true).Sum(s => s.TotalPrice.Value),
                        SessionsCount = c.Sessions.Count(s => s.IsPaid == true)
                    }).OrderByDescending(c => c.TotalSpent).Take(100).ToList();

                    report.MonthIncome = (int)(db.SessionsRepository.Get(s => s.IsPaid == true && s.EndTime >= monthStart && s.EndTime <= monthEnd).Sum(s => s.TotalPrice) ?? 0m);
                    report.TodayIncome = (int)(db.SessionsRepository.Get(s => s.IsPaid == true && s.EndTime >= dayStart && s.EndTime <= dayEnd).Sum(s => s.TotalPrice) ?? 0m);

                    report.MonthNewCustomers = db.CustomerRepository.Get(c => c.RegisterDate >= monthStart && c.RegisterDate <= monthEnd).Count();
                    report.TodayNewCustomers = db.CustomerRepository.Get(c => c.RegisterDate >= dayStart && c.RegisterDate <= dayEnd).Count();
                    report.TopCustomers = topCustomers;
                    return report;
                }
            }
			catch
			{
                return new ReportSummaryViewModel();
            }
        }
    }
}
