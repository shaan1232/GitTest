using System;
public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int upper = 0;
        int lower = 0;
        int counter = arr.Length - 1;
        for (int i = 0; i < arr.Length; i++)
        {
            lower += arr[i];
        }
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (upper != lower)
            {
                lower -= arr[i];
                upper += arr[i];
            }
            printStatus(upper, lower);
            counter--;
            if (upper == lower)
            {
                return counter;
            }
        }
        return -1;
    }

    static void print(int input)
    {
        Console.WriteLine(input);
    }
    static void print(String input)
    {
        Console.WriteLine(input);
    }
    static void printStatus(int upper, int lower)
    {
        print("Upper:" + upper + " Lower:" + lower);
    }
    static void Main(String[] args)
    {
        int[] arr = { 1, 100, 50, -51, 1, 1 };
        print(FindEvenIndex(arr));
        print(FindEvenIndex(ar1r));
    }
}