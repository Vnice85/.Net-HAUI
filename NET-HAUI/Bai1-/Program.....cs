using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 3 canh cua tam giac");
            Console.Write(" a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write(" b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write(" c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"Chu vi tam giac la: {a + b + c}");
                double P = (a + b + c) / 2;
                double s = P * (P - a) * (P - b) * (P - c);
                Console.WriteLine($"Dien tich tam giac la: {Math.Sqrt(s)}");
            }
            else
                Console.WriteLine("Day khong phai tam giac");
        }
    }
}
