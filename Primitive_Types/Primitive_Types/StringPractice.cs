using System;

namespace PrimitiveTypes
{
    static class StringPractice
    {

        public static void PrintMenu()
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("1. CheckEmptyOrSpaceString");
            Console.WriteLine("2. CheckEmptyOrSpaceStringAndTrim");
            Console.WriteLine("3. CheckEmptyOrSpaceStringAndRemoveWhiteSpace");
            Console.WriteLine("4. CapitalizeString");
            Console.WriteLine("5. CountWhiteSpace");
            Console.WriteLine("6. CountNotWhiteSpace");
            Console.WriteLine("7. CompareString");
            Console.WriteLine("8. CompareInSensitiveString");
            Console.WriteLine("9. ReplaceABCtoDEF");
            Console.WriteLine("10. Welcome");
            Console.WriteLine("11. ReverseString");
            Console.WriteLine("12. etNCharStartOfStringTrimStart");
            Console.WriteLine("13. GetNCharStartOfString");
            Console.WriteLine("14. GetNCharEndOfString");
            Console.WriteLine("15. Exit");
            Console.WriteLine("------------------------------------------------------\n");
        }

        public static void CheckEmptyOrSpaceString()
        {
            Console.Clear();
            Console.WriteLine("1. CheckEmptyOrSpaceString");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if(inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            foreach(char c in inputString)
            {
                if (!char.IsWhiteSpace(c))
                {
                    Console.WriteLine(inputString);
                    return;
                }
            }
            Console.WriteLine("Chuỗi Space");
        }

        public static void CheckEmptyOrSpaceStringAndTrim()
        {
            Console.Clear();
            Console.WriteLine("2. CheckEmptyOrSpaceStringAndTrim");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            foreach (char c in inputString)
            {
                if (!char.IsWhiteSpace(c))
                {
                    Console.WriteLine(inputString.Trim());
                    return;
                }
            }
            Console.WriteLine("Chuỗi Space");
        }
        public static void CheckEmptyOrSpaceStringAndRemoveWhiteSpace()
        {
            Console.Clear();
            Console.WriteLine("3. CheckEmptyOrSpaceStringAndRemoveWhiteSpace");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            string newString = "";

            foreach (char c in inputString)
            {
                if (!char.IsWhiteSpace(c))
                {
                    newString += c;
                }
            }

            if(newString != "")
            {
                Console.WriteLine(newString);
                return;
            }
            Console.WriteLine("Chuỗi Space");
        }

        public static void CapitalizeString()
        {
            Console.Clear();
            Console.WriteLine("4. CapitalizeString");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            bool isAllWhiteSpace = true;
            string newString = "";

            for(int i = 0; i < inputString.Length;)
            {
                if(i < inputString.Length - 1 && char.IsWhiteSpace(inputString[i]) && !char.IsWhiteSpace(inputString[i + 1]))
                {
                    newString += " " + char.ToUpper(inputString[i + 1]);
                    isAllWhiteSpace = false;
                    i += 2;
                }
                else
                {
                    newString += inputString[i];
                    i++;
                }
            }

            if(isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine(newString);
            }
        }

        public static void CountWhiteSpace()
        {
            Console.Clear();
            Console.WriteLine("5. CountWhiteSpace");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            bool isAllWhiteSpace = true;
            int whiteSpaceCount = 0;

            foreach (char c in inputString)
            {
                if(char.IsWhiteSpace(c))
                {
                    whiteSpaceCount++;
                }
                else
                {
                    isAllWhiteSpace = false;
                }
            }

            if (isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine($" Có {whiteSpaceCount} ký tự space");
            }
        }

        public static void CountNotWhiteSpace()
        {
            Console.Clear();
            Console.WriteLine("6. CountNotWhiteSpace");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            bool isAllWhiteSpace = true;
            int whiteSpaceCount = 0;

            foreach (char c in inputString)
            {
                if (char.IsWhiteSpace(c))
                {
                    whiteSpaceCount++;
                }
                else
                {
                    isAllWhiteSpace = false;
                }
            }

            if (isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine($" Có {inputString.Length - whiteSpaceCount} ký tự  không phải space");
            }
        }

        public static void CompareString()
        {
            Console.Clear();
            Console.WriteLine("7. CompareString");
            Console.WriteLine("Nhap chuoi 1:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Nhap chuoi 2s:");
            string string2 = Console.ReadLine();
            if (string1 == string2) {
                Console.WriteLine($"Chuoi {string1} giong chuoi {string2}");
            }
            else
            {
                Console.WriteLine($"Chuoi {string1} khac chuoi {string2}");
            }
        }

        public static void CompareInSensitiveString()
        {
            Console.Clear();
            Console.WriteLine("8. CompareInSensitiveString");
            Console.WriteLine("Nhap chuoi 1:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Nhap chuoi 2s:");
            string string2 = Console.ReadLine();
            if (string1.ToLower() == string2.ToLower())
            {
                Console.WriteLine($"Chuoi {string1} giong chuoi {string2}");
            }
            else
            {
                Console.WriteLine($"Chuoi {string1} khac chuoi {string2}");
            }
        }

        public static void ReplaceABCtoDEF()
        {
            Console.Clear();
            Console.WriteLine("9. ReplaceABCtoDEF");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }

            bool isAllWhiteSpace = true;
            int whiteSpaceCount = 0;

            foreach (char c in inputString)
            {
                if (char.IsWhiteSpace(c))
                {
                    whiteSpaceCount++;
                }
                else
                {
                    isAllWhiteSpace = false;
                }
            }

            if (isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine(inputString.Replace("ABC", "DEF"));
            }
        }

