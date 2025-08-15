using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.Utilities.Convertors
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime dt)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(dt) + "/" + persianCalendar.GetMonth(dt).ToString("00") + "/" + persianCalendar.GetDayOfMonth(dt).ToString("00");
        }

        public static string ToShamsiDateTime(this DateTime dt)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(dt) + "/" + persianCalendar.GetMonth(dt).ToString("00") + "/" + persianCalendar.GetDayOfMonth(dt).ToString("00")
                + "  -  " + persianCalendar.GetHour(dt).ToString("00") + ":" + persianCalendar.GetMinute(dt).ToString("00") + ":" + persianCalendar.GetSecond(dt).ToString("00");
        }

        public static DateTime ToMiladi(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, new System.Globalization.PersianCalendar());
        }
    }
}
