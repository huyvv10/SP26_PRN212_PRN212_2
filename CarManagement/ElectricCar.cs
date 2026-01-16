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

        public ElectricCar(string Id, string name, int color, double price, int bat): base(Id, name, color, price) { 
            this.Baterry = bat;
        }

        public void ShowCar()
        {
            base.ShowCar();
            Console.WriteLine($"{Baterry,10}");
        }
    }
}
