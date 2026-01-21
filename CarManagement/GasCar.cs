using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManagement
{
    public class GasCar:Car
    {
        public double Fuel {  get; set; }

        public GasCar() { }

        public GasCar(string id, string name, int color, double price, double fuel): base(id, name, color, price)
        {
            this.Fuel = fuel;
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
            Console.Write("Input fuel capacity/100km: ");
            Fuel = double.Parse(Console.ReadLine());
        }

        public override double CalculateTax()
        {
            return Price <= 30000 ? Price * 0.2 : Price * 0.3;
        }
        public override void DisplayCarList()
        {
            base.ShowCar();
            Console.WriteLine($"{Fuel,-12} {CalculateTax(), 15}");
        }
    }
}
