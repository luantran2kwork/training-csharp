using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    static class DateTimePractice
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("1. GetCurrentDay");
            Console.WriteLine("2. ShowDate");
            Console.WriteLine("3. GetDateAfter");
            Console.WriteLine("4. GetDateBefore");
            Console.WriteLine("5. CompareDate");
            Console.WriteLine("6. FormatDate");
            Console.WriteLine("7. Get10DaysBefore");
            Console.WriteLine("8. GetLastDayOfMonth");
            Console.WriteLine("9. GetLastDayOfYear");
            Console.WriteLine("10. GetDurationBetweenTwoDays");
            Console.WriteLine("11. Thoat");
            Console.WriteLine("------------------------------------------------------\n");
        }

        public static void GetCurrentDay()
        {
            Console.Clear();
            Console.WriteLine("1. GetCurrentDay");
            Console.WriteLine($"Hôm nay là thứ {DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                            $" tháng {DateTime.Now.Month}, năm {DateTime.Now.Year}");
        }

        public static void ShowDate()
        {
            Console.Clear();
            Console.WriteLine("2. ShowDate");

            Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine($"Hôm nay là thứ {date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                $" tháng {date.Month}, năm {date.Year}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void GetDateAfter()
        {
            Console.Clear();
            Console.WriteLine("3. GetDateAfter");

        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                date = date.AddDays(1);
                Console.WriteLine($"Hôm sau là thứ {date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                    $" tháng {date.Month}, năm {date.Year}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void GetDateBefore()
        {
            Console.Clear();
            Console.WriteLine("4. GetDateBefore");

        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                date = date.AddDays(-1);
                Console.WriteLine($"Hôm trước là thứ {date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")).Replace("Thứ ", "")}," +
                    $" tháng {date.Month}, năm {date.Year}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void CompareDate()
        {
            Console.Clear();
            Console.WriteLine("5. CompareDate");

        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
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
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void FormatDate()
        {
            Console.Clear();
            Console.WriteLine("6. FormatDate");

        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString("dd/MM/yyyy"));
                Console.WriteLine(date.ToString("yyyy//MM/dd"));
                Console.WriteLine(date.ToString("MM/yyyy"));
                Console.WriteLine(date.ToString("MM-yyyy"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void Get10DaysBefore() {
            Console.Clear();
            Console.WriteLine("7. Get10DaysBefore");
        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.AddDays(-10).ToString("ddddd", new System.Globalization.CultureInfo("vi-VN")));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void GetLastDayOfMonth()
        {
            Console.Clear();
            Console.WriteLine("8. GetLastDayOfMonth");
        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int numberDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month);
                Console.WriteLine(date.AddDays(numberDayOfMonth - date.Day).ToString("ddddd", new System.Globalization.CultureInfo("vi-VN")));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void GetLastDayOfYear()
        {
            Console.Clear();
            Console.WriteLine("9. GetLastDayOfYear");
        Input:
            Console.WriteLine("Nhap ngay (dd/MM/yyyy): ");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int daysLeft = new DateTime(date.Year, 12, 31).DayOfYear - date.DayOfYear;
                Console.WriteLine(date.AddDays(daysLeft).ToString("ddddd", new System.Globalization.CultureInfo("vi-VN")));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

        public static void GetDurationBetweenTwoDays()
        {
            Console.Clear();
            Console.WriteLine("10. GetDurationBetweenTwoDays");
        Input:
            Console.WriteLine("Nhap ngay 1: ");
            string dateString1 = Console.ReadLine();
            Console.WriteLine("Nhap ngay 2: ");
            string dateString2 = Console.ReadLine();
            try
            {
                DateTime date1 = DateTime.ParseExact(dateString1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime date2 = DateTime.ParseExact(dateString2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(Math.Abs(date1.Subtract(date2).TotalDays));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay khong hop le!");
                goto Input;
            }
        }

    }
}
