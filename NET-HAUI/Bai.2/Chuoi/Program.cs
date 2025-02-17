using System;

namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot chuoi: ");
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            foreach (char c in arr)
            {
                Console.WriteLine(c);
            }
            string[] sp = s.Split(new char[] { ' ' });
            foreach (string d in sp)
            {
                Console.WriteLine(d);
            }
            //dem chuoi
            Dictionary<char, int> CharCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (CharCount.ContainsKey(c))
                {
                    CharCount[c]++;
                }
                else
                {
                    CharCount[c] = 1;
                }
            }
            foreach (KeyValuePair<char, int> item in CharCount)
            {
                Console.WriteLine($"Ky tu {item.Key} xuat hien {item.Value} lan");

            }

        }
   
    }
}