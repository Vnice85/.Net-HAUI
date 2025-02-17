using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int f1 = 0, f2 = 1;
            int fb = 0;
           if (n == 1)
            {
                Console.WriteLine($"{f1}");
            }
           else
            {
                Console.Write($"{f1} {f2} ");
                for (int i = 0; i < n - 2; i++)
                {
                    fb = f1 + f2;
                    Console.Write($"{fb} ");
                    f1 = f2;
                    f2 = fb;
                }
            }
        }
    }
   
}
