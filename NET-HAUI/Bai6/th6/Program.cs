using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.InputCourse();
            course.DisplayCourseAndStudent();
        }
    }
}
