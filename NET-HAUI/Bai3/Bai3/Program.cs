using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        struct SinhVien
        {
            public int id;
            public string name;
            public bool sex;
            public byte age;
            public float Maths;
            public float Physics;
            public float Chemistry;
        }
        static void InputSV(out SinhVien SV)
        {
            SV.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sinh vien: ");
            SV.name = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            SV.sex = bool.Parse(Console.ReadLine());
            Console.Write("Nhap tuoi: ");
            SV.age = byte.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            SV.Maths = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            SV.Physics = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            SV.Chemistry = float.Parse(Console.ReadLine());

        }
        static void OutputSV(SinhVien SV)
        {
            Console.WriteLine($"ID: {SV.id}");
            Console.WriteLine($"Ten sinh vien: {SV.name}");
            Console.WriteLine($"Gioi tinh: {SV.sex}");
            Console.WriteLine($"tuoi: {SV.age}");
            Console.WriteLine($"Diem toan: {SV.Maths}");
            Console.WriteLine($"Diem ly: {SV.Physics}");
            Console.WriteLine($"Diem hoa: {SV.Chemistry}");
            Console.WriteLine($"");

        }

        static void Main(string[] args)
        {
            SinhVien SV = new SinhVien();
            InputSV(out SV);
            OutputSV(SV);
        }
    }
}
