using System;

namespace PrimitiveTypes
{
    static class IntPractice
    {

        public static void PrintMenu()
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("1. CheckOddOrEvenNumber");
            Console.WriteLine("2. Abs");
            Console.WriteLine("3. SquareNumber");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. CheckPrimeNumber");
            Console.WriteLine("6. CheckInt32String");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("------------------------------------------------------\n");
        }
        public static void CheckOddOrEvenNumber() {
            Console.Clear();
            Console.WriteLine("1. CheckOddOrEvenNumber");
            Console.WriteLine("Nhap so:");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
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

        public static void Abs()
        {
            Console.Clear();
            Console.WriteLine("2. Abs");
            Console.WriteLine("Nhap so:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(number));
        }

        public static void SquareNumber()
        {
            Console.Clear();
            Console.WriteLine("3. SquareNumber");
            Console.WriteLine("Nhap so:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0 )
            {
                Console.WriteLine("Số <= 0");
            }
            else
            {
                Console.WriteLine(number * number);
            }
        }

        public static void Divide()
        {
            Console.Clear();
            Console.WriteLine("4. Divide");
            Console.WriteLine("Nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} chia {b} bằng {a / b} dư {a % b}");
        }

        public static void CheckPrimeNumber()
        {
            Console.Clear();
            Console.WriteLine("5. CheckPrimeNumber");
            Console.WriteLine("Nhap so:");
            int number = int.Parse(Console.ReadLine());
            if ( number < 0)
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

        public static void CheckInt32String()
        {
            Console.Clear();
            Console.WriteLine("6. CheckInt32String");
            Console.WriteLine("Nhap so dang chuoi:");
            string stringNumber = Console.ReadLine();
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
