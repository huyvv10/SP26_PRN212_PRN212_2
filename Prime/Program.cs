internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input an integer: ");
        int n = int.Parse(Console.ReadLine());
        if (IsPrime(n))
            Console.WriteLine($"{n} is a prime number.");
        else
            Console.WriteLine($"{n} is not a prime number.");
        ListPrimeToN( n );
        Console.WriteLine();
        ListTheFirstNPrimes( n );   
    }

    //List the first n prime number.
    public static void ListTheFirstNPrimes(int n)
    {
        int count = 0, i=2;
        while (count < n) {
            if (IsPrime(i))
            {
                count++;
                Console.Write(i + " ");
            }
            i++;
        }
    }

    //List prime numbers from 2 to N
    public static void ListPrimeToN(int n)
    {
        if (n < 2) return;
        for (int i = 2; i <= n; i++) { 
            if (IsPrime(i)) Console.Write(i+" ");
        }
    }
    public static bool IsPrime(int n)
    {
        if(n<2) return false;
        for (int i = 2; i*i<=n; i++) 
            if (n % i == 0) return false;
        return true;
    }
}