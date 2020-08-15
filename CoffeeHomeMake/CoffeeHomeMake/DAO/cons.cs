using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoffeeHomeMake.DAO
{
    public class cons
    {
        public static int Table_Width = 119;
        public static int Table_Height = 85;

        public static int Category_Width = 175;
        public static int Category_Height = 100;

        public static int Food_Width = 115;
        public static int Food_Height = 115;
        public static CultureInfo culture = new CultureInfo("vi-VN");

        public static int BillInfo_Width = 475;
        public static int BillInfo_Height = 80;

        public static bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
    }
}
