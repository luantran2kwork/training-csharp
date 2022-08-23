using System;

namespace PrimitiveTypes
{
    static class BoolPractice
    {
        public static void CheckBoolString()
        {
            Console.Clear();
            Console.WriteLine("CheckBoolString");
            Console.WriteLine("Nhap chuoi(\"0\" de thoat): ");
            string stringbool = Console.ReadLine();
            if (stringbool == "true" || stringbool == "false")
            {
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Chuỗi không hợp lệ");
            }

        }
    }
}
