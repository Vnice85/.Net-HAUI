using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student student1 = new Student("123");
            Student student2 = new Student("124", "van", 10);
            Console.WriteLine($"hoc bong la: {student2.Scholarship}");

        }
    }
}
