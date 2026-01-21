using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManagement
{
    public class CarManagement
    {
        public List<Car> carsList;
        public CarManagement()
        {
            carsList = new List<Car>();
        }

        public void AddNewCar()
        {
            Console.Write("Select 1 to add Electric car\nSelect 2 to add Gas car\nYour selection is: ");
            int.TryParse(Console.ReadLine(), out int selectType);
            Car x;
            if (selectType == 1)
            {
                x = new ElectricCar();
            }
            else
            {
                x = new GasCar();
            }
            x.AddCar();
            carsList.Add(x);
        }

        public void display()
        {
            Console.WriteLine($"{"Id",-5} {"Car Name",-20} {"Color",-5} {"Price",-15} {"Energy",-12} {"Tax", 15}");
            foreach (Car car in carsList)
            {
                car.DisplayCarList();
                //Console.WriteLine();
            }
        }

    }
}
