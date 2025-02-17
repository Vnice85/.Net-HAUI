using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Classex2
{
    internal class Student
    {
        private int _scholarship;

        public string id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }

        public int Scholarship
        {
            get { return _scholarship; }
            set
            {
                if (mark > 8)
                {
                    _scholarship = 500;
                }
                else if (mark >= 7 && mark <= 8)
                {
                    _scholarship = 300;
                }
                else
                {
                    _scholarship = 0;
                }
            }
        }

        public Student()
        {
            id = string.Empty;
            name = string.Empty;
            mark = 10;
            Scholarship = 0;
            
        }

        public Student(string id)
        {
            this.id = id;
   
        }

        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            this.Scholarship = 0;
        }
    }
}