        public static void Welcome()
        {
            Console.Clear();
            Console.WriteLine("10. Welcome");
            Console.WriteLine("Nhap chuoi:");
            string name = Console.ReadLine();
            Console.WriteLine($"Kính chào ông {name}. Chúc ngon miệng");
        }

        public static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("11. ReverseString");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            string newString = "";
            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                newString += inputString[i];
            }
            Console.WriteLine(newString);
        }

        public static void GetNCharStartOfStringTrimStart()
        {
            Console.Clear();
            Console.WriteLine("12. etNCharStartOfStringTrimStart");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }
            else if (n < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
                return;
            }
            else if (n > inputString.TrimStart().Length)
            {
                Console.WriteLine("Số lớn hơn độ dài chuỗi.s");
                return;
            }

            bool isAllWhiteSpace = true;
            string newString = inputString.TrimStart().Substring(0, n);

            foreach (char c in inputString)
            {
                if (!char.IsWhiteSpace(c)) {           
                    isAllWhiteSpace = false;
                }
            }

            if (isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine(newString);
            }
        }

        public static void GetNCharStartOfString()
        {
            Console.Clear();
            Console.WriteLine("13. GetNCharStartOfString");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }
            else if (n < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
                return;
            }
            else if (n > inputString.Trim().Length)
            {
                Console.WriteLine("Số lớn hơn độ dài chuỗi.s");
                return;
            }

            bool isAllWhiteSpace = true;
            string newString = inputString.Trim().Substring(0, n);

            foreach (char c in inputString)
            {
                if (!char.IsWhiteSpace(c))
                {
                    isAllWhiteSpace = false;
                }
            }

            if (isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine(newString);
            }
        }

        public static void GetNCharEndOfString()
        {
            Console.Clear();
            Console.WriteLine("14. GetNCharEndOfString");
            Console.WriteLine("Nhap chuoi:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return;
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
                return;
            }
            else if (n < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
                return;
            }
            else if (n > inputString.Trim().Length)
            {
                Console.WriteLine("Số lớn hơn độ dài chuỗi.s");
                return;
            }

            bool isAllWhiteSpace = true;
            string newString = inputString.Trim();
            newString = newString.Substring(newString.Length - 1 - n);

            foreach (char c in inputString)
            {
                if (!char.IsWhiteSpace(c))
                {
                    isAllWhiteSpace = false;
                }
            }

            if (isAllWhiteSpace)
            {
                Console.WriteLine("Chuỗi Space");
            }
            else
            {
                Console.WriteLine(newString);
            }
        }

    }
}
