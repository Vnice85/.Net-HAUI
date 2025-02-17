using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao hai so thuc duong: ");
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            Console.WriteLine($@"Chu vi hinh chu nhat la: {a + b},
Dien tich hinh chu nhat la: {a * b}");

        }
    }
}
