using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input a month: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Input a year: ");
        int y = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 1: 
            case 3: 
            case 5: 
            case 7: 
            case 8: 
            case 10: 
            case 12:
                Console.WriteLine($"The month {m} has 31 days"); break;
            case 4: 
            case 6: 
            case 9: 
            case 11: 
                Console.WriteLine($"The month {m} has 30 days"); break;
            case 2:
                if(y%400==0 || (y%4==0 && y % 100 != 0))
                {
                    Console.WriteLine($"The month {m} has 29 days"); break;
                }
                   
                else
                {
                    Console.WriteLine($"The month {m} has 28 days"); break;
                }
            default:
                Console.WriteLine($"The month {m} is not a month. Please input again."); break;
        }
    }
}