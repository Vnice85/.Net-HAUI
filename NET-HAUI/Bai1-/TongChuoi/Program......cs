using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S1 = 0, S2 = 0;
            Console.Write("Nhap vao so nguyen duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                S1 += i;
                S2 += 1 / i;
            }
            Console.WriteLine($"S1 = {S1}");
            Console.WriteLine($"S2 = {S2}");
        }
    }
}
