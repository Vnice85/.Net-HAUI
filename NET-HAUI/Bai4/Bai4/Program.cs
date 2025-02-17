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
            Person Ps = new Person();
            Ps.Input();
            Ps.Output();    
            Ps.CheckAge();
        }
    }
}
