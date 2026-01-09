internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input a = ");
        var a = int.Parse(Console.ReadLine());
        Console.Write("Input b = ");
        var b = int.Parse(Console.ReadLine());
        Console.Write("Input c = ");
        var c = int.Parse(Console.ReadLine());

        if(a+b>c && b+c>a && a+c>b)
            Console.WriteLine($"{a} {b} and {c} are the edges of a triangle.");
        else Console.WriteLine($"{a} {b} and {c} are not the edges of a triangle.");
    }
}