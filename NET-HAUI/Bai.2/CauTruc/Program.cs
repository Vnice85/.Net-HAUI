using System;

namespace CauTruc
{
    internal class Program
    {
        struct HocSinh
        {
            public string Name;
            public int Age;
            public bool Sex;
        }
        static void Input(out HocSinh HS)
        {
            Console.Write("Nhap vao ten hoc sinh: ");
            HS.Name = Console.ReadLine(); ;
            Console.Write("Nhap vao tuoi: ");
             HS.Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao gioi tinh: ");
            HS.Sex = bool.Parse(Console.ReadLine());
        }
        static void Output(HocSinh HS)
        {
            Console.WriteLine($"Ten: {HS.Name}");
            Console.WriteLine($"Tuoi: {HS.Age}");
            if (HS.Sex) Console.WriteLine("Gioi tinh: Nam");
            else Console.WriteLine("Gioi tinh: Nu");
        }
        static void Main()
        {
            Console.WriteLine("Nhap vao thong tin 5 hoc sinh: ");
            HocSinh[] arr = new HocSinh[5];
            for (int i = 0; i < 5; i++)
            {
                Input(out arr[i]);
            }
            Console.WriteLine("Thong tin cac hoc sinh");
            foreach(HocSinh H in arr)
            {
                Output(H);
            }
        }
    }
}