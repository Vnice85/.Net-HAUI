using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TapTIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] st = File.ReadAllLines("matrix.txt");
            string[] array = st[2].Split(new char[] { ' ' });
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += int.Parse(array[i]);
                if (i == 3)
                    Console.WriteLine();
                Console.Write(array[i] + " ");
            }
            Console.WriteLine($"\ntong: {sum}");


        }
    }
}
