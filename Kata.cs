using System;
public static class Kata
{
    private static long getLower(long n)
    {

        // just count the rows 
        // getLower(4) = (1 + 2 + 3) where each int represents number of odd numbers per row
        int rows = 1; // current row
        int countSum = 1; // counts current sum

        // each row carries 'rows' number of odd ints, so add +2 to countSum
        while (rows < n)
        {
            for (int i = 0; i < rows; i++)
            {
                countSum += 2;
            }
            rows++;
        }
        return countSum;

    }

    public static long rowSumOddNumbers(long n)
    {

        return 3;

    }
    static void Main(String[] args)
    {
        Console.WriteLine(getLower(5));
    }
}