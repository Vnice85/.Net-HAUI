using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double NCTL;
            Console.Write("Nhập vào bậc lương: ");
            int BacLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào ngày công: ");
            int NgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào phụ cấp: ");
            int PhuCap = int.Parse(Console.ReadLine());
            if (NgayCong < 25)
                 NCTL = NgayCong;
            else
                 NCTL = 25 + (NgayCong - 25) * 2;
            double TienLinh = BacLuong * 1490000 * NCTL + PhuCap;
            Console.WriteLine($"Tiền thực lĩnhl: {TienLinh} ");
        }
    }
}
