using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManagement
{
    public class ElectricCar : Car
    {
        public int Baterry {  get; set; }

        public ElectricCar() { }    

        public ElectricCar(string Id, string name, int color, double price, int bat): base(Id, name, color, price) { 
            this.Baterry = bat;
        }

        public override double CalculateTax()
        {
            return Price <= 30000 ? Price * 0.1 : Price* 0.15 ;
        }
        public override void DisplayCarList()
        {
            base.ShowCar();
            Console.WriteLine($"{Baterry,-12} {CalculateTax(),15}");
        }

        public override void AddCar()
        {
            Console.Write("Input id: ");
            Id = Console.ReadLine();
            Console.Write("Input name: ");
            Name = Console.ReadLine();
            Console.Write("Input color: ");
            Color = int.Parse(Console.ReadLine());
            Console.Write("Input price: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Input battery capcity: ");
            Baterry = int.Parse(Console.ReadLine());
        }

    }
}
