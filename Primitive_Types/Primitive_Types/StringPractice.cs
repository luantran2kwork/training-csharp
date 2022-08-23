using System;

namespace PrimitiveTypes
{
    static class StringPractice
    {
        public static void CheckEmptyOrSpaceString(string inputString)
        {
            if(inputString == null)
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

        public static void CheckEmptyOrSpaceStringAndTrim(string inputString)
        {
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
        public static void CheckEmptyOrSpaceStringAndRemoveWhiteSpace(string inputString)
        {
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

        public static void CapitalizeString(string inputString)
        {
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

        public static void CountWhiteSpace(string inputString)
        {
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

        public static void CountNotWhiteSpace(string inputString)
        {
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

        public static void CompareString(string string1 , string string2)
        {
            if (string1 == string2) {
                Console.WriteLine($"Chuoi {string1} giong chuoi {string2}");
            }
            else
            {
                Console.WriteLine($"Chuoi {string1} khac chuoi {string2}");
            }
        }

        public static void CompareInSensitiveString(string string1, string string2)
        {
            if (string1.ToLower() == string2.ToLower())
            {
                Console.WriteLine($"Chuoi {string1} giong chuoi {string2}");
            }
            else
            {
                Console.WriteLine($"Chuoi {string1} khac chuoi {string2}");
            }
        }

        public static void ReplaceABCtoDEF(string inputString)
        {
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

        public static void Welcome(string name)
        {
            Console.WriteLine($"Kính chào ông {name}. Chúc ngon miệng");
        }

        public static void ReverseString(string inputString)
        {
            string newString = "";
            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                newString += inputString[i];
            }
            Console.WriteLine(newString);
        }

        public static void GetNCharStartOfStringTrimStart(string inputString, int n)
        {
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

        public static void GetNCharStartOfString(string inputString, int n)
        {
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

        public static void GetNCharEndOfString(string inputString, int n)
        {
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
