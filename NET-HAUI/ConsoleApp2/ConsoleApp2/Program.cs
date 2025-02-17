using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Open("old.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            string up = content.ToUpper();
            fs.Close();
            fs = File.Open("new.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs)
            {
                AutoFlush = true
            };
            
            string s = " anh yeu em";
            sw.Write("anh yeu con cak");
            fs.Close();

        }
    }
}
