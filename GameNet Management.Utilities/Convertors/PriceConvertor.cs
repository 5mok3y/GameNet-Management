using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.Utilities.Convertors
{
    public static class PriceConvertor
    {
        public static decimal RoundPrice(decimal price)
        {
            return Math.Ceiling(price / 1000) * 1000;
        }

        public static string ToTooman(this int price)
        {
            return price.ToString("#,0 ") + "تومان";
        }
        public static string ToTooman(this decimal price)
        {
            return price.ToString("#,0 ") + "تومان";
        }
    }
}
