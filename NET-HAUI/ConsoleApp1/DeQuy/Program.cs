
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao mot so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    Console.Write($"{Fibonacci(i)} ");
        }
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        /*
        static void Main(string[] args)
        {
            Console.Write("nhap vao mot so nguyen duong de tinh giai thua cua no: ");
            int n = int.Parse(Console.ReadLine());
            int result = GiaiThua(n);
            Console.WriteLine($"giai thua cua {n} la {result}");

        }
        static int GiaiThua(int n)
        {
            if (n == 0 || n == 1)
            {

                return 1;
            }
            else
                return n * GiaiThua(n - 1);
        } */
    }
}
