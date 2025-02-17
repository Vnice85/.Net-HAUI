using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBacHai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao epsilon: ");
            double ep = double.Parse(Console.ReadLine());
            double x = 1;
            for (int i = 0; i <= ep; i++)
            {
                x = (a / x + x) / 2;
            }
            Console.WriteLine($"can bac hai cua a la: {x}");
        }
    }
}
