using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> danhsach = new List<int>();
            Console.Write("So luong so nguyen muon nhap: ");
            int n = int.Parse(Console.ReadLine());
            int songuyen;
            for (int i = 0; i < n; i++)
            {
                if (int.TryParse(Console.ReadLine(), out songuyen))
                    danhsach.Add(songuyen);
                else
                    Console.WriteLine("Day khong phai la so nguyen");
            }
            Console.WriteLine();
            for (int i = 0; i < danhsach.Count; i++)
                if (danhsach[i] % 2 == 0)
                    Console.Write($"{danhsach[i]} ");
            Console.WriteLine();
            for (int i = 0; i < danhsach.Count; i++)
                if (danhsach[i] % 2 != 0)
                    Console.Write($"{danhsach[i]} ");
            Console.WriteLine();
            int tmp = 0;
            for (int i = 0; i < danhsach.Count; i++)
            {
                for (int j = 2; j <= Math.Sqrt(danhsach[i]); j++)
                {
                    if (danhsach[i] % j == 0 || danhsach[i] == 1)
                    {
                        tmp = 1;
                        break;
                    }
                    else
                        tmp = 0;

                }
                if (tmp == 0)
                {
                    Console.Write($"{danhsach[i]} ");
                }
            }
        }

    }
}

