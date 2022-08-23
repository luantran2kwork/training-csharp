using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Employee
    {
        protected string Name;
        protected int Age;
        protected DateTime CreateTime;

        public Employee()
        {

        }

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.CreateTime = DateTime.Now;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ten toi la {this.Name}, {Age} tuoi.");
        }

        public virtual void ExtInfo()
        {
            Console.WriteLine($"Ten toi la {this.Name}, duoc tao ra luc {this.CreateTime.ToString("HH:mm:ss")}");
        }
    }

}
