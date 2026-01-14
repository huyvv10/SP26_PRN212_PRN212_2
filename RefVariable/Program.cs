internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5, b = 7;
        Console.WriteLine($"a = {a}, b = {b}");
        swap( a, b );
        Console.WriteLine($"a = {a}, b = {b}");
        swap2(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b}");

        a = int.Parse( Console.ReadLine() );
        b = int.Parse( Console.ReadLine() );
        if (a > b) swap2(ref a, ref b);
        for( int i = a; i< b; i++ )
            Console.Write(i+" ");

    }
    public static void swap2(ref int x, ref int y)
    {
        int temp = x; x = y; y = temp;
        Console.WriteLine($"In swap a = {x}, b = {y}");
    }

    public static void swap(int x, int y)
    {
        int temp = x; x = y; y = temp;
        Console.WriteLine($"In swap a = {x}, b = {y}");
    }
}