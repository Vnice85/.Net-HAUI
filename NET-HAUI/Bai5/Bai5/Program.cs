using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static TimUCLN[] tu = new TimUCLN[3];
        static void Main(string[] args)
        {
          
          
            for(int i = 0; i < 3; i++)
            {
                tu[i].Input();
            }
            foreach (TimUCLN t in tu)
            {
                t.Output();
            }
        }
    }
}
