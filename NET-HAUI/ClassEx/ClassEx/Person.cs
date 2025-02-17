using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEx
{
    class Person
    {
        protected int id;
        public string name { get; set; }
        public string address { get; set; }
        public int Id
        {
            get { return id; }
            set
            {
                if (int.TryParse(value.ToString(), out int result))
                {
                    id = result;
                }
                else
                {
                    Console.WriteLine("ERROR: So nhap vao phai la so nguyen");
                }
            }
        }
        public Person()
        {
            id = 0;
            name = string.Empty;
            address = string.Empty;
        }
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public virtual void Input()
        {
            Console.Write("Nhap vao id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao dia chi: ");
            address = Console.ReadLine();
            Console.Write("Nhap vao ten: ");
            name = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"name: {name}");
            Console.Write($"address: {address}");
        }

    }
}
