using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numberList = ListPractice.Create10RandomNumber();
            ListPractice.ShowNumberList(numberList);
            ListPractice.ShowNumberListSorted(numberList);
            ListPractice.ShowReverseList(numberList);
            ListPractice.ShowListSmallerThanN(numberList, 50);
            ListPractice.ShowListInDivisbleN(numberList, 2);
            ListPractice.PlusX(numberList, 40);
            ListPractice.ShowLastNOfList(numberList, 4);
            ListPractice.ShowLastNOfListReverse(numberList, 4);
        }
    }
}
