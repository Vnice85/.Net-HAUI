using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class TimUCLN
    {
        public int sothu1 {  get; set; }    
        public int sothu2 { get; set; }
        public int UCLN(int sothu1, int sothu2)
        {
            if (sothu2 == 0)
                return sothu1;
            else return UCLN(sothu2, sothu1 % sothu2);
        }
        public void Input()
        {
            Console.Write("Nhap vao so thu 1: ");
            sothu1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu 2; ");
            sothu2 = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            int a = UCLN(sothu1, sothu2);
            Console.WriteLine($"{sothu1} {sothu2} {a}");
        }
    }
}
