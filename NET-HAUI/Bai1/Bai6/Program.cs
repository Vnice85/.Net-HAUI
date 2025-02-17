using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            do
            {
                Console.Write("Nhap vao so nguyen: ");
                n = double.Parse(Console.ReadLine());
            }
            while (n % 1 != 0);
        }
    }
}
