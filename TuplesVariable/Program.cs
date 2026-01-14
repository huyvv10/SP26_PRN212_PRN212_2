internal class Program
{
    private static void Main(string[] args)
    {
        int total, count;
        int[] arr = { 5,8,9,6,4,2,5,8,6} ;
        (total, count) = Sum(arr);
        Console.WriteLine($"Tong la: {total}, So phan tu: {count}");
        string[] str = { "15", "ABC", "8.5", "10", "FPT" };
        foreach (string e in str)
        {
            if (int.TryParse(e, out _))
            {
                Console.WriteLine(e + " is an integer number.");
            }
            else
            {
                Console.WriteLine(e + " is not an integer number.");
            }
        }

    }

    public static (int S, int C) Sum(int[] arr)
    {
        int S = 0, C = 0;
        foreach (int e in arr)
        {
            S += e;
            C++;
        }
        return (S, C);
    }
}