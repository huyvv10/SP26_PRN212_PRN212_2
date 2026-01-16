using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManagement
{
    public class Car
    {
        private string _id;
        public string Id { 
            get { return _id; } 
            set { _id = value; }
        }    
        public string Name { get; set; }
        public int Color { get; set; }
        public double Price { get; set; }

        public Car() { }
        //public Car(string id, string name, int color, double price)
        //{
        //    this._id = id;
        //    this.Name = name;
        //    this.Color = color;
        //    this.Price = price;
        //}

        public Car(string id, string name, int color, double price)
            => (_id, Name, Color, Price) = (id, name, color, price);

        public void ShowCar()
        {
            Console.Write($"{_id,-5} {Name,-20} {Color,-5} {Price,-10}");
        }

        public void ShowCar2() 
            => Console.Write($"{_id,-5} {Name,-20} {Color,-5} {Price,-10}");

    }
}
