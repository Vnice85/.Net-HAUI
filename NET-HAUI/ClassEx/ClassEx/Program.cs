using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace ClassEx
{
    class Program
    {
        static List<int> idcheck = new List<int>();
        static List<Student> danhsach = new List<Student>();
        static void show()
        {
            Console.WriteLine("1. Them mot sinh vien");
            Console.WriteLine("2. Hien thi danh sach sinh vien");
            Console.WriteLine("3. tim kiem danh sach theo id");
            Console.WriteLine("4. xoa theo id");
            Console.WriteLine("5. tim kiem theo add");
            Console.WriteLine("6. exit");
            Console.WriteLine("============================");
            Console.Write("Chon chuong trinh: ");
        }
        static void themsv()
        {
            Student student = new Student();
            do
            {
                student.Input();
                if (idcheck.Contains(student.Id))
                {
                    Console.Clear();
                    Console.WriteLine("Nhap id khong duoc trung, vui long nhap lai: ");
                }
                else
                {
                    idcheck.Add(student.Id); danhsach.Add(student); break;
                }
            } while (true);

        }
        static void hienthi()
        {
            foreach (Student student in danhsach)
            {
                student.Output();
            }
            Console.ReadLine();
        }
        static void timid()
        {
            Console.Write("Nhap vao id muon tim kiem: ");
            int findid = int.Parse(Console.ReadLine());
            foreach (Student student in danhsach)
            {
                if (student.Id == findid)
                {
                    student.Output();
                }
                Console.ReadLine();
            }
        }
        static void xoaid()
        {
            int tmp = 0;
            Console.Write("Nhap vao id muon xoa: ");
            int deldid = int.Parse(Console.ReadLine());
            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].Id == deldid)
                {
                    danhsach.RemoveAt(i);
                    tmp++;
                }
            }
            if (tmp == 0)
            {
                Console.WriteLine("Khong co");
            }
            Console.ReadLine();
        }
        static void timad()
        {
            Console.Write("Nhap vao id muon tim kiem: ");
            string findad = Console.ReadLine();
            foreach (Student student in danhsach)
            {
                if (student.address == findad)
                {
                    student.Output();
                }
            }
        }
        static void Main()
        {
            int n;
            do
            {
                show();
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        themsv();
                        break;
                    case 2:
                        hienthi();
                        break;
                    case 3:
                        timid();
                        break;
                    case 4:
                        xoaid();
                        break;
                    case 5:
                        timad();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon nay, vui long nhap lai");
                        break;

                }
                Console.Clear();
            } while (true);

        }
    }
}