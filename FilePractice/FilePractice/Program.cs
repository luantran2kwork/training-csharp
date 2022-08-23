using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilePractice
{
    class Program
    {
        public static void SortLine(string line)
        {
            List<string> errorFormatList = new List<string>();
            List<string> errorOverflowList = new List<string>();
            List<int> numberList = new List<int>();
            var list = line.Split(" ").Where(item => item != "").ToList();
            foreach (string numberString in list)
            {
                try
                {
                    int number = int.Parse(numberString);
                    numberList.Add(number);
                }
                catch (OverflowException)
                {
                    errorOverflowList.Add(numberString);
                }
                catch (FormatException)
                {
                    errorFormatList.Add(numberString);
                }
            }
            numberList.Sort();
            string result = $"{string.Join("    ", numberList)}";
            if(errorFormatList.Count >= 1)
            {
                result += $"; {string.Join(", ", errorFormatList)} khong phai kieu Int32";
            }
            if (errorOverflowList.Count >= 1)
            {
                result += $"; {string.Join(", ", errorOverflowList)}  bi vuot gioi han kieu Int32";
            }
            result += "\n";
            Console.WriteLine(result);
            File.AppendAllText("D:/Workspace/FilePractice/FilePractice/FileOut.txt", result);
        }

        static void Main(string[] args)
        {
            //string line = "123     321 42   42      aaa bb       232 733333333333333333";
            //SortLine(line);
            string[] lines = System.IO.File.ReadAllLines("D:/Workspace/FilePractice/FilePractice/FileIn.txt");
            foreach(string line in lines)
            {
                SortLine(line);
            }
        }
    }
}
