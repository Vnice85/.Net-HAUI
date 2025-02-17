using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Truck : Vehicle
    {
        public int truckload { get; set; }
        public Truck() : base()
        {
            id = string.Empty;
            maker = string.Empty;
            model = string.Empty;
            year = 0;
            price = 0;
            truckload = 0;
        }
        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
            this.truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Color: ");
            truckload = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Color: {truckload}");
        }
        
    }
}
