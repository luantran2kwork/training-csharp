using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    static class ListPractice
    {
        public static List<int> Create10RandomNumber()
        {
            Random random = new Random();
            List<int> numberList = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                numberList.Add(random.Next(0, 100));
            }
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            return numberList;
        }

        public static void ShowNumberListSorted(List<int> numberList)
        {
            //Copy new List
            numberList = numberList.GetRange(0, numberList.Count);
            numberList.Sort();

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void ShowReverseList(List<int> numberList)
        {
            //Copy new List
            numberList = numberList.GetRange(0, numberList.Count);
            numberList.Reverse();

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void ShowListSmallerThanN(List<int> numberList,int n)
        {
            //Copy new List
            numberList = numberList.GetRange(0, numberList.Count);
            var newNumberList = numberList.Where((number) => number < n);

            foreach (int number in newNumberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void ShowListInDivisbleN(List<int> numberList, int n)
        {
            //Copy new List
            numberList = numberList.GetRange(0, numberList.Count);
            var newNumberList = numberList.Where((number) => number % n != 0);

            foreach (int number in newNumberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void PlusX(List<int> numberList, int x)
        {
            //Copy new List
            numberList = numberList.GetRange(0, numberList.Count);
            var newNumberList = numberList.Select(number =>
            {
                if (number < x)
                {
                    return number += x;
                }
                return number;
            });

            foreach (int number in newNumberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void ShowLastNOfList(List<int> numberList, int n)
        {
            //Copy new List
            numberList = numberList.GetRange(0, numberList.Count);
            int getStartIndex = numberList.Count() - n - 1;
            var newNumberList = numberList.Where((number, index) => index > getStartIndex);

            foreach (int number in newNumberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void ShowLastNOfListReverse(List<int> numberList, int n)
        {
            //Copy new List
            int getStartIndex = numberList.Count() - n - 1;
            numberList = numberList.GetRange(0, numberList.Count);
            var newNumberList = numberList.Where((number, index) => index > getStartIndex);
            newNumberList = newNumberList.Reverse();

            foreach (int number in newNumberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void Fibonacii(int n)
        {

            // Declare an array to
            // store Fibonacci numbers.
            // 1 extra to handle
            // case, n = 0
            List<int> numberList = new List<int>();
            int i;

            /* 0th and 1st number of the
               series are 0 and 1 */
            numberList.Add(0);
            numberList.Add(1);

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers
                   in the series and store it */
                numberList.Add(numberList[i - 1] + numberList[i - 2]);
            }
            int getStartIndex = numberList.Count() - 10 - 1;
            var newNumberList = numberList.Where((number, index) => index > getStartIndex);

            foreach (int number in newNumberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }
        

    }
}
