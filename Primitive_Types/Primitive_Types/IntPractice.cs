using System;

namespace PrimitiveTypes
{
    static class IntPractice
    {
        public static void CheckOddOrEvenNumber(int number) {
            if(number <= 0)
            {
                Console.WriteLine("Số <= 0");
            }
            else if(number % 2 == 0)
            {
                Console.WriteLine("Số chẵn");
            }
            else
            {
                Console.WriteLine("Số lẻ");
            }
        }

        public static void Abs(int number)
        {
            Console.WriteLine(Math.Abs(number));
        }

        public static void SquareNumber(int number)
        {
            if(number < 0 )
            {
                Console.WriteLine("Số <= 0");
            }
            else
            {
                Console.WriteLine(number * number);
            }
        }

        public static void Divide(int a, int b)
        {
            Console.WriteLine($"{a} chia {b} bằng {a / b} dư {a % b}");
        }

        public static void CheckPrimeNumber(int number)
        {
            if( number < 0)
            {
                Console.WriteLine("Không");
                return;
            }

            for(int i = 2; i < number; i++)
            {
                if(number % i == 0 )
                {
                    Console.WriteLine("Không");
                    return;
                }
            }
            Console.WriteLine("Số nguyên tố");
        }

        public static void CheckInt32String(string stringNumber)
        {
            int number;
            if (int.TryParse(stringNumber, out number))
            {
                Console.WriteLine("Chuỗi số");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi số");
            }
        }

        
    }
}
