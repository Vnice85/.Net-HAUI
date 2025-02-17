using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên từ 1 đén 7: ");
            byte day = Convert.ToByte(Console.ReadLine());
            switch (day) 
            {
                case 1:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 2:
                    Console.WriteLine("Thứ hai");
                    break;
                case 3:
                    Console.WriteLine("Thứ ba");
                    break;
                case 4:                    
                    Console.WriteLine("Thứ tư ");
                    break;
                case 5:                    
                    Console.WriteLine("Thứ năm");
                    break;
                case 6:                    
                    Console.WriteLine("Thứ sáu");
                    break;
                default:                    
                    Console.WriteLine("Thứ bảy");
                    break;

            }
        }
    }
}
