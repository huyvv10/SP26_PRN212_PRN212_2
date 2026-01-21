using carManagement;

namespace carManagement
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int sel;
            CarManagement myCar = new CarManagement();
            myCar.Init();
            do
            {
                Menu();
                sel = int.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        myCar.AddNewCar();
                        myCar.display();
                        break;
                    case 2:
                        myCar.display(); break;
                    case 0: break;
                    default:
                        Console.WriteLine("Invalid selection. Please select again."); break;
                }

            } while (sel != 0);
        }

        public static void Menu()
        {
            Console.WriteLine("\n-----------------------\n");
            Console.WriteLine("1. Add a new Electric Car");
            Console.WriteLine("2. Display Car List");
            Console.WriteLine("3. Search car by ID");
            Console.WriteLine("4. Search car by name");
            Console.WriteLine("5. Search car by price in range");
            Console.WriteLine("6. Update car info");
            Console.WriteLine("7. Delete car by Id");
            Console.WriteLine("8. Sort Car List");
            Console.WriteLine("9. Statistic");
            Console.WriteLine("0. Quit");
            Console.Write("Your selection: ");
        }
    }
}