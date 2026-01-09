using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        InputArr(arr);
        DisplayArr(arr);
        SortAsc(arr);
        DisplayArr(arr);
        SortDesc(arr);
        DisplayArr(arr);
    }

    public static int GetMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++) 
            if (arr[i] > max) max = arr[i];
        return max;
    }
    //Return the position th-k of x in the array.
    //Return -1 if find not found.
    public static int GetPos(int[] arr, int x, int theK)
    {
        int pos = -1, count=0;
        for (int i = 0;i < arr.Length; i++)
        {
            if (arr[i] == x) {
                count++;
                if (count == theK)
                {
                    pos = i; break;
                }
            }
        }
        return pos;
    }
    //Sort from first Max to second Max. Out of range keep remaining their orders.
    public static void SortInRange(int pos1, int pos2)
    {

    }
    public static void InputArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"a[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine()) ;
        }
    }

    public static void DisplayArr(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
    public static void SortAsc(int[] arr)
    {
        Array.Sort(arr);
    }
    public static void SortDesc(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }

}