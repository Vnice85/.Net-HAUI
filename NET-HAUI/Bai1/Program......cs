using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao he so de giai phuong trinh ax + b = 0");
            Console.Write("a = ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            Double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0 && b == 0)
                Console.WriteLine("Phuong trinh co vo so nghiem");
            else if (a == 0 && b != 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else
                Console.WriteLine("Nghiem cua phuong trinh la: {0}", -b / a);

            

        }
    }
}
