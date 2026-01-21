using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManagement
{
    public abstract class Car
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

        public abstract double CalculateTax();
        public abstract void AddCar();
        public abstract void DisplayCarList();

        public Car(string id, string name, int color, double price)
            => (_id, Name, Color, Price) = (id, name, color, price);

        public void ShowCar()
        {
            Console.Write($"{_id,-5} {Name,-20} {Color,-7} {Price,-15}");
        }

    //public void ShowCar2() 
    //    => Console.Write($"{_id,-5} {Name,-20} {Color,-5} {Price,-10}");

}
}
