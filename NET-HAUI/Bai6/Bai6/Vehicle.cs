using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Vehicle : IVehicle
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicle()
        {
            id = string.Empty;
            maker = string.Empty;
            model = string.Empty;
            year = 0;
            price = 0;
        }
        public Vehicle(string id)
        {
            this.id = id;
        }
        public Vehicle(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public virtual void Input()
        {
            Console.Write("id: ");
            id = Console.ReadLine();
            Console.Write("maker: ");
            maker = Console.ReadLine();
            Console.Write("model: ");
            model = Console.ReadLine();
            Console.Write("year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("price: ");
            price = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write($"id: {id} ");
            Console.Write($"maker: {maker} ");
            Console.Write($"model: {model} ");
            Console.Write($"year: {year} ");
            Console.Write($"price: {price} ");
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Vehicle)) return false;
            return ((Vehicle)obj).id == id;
        }
        public override string ToString()
        {
            return $"id: {id}\t " +
                   $"maker: {maker}\t" +
                   $"model: {model}\t" +
                   $"year: {year}\t" +
                   $"price: {price}\t";
        }
    }
}
