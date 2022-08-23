using System;

namespace PrimitiveTypes
{
    static class BoolPractice
    {
        public static void CheckBoolString(string stringbool)
        {
            if(stringbool == "true" || stringbool == "false")
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
