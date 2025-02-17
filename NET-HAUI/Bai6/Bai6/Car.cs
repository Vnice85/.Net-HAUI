using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Car : Vehicle
    {
        public string color {  get; set; }
        public Car() : base()
        {
            id = string.Empty;
            maker = string.Empty;
            model = string.Empty;
            year = 0;
            price = 0;
            color = string.Empty;
        }
        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.id = id;   
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
            this.color = color;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Color: ");
            color = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Color: {color}");
        }
        
    }
}
