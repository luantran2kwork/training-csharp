using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionPractice
{
    static class DictionaryPractice
    {
        public static Dictionary<int, string> createStudentList()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            Dictionary<int, string> studentList = new Dictionary<int, string>();
            for (int i = 1; i <= 5; i++)
            {
                studentList.Add(i, $"Nguyen Van {chars[random.Next(0, chars.Length)]}");
            }

            foreach (KeyValuePair<int, string> student in studentList)
            {
                Console.WriteLine($"Id: {student.Key}. Họ tên: {student.Value}");
            }

            return studentList;
        }

        public static void FindStudentById(Dictionary<int, string> studentList, int id)
        {
            string studentName;
            if (studentList.TryGetValue(id, out studentName))
            {
                Console.WriteLine(studentName);
            }
            else
            {
                Console.WriteLine("Không có sinh viên có mã " + id);
            }
        }

        public static void AddStudent(Dictionary<int, string> studentList, int id, string studentName)
        {
            string studentNameExist;
            if (studentList.TryGetValue(id, out studentNameExist))
            {
                Console.WriteLine($"Đã có SV có mã {id} trong Dictonary");
            }
            else
            {
                studentList.Add(id, studentName);
                Console.WriteLine($"Đã thêm SV có mã {id}, tên {studentName} vào Dictionary");
            }
        }

        public static void AddOrModifyStudent(Dictionary<int, string> studentList, int id, string studentName)
        {
            string studentNameExist;
            if (studentList.TryGetValue(id, out studentNameExist))
            {
                string oldName = studentList[id];
                studentList[id] = studentName;
                Console.WriteLine($"Đã thay tên SV có mã {id} trong Dictonary từ {oldName} thành {studentName}");
            }
            else
            {
                studentList.Add(id, studentName);
                Console.WriteLine($"Đã thêm SV có mã {id}, tên {studentName} vào Dictionary");
            }
        }

        public static void RemoveStudent(Dictionary<int, string> studentList, int id)
        {
            string studentNameExist;
            if (studentList.TryGetValue(id, out studentNameExist))
            {
                studentList.Remove(id);
                Console.WriteLine($"Đã xoá SV có mã {id} trong Dictonary");
            }
            else
            {
                Console.WriteLine("Không có sinh viên có mã " + id);
            }
        }
    }
}
