using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Random random = new Random();
                        List<int> numberList = ListPractice.Create10RandomNumber();
                        ListPractice.ShowNumberListSorted(numberList);
                        ListPractice.ShowReverseList(numberList);
                        ListPractice.ShowListSmallerThanN(numberList, 50);
                        ListPractice.ShowListInDivisbleN(numberList, 2);
                        ListPractice.PlusX(numberList, 40);
                        ListPractice.ShowLastNOfList(numberList, 4);
                        ListPractice.ShowLastNOfListReverse(numberList, 4);
                        ListPractice.Fibonacii(20);*/

            Dictionary<int, string> studentList = DictionaryPractice.createStudentList();
            DictionaryPractice.FindStudentById(studentList, 6);
            DictionaryPractice.AddStudent(studentList, 6, "Nguyen Van G");
            DictionaryPractice.AddOrModifyStudent(studentList, 6, "Nguyen van H");
            DictionaryPractice.RemoveStudent(studentList, 6);
        }
    }
}
