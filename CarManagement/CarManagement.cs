using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManagement
{
    public class CarManagement
    {
        public List<ElectricCar> eCarList;
        public CarManagement()
        {
            eCarList = new List<ElectricCar>();
        }

        public void AddElectricCar()
        {
            Console.Write("Input id: ");
            string id = Console.ReadLine();
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            Console.Write("Input color: ");
            int color = int.Parse(Console.ReadLine());
            Console.Write("Input price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Input battery capcity: ");
            int bat = int.Parse(Console.ReadLine());

            ElectricCar x = new ElectricCar(id, name, color, price, bat);
            eCarList.Add(x);
        }

        public void display()
        {
            Console.WriteLine($"{"Id",-5} {"Car Name",-20} {"Color",-5} {"Price",-10} {"Energy",10}");
            foreach (ElectricCar car in eCarList)
            {
                car.ShowCar();
            }
        }

    }
}
