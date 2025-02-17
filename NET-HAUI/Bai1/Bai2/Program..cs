using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 2 so thuc duong chi chieu dai va chieu rong cua hinh chu nhat: ");
            double n = Convert.ToDouble(Console.ReadLine()), m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Chu vi hinh chu nhat la : {n + m}, dien tich hinh chu nhat la : {n * m}");

        }
    }
}
