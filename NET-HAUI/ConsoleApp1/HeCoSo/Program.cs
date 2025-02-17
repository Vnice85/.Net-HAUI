using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HeCoSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao he co so: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so can chuyen: ");
            string number1 = Console.ReadLine();
            string number = number1.ToUpper();
            Console.WriteLine(Chuyen(number, b));
         
        }
        static string Chuyen(string number, int b)
        {
            int result = 0;
            int so;
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'A':
                        so = 10;
                        break;
                    case 'B':
                        so = 11;
                        break;
                    case 'C':
                        so = 12;
                        break;
                    case 'D':
                        so = 13;
                        break;
                    case 'E':
                        so = 14;
                        break;
                    case 'F':
                        so = 15;
                        break;
                    default:
                        so = int.Parse(arr[i].ToString());
                        break;
                }
                result = result + so * (int)Math.Pow(b, i);
            }

            return Convert.ToString(result);
        }
        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap vao so nguyen n: ");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Nhap vao he co so muon chuyen: ");
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    string result = Chuyen(n, b);
        //    Console.WriteLine(result);
        //}
        //static string Chuyen(int n, int b)
        //{
        //    int gt;
        //    string result = "";
        //    while (n > 0)
        //    {
        //        gt = n % b;
        //        result = kt(gt) + result;
        //        n = n / b;
        //    }
        //    return result;

        //}
        //static char kt(int gt)
        //{
        //    if (gt < 10)
        //        return (char)('0' + gt);
        //    else
        //        return (char)('A' + (gt - 10));
        //}
    }
}
