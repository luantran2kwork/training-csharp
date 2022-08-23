using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    static class DateTimePractice
    {
        public static void GetCurrentDay()
        {
            Console.WriteLine($"Hôm nay là thứ {DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                            $" tháng {DateTime.Now.Month}, năm {DateTime.Now.Year}");
        }

        public static void ShowDate(DateTime date)
        {
            Console.WriteLine($"Hôm nay là thứ {date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                            $" tháng {date.Month}, năm {date.Year}");
        }

        public static void GetDateAfter(DateTime date)
        {
            date = date.AddDays(1);
            Console.WriteLine($"Hôm sau là thứ {date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                $" tháng {date.Month}, năm {date.Year}");
        }

        public static void GetDateBefore(DateTime date)
        {
            date = date.AddDays(-1);
            Console.WriteLine($"Hôm trước là thứ {date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                $" tháng {date.Month}, năm {date.Year}");
        }

        public static void CompareDate(DateTime date)
        {
            int res = DateTime.Compare(date, DateTime.Today);
            if (res < 0)
            {
                Console.WriteLine("Ngày quá khứ");
            }
            else if (res == 0)
            {
                Console.WriteLine("Ngày hôm nay");
            }
            else
            {
                Console.WriteLine("Ngày tương lai");
            }
        }

        public static void FormatDate(DateTime date)
        {
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.ToString("yyyy//MM/dd"));
            Console.WriteLine(date.ToString("MM/yyyy"));
            Console.WriteLine(date.ToString("MM-yyyy"));
        }

        public static void Get10DaysBefore(DateTime date) {
            Console.WriteLine(date.AddDays(-10).ToString("ddddd", new System.Globalization.CultureInfo("vi-VN")));
        }

        public static void GetLastDayOfMonth(DateTime date)
        {
            int numberDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month);
            Console.WriteLine(date.AddDays(numberDayOfMonth - date.Day).ToString("ddddd", new System.Globalization.CultureInfo("vi-VN")));
        }

        public static void GetLastDayOfYear(DateTime date)
        {
            int daysLeft = new DateTime(date.Year, 12, 31).DayOfYear - date.DayOfYear;
            Console.WriteLine(date.AddDays(daysLeft).ToString("ddddd", new System.Globalization.CultureInfo("vi-VN")));

        }

        public static void GetDurationBetweenTwoDays(DateTime date1, DateTime date2)
        {
            Console.WriteLine(Math.Abs(date1.Subtract(date2).TotalDays));
        }

    }
}
