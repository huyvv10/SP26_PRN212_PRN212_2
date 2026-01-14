internal class Program
{
    public delegate int Tinhtoan(int x, int y);
    private static void Main(string[] args)
    {
        Console.Write("In put a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("In put b = ");
        int b = int.Parse(Console.ReadLine());
        Tinhtoan tt;
        tt = Sum;
        int rs; 
        rs = tt(a, b);
        Console.WriteLine($"Ket qua: {rs}");

        tt = Substract;
        rs = tt(a, b);
        Console.WriteLine($"Ket qua: {rs}");

        tt = Product;
        rs = tt(a, b);
        Console.WriteLine($"Ket qua: {rs}");
    }

    public static int Sum(int x, int y) { return x + y; }
    public static int Substract(int x, int y) => x - y;
    public static int Product(int x, int y) => x * y;



}