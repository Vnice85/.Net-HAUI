using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th6
{
    internal class Course
    {
        public string Courseid { get; set; }
        public string Coursename { get; set; }
        public int fee { get; set; }
        public List<Student> li { get; set; }
        public Course()
        {
            li = new List<Student>();
        }
        public void InputCourse()
        {
            Console.Write("Nhap course id: ");
            Courseid = Console.ReadLine();
            Console.Write("Nhap course name: ");
            Coursename = Console.ReadLine();
            Console.Write("Nhap fee: ");
            fee = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                student.InputStudent();
                li.Add(student);
                
            }
        }
        public void DisplayCourseAndStudent()
        {
            Console.Write($"course id: {Courseid} ");
            Console.Write($"course name: {Coursename} ");
            Console.WriteLine($"fee: {fee} ");
            Console.Write("student id".PadRight(20));
            Console.WriteLine("student nanme".PadRight(20));
            
            foreach (Student student in li)
            {
                Console.Write(student.studentid.ToString().PadRight(20));
                Console.Write(student.name.PadRight(20));
                Console.WriteLine(student.mark.PadRight(20));
                
            }
        }
    }
}
