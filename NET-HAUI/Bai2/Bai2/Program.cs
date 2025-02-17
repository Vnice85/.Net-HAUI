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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào giá trị: ");
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = UCLN(n, m);
            Console.WriteLine($"Phân số rút gọn của m/n: {m/c}/{n/c}");

        }
        static int UCLN(int n, int m)
        {
            if (m == 0)
            {
                return n;
            }
            else
                return UCLN(m, n % m);
        }
    }
}

