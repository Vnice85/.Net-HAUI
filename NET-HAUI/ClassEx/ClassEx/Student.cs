using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Xml.Schema;

namespace ClassEx
{
    class Student : Person
    {
        private byte _maths;
        private byte _physics;
        public byte maths
        {
            get { return _maths; }
            set
            {
                if (byte.TryParse(value.ToString(), out byte result))
                {
                    _maths = result;
                }
                else
                    Console.WriteLine("Nhap vao so nguyen duong");
            }
        }
        public byte physics
        {
            get { return _physics; }
            set
            {
                if (byte.TryParse(value.ToString(), out byte result))
                {
                    _physics = result;
                }
                else
                    Console.WriteLine("Nhap vao so nguyen duong");
            }
        }
        public Student()
        {
            this.id = 0;
            this.name = "";
            this.address = "";
            this.maths = 0;
            this.physics = 0;
        }
        public Student(int id, string address, byte maths, byte physics)
        {
            this.id = id;
            this.address = address;
            this.maths = maths;
            this.physics = physics;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap vao diem toan: ");
            maths = byte.Parse(Console.ReadLine());
            Console.Write("Nhap vao diem ly: ");
            physics = byte.Parse(Console.ReadLine());
        }
        public void total()
        {
            Console.WriteLine($"tong diem: {maths+physics}");
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Diem toan: {maths}");
            Console.WriteLine($"Diem ly: {physics}");
            total();
        }
        
    }
}