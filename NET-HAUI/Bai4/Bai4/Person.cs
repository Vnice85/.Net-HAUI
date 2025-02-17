using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public void Input()
        {
            Console.Write("ID: ");
            id = Console.ReadLine();
            Console.Write("NAME: ");
            name = Console.ReadLine();
            Console.Write("AGE: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("EMAIL: ");
            email = Console.ReadLine();
            Console.Write("ADDRESS: ");
            address = Console.ReadLine();
        }
        public void CheckAge()
        {
            if (age >= 18)
            {
                Console.WriteLine("Bạn đủ tuổi bầu cử");
            }
            else
                Console.WriteLine("Bạn còn nhỏ");
        }
        public void Output()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"NAME: {name}");
            Console.WriteLine($"AGE: {age}");   
            Console.WriteLine($"EMAIL: {email}");
            Console.WriteLine($"ADDRESS: {address} ");
        }
    }
}
