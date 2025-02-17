using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bai._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập vào kích thước mảng: ");
            int n  = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {arr.Max()}");
            Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {arr.Min()}");
            Console.WriteLine($"Tổng các phần tử trong mảng là: {arr.Sum()}");

        }
    }
}
