using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th6
{
    internal class Student
    {
        public int studentid {  get; set; }
        public string name { get; set; }    
        public string mark {  get; set; }
        public void InputStudent()
        {
            Console.Write("Nhap studentid: ");
            studentid = int.Parse(Console.ReadLine());
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap mark: ");
            mark = Console.ReadLine();
        }
        public override string ToString()
        {
            return "student id " + studentid + ", name: " + name + ", mark: " + mark;
        }
    }
}
