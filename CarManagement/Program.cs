using carManagement;

namespace carManagement
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int sel;
            CarManagement myCar = new CarManagement();

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
            Console.WriteLine("0. Quit");
            Console.Write("Your selection: ");
        }
    }
}