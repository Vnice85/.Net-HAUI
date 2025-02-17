using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Console.Write("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 1)
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        t = 1;
                        break;
                    }
                }
                if (t == 0)
                {
                    Console.WriteLine($" {n} la so nguyen to");
                }
                else
                    Console.WriteLine($"{n} khong la so nguyen to");

            }
            else
                Console.WriteLine("Day khong la so nguyen to");
        }
    }
}
