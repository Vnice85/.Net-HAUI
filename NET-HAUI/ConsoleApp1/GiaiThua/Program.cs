using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao mot so nguyen duong de tinh giai thua cua no: ");
            int n = int.Parse(Console.ReadLine());
            int giaithua = 1;
            for (int i = 1; i <= n; i++) 
            {
                giaithua *= i;
            }
            Console.WriteLine($"giai thua cua {n} la {giaithua}");
        }
    }
}
