using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class DecimalPractice
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("1. CheckDecimalString");
            Console.WriteLine("2. DecimalToString");
            Console.WriteLine("3. Thoat");
            Console.WriteLine("------------------------------------------------------\n");
        }

        public static void CheckDecimalString()
        {
            Console.Clear();
            Console.WriteLine("1. CheckDecimalString");
            Console.WriteLine("Nhap so decimal:");
            string decimalString = Console.ReadLine();
            decimal number;
            if (decimal.TryParse(decimalString, out number))
            {
                // Check comma speparate interger part
                string integerPart = decimalString.Trim().Split('.')[0];
                string[] integerPartArray = integerPart.Split(',');
                if(integerPartArray[0].Length > 3)
                {
                    Console.WriteLine("Không phải chuỗi decimal");
                    return;
                }
                for(int i = 1; i < integerPartArray.Length; i++)
                {
                    if(integerPartArray[i].Length != 3)
                    {
                        Console.WriteLine("Không phải chuỗi decimal");
                        return;
                    }
                }
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi decimal");
            }
        }


        //Reference: https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
        public static void DecimalToString()
        {
            Console.Clear();
            Console.WriteLine("2. DecimalToString");
            Console.WriteLine("Nhap so decimal:");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString( "#,#.###"));
        }

    }
}
