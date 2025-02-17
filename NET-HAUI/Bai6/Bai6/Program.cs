using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai6
{
 
    internal class Program
    {
        static Car[] cars = new Car[3];
        static Truck[] trucks = new Truck[3];
        static void Show()
        {
            Console.WriteLine("1. Nhap du lieu\n" +
                              "2 . Hien thi du lieu\n" +
                              "3. Tim kiem theo id\n" +
                              "4. Tim kiem theo maker\n" +
                              "5. Sap xep theo price\n" +
                              "6. sap xep theo year\n" +
                              "7. Ket thuc");
            Console.WriteLine("===================================");
            Console.Write("Chon chuong trinh: ");

        }
        static void InputMain()
        {
            Console.WriteLine("Nhap vao thong tin 3 doi tuong car: ");
            for(int i = 0; i < 3; i++)
            {
                cars[i] = new Car();
                Console.WriteLine($"thong tin doi tuong car {i+1}: ");
                cars[i].Input();
            }
            Console.WriteLine("Nhap vao thong tin 3 doi tuong truck");
            for (int i = 0; i < 3; i++)
            {
                trucks[i] = new Truck();
                Console.WriteLine($"thong tin doi tuong truck {i + 1}: ");
                trucks[i].Input();
            }
        }
        static void OutputMain()
        {
            foreach(Car car in cars)
            {
                car.Output();
            }
            foreach (Truck truck in trucks)
            {
                truck.Output();
            }
            Console.ReadLine();
        }
        static void SortByPrice()
        {
            foreach (Car car in cars)
            {
                car.Output();
            }
            foreach (Truck truck in trucks)
            {
                truck.Output();
            }
            cars = cars.OrderBy(x => x.price).ToArray();
            foreach (Car car in cars)
            {
                car.Output();
            }
            foreach (Truck truck in trucks)
            {
                truck.Output();
            }
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Show();
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        InputMain();
                        break;
                    case 2:
                        OutputMain();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon nay, vui long chon lai");
                        break;
                }
                Console.Clear();
            } while (true);
        }
    }
}
