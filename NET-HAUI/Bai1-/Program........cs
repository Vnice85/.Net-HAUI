using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập vào họ tên: ");
            string hoten = Console.ReadLine();
            Console.Write("Nhập vào điểm: ");
            float diem = float.Parse(Console.ReadLine());
            string HOTEN = hoten.ToUpper();
            Console.WriteLine($"Tên học sinh: {HOTEN}");
            Console.Write("Xếp loại học lực: ");
            if (diem >= 8)
            {
                Console.WriteLine("Giỏi");
            }
            else if (diem >= 6.5 && diem < 8)
            {
                Console.WriteLine("Khá");
            }
            else if (diem >= 5 && diem < 6.5)
            {
                Console.WriteLine("Trung bình");
            }
            else
                Console.WriteLine("Yếu");

        }
    }
}
