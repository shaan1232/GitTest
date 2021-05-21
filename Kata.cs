using System;
public static class Kata
{
    /// <summary>
    /// gets the lowest odd number of n row
    /// </summary>
    /// <param name="n"> row in which lowest number is found</param>
    /// <returns>lowest odd number of n row</returns>
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

    /// <summary>
    /// Of odd number pyramid, finds the sum of the inputted row
    /// </summary>
    /// <param name="n">
    /// Selected row in which sum of odds will be found
    /// </param>
    /// <returns>
    /// Sum of n row
    /// </returns>
    public static long rowSumOddNumbers(long n)
    {
        long sum = getLower(n);
        long sum_row = 0;
        for (int i = 0; i < n; i++)
        {
            sum_row += (2 * i) + sum;
        }
        return sum_row;
    }


    static long kataSolution_rowSumOddNumbers(long n)
    {
        return (n ^ 3);
    }
    static void Main(String[] args)
    {
        Console.WriteLine(rowSumOddNumbers(1));
        Console.WriteLine(rowSumOddNumbers(2));
        Console.WriteLine(rowSumOddNumbers(2));
    }
}