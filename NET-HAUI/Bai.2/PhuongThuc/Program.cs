using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mang so nguyen: ");
            string s = Console.ReadLine();
            string[] st = s.Split(' ');
            int[] n = new int[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                n[i] = int.Parse(st[i]);
                Test(n[i]);
            }
        }
        static void Test(int n)
        {
            int tmp = 0;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0 || n == 1)
                {
                    tmp = 1;
                    break;
                }
               
            }
            if(tmp == 0)
            {
                Console.Write(n + " ");
            }
        }
    }
}
