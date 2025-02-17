
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] s = File.ReadAllLines(@"C:\Users\Vnice\source\repos\ClassEx\ClassEx\bin\Debug\test.txt");

            Console.WriteLine(s[0]);
            
        }


    }
    }
