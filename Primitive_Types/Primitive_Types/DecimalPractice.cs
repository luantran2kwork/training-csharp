using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class DecimalPractice
    {
        public static void CheckDecimalString(string decimalString)
        {

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
        public static void DecimalToString(decimal number)
        {
            Console.WriteLine(number.ToString( "#,#.##"));
        }

    }
}
