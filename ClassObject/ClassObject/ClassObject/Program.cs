using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Nguyen Van A", 20);
            employee.ShowInfo();
            employee.ExtInfo();

            Student student = new Student("Nguyen Van B", 19, "Thiet ke do hoa");
            student.ShowInfo();
            student.ExtInfo();

            Teacher teacher = new Teacher("Nguyen Van C", 46, "Dai so");
            teacher.ShowInfo();
            teacher.ExtInfo();
        }
    }
}
