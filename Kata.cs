using System;
public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int right = 0;
        int left = 0;
        int counter = arr.Length - 1;
        for (int i = 0; i < arr.Length; i++)
        {
            left += arr[i];
        }
        if (left == 0)
        {
            return 0;
        }
        left -= arr[arr.Length - 1];
        for (int i = arr.Length - 1; i > 0; i--)
        {
            if (right != left)
            {
                left -= arr[i - 1];
                right += arr[i];
            }
            printStatus(right, left);
            counter--;
            if (right == left)
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
    static void printStatus(int right, int left)
    {
        print("right:" + right + " left:" + left);
    }
    static void Main(String[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        print(FindEvenIndex(arr));
    }
}