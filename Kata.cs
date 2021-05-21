using System;

public static class Kata
{
    /// <summary>
    /// Array which converts an int say 1234 to an array = {1,2,3,4}
    /// This code is from stack over
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static int[] intToArray(int num)
    {
        String numString = num.ToString();
        int[] numbers = new int[numString.Length];
        for (int i = 0; i < numString.Length; i++)
        {
            numbers[i] = Convert.ToInt32(numString[i]) - 48; // Converts to ascii, -48 to get pure int value
        }
        return numbers;
    }
    public static int DescendingOrder(int n)
    {
        int numVariables = (int)Math.Floor(Math.Log10(n) + 1); // assuming no negative ints
        int[] array = intToArray(n); // Array of int values

        // Selection sort
        int largestNumber = -1; // assuming no negatives in input, even a 0 is larger than this
        int save = -1;
        for (int i = 0; i < numVariables; i++)
        {
            if (!(i >= 1 && array[i] == array[i - 1]))
            {
                for (int j = i; j < numVariables; j++)
                {
                    if (largestNumber < array[j])
                    {
                        largestNumber = j;
                    }
                    // swap
                    save = array[i];
                    array[i] = largestNumber;
                    array[largestNumber] = save;

                }
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        return numVariables;
    }

    static void Main(String[] args)
    {
        Console.WriteLine(DescendingOrder(123));


    }
}
