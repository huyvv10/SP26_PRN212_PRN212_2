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

        public void Init()
        {
            Car eCar1 = new ElectricCar("A08", "Vinfat VF8", 4, 55000, 2500);
            Car eCar2 = new ElectricCar("A09", "Vinfast VF9", 7, 68000, 3000);
            Car eCar3 = new ElectricCar("A10", "Tesla Model 3", 5, 52000, 2200);
            Car eCar4 = new ElectricCar("A11", "Tesla Model Y", 5, 60000, 2600);
            Car eCar5 = new ElectricCar("A12", "Hyundai Ioniq 5", 5, 48000, 2100);
            Car eCar6 = new ElectricCar("A13", "Kia EV6", 5, 50000, 2300);
            Car gCar1 = new GasCar("A13", "Kia Morning", 5, 35000, 5.6);
            Car gCar2 = new GasCar("A14", "Hyundai Grand i10", 5, 36000, 5.4);
            Car gCar3 = new GasCar("A15", "Toyota Vios", 5, 42000, 5.8);
            Car gCar4 = new GasCar("A16", "Honda City", 5, 44000, 5.7);
            Car gCar5 = new GasCar("A17", "Mazda 2", 5, 40000, 5.5);
            Car gCar6 = new GasCar("A18", "Suzuki Celerio", 5, 33000, 5.2);
            carsList.Add(eCar1);
            carsList.Add(eCar2);
            carsList.Add(eCar3);
            carsList.Add(eCar4);
            carsList.Add(eCar5);
            carsList.Add(eCar6);
            carsList.Add(gCar1);
            carsList.Add(gCar2);
            carsList.Add(gCar3);
            carsList.Add(gCar4);
            carsList.Add(gCar5);
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
            Console.WriteLine($"{"Id",-5} {"Car Name",-20} {"Color",-7} {"Price",-15} {"Energy",-12} {"Tax", 15}");
            foreach (Car car in carsList)
            {
                car.DisplayCarList();
                //Console.WriteLine();
            }
        }

    }
}
