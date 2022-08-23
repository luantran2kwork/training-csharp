using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Student : Employee
    {
        private string _specialization;
        
        public Student(string name, int age, string specialization) : base(name, age)
        {
            this._specialization = specialization;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Ten toi la {this.Name}, {Age} tuoi. Toi la Sinh Vien");
        }

        public override void ExtInfo()
        {
            Console.WriteLine($"Toi la Sinh vien ten {this.Name}, hoc chuyen nganh {this._specialization}" +
                $", duoc tao ra luc {this.CreateTime.ToString("HH:mm:ss")}");
        }
    }
}
