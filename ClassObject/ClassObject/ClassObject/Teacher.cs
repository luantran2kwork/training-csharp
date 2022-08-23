using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Teacher : Employee
    {
        private string _subject;
        
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this._subject = subject;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Toi la Giao vien, {Age} tuoi, toi ten la {Name}");
        }

        public override void ExtInfo()
        {
            Console.WriteLine($"Tôi là Giáo Viên tên {Name}, thuộc bộ môn {_subject}, được tạo ra lúc {this.CreateTime.ToString("HH:mm:ss")}");
        }
    }
}
