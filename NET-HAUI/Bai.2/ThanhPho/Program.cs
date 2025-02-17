using System;
using System.Collections.Generic;
using System.Text;

namespace ThanhPho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            List<string> ThanhPho = new List<string>();
            ThanhPho.Add("Hà Nội");
            ThanhPho.Add("Nam Định");
            ThanhPho.Add("Hà Nam");
            ThanhPho.Add("Thái Bình");
            ThanhPho.Add("Phú Thọ");
            ThanhPho.Sort();
            foreach (string Ls in ThanhPho)
            {
                Console.WriteLine(Ls);
            }
            ThanhPho.RemoveAll(Ls => Ls == "Hà Nội");
            ThanhPho.Add("Thái Nguyên");
            ThanhPho.Add("Hải Phòng");
            ThanhPho.Add("Hà Giang");
            ThanhPho.Add("Hồ Chí Minh");
            ThanhPho.Add("Hà Tĩnh");
            foreach (string Ls in ThanhPho)
            {
                Console.WriteLine(Ls);
            }
        }
    }
}