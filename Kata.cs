using System;
public static class Kata
{
    private static int getLower(int n)
    {

        // just count thr rows (3 + 2 + 1)
        int rows = 1; // current row
        int countSum = 0; // counts current sum

        // each row carries 'rows' number of odd ints, so add +2 to countSum
        while (rows < n)
        {
            for (int i = 0; i < rows; i++)
            {
                countSum += 2;
            }
        }
        return countSum;

    }

    public static long rowSumOddNumbers(long n)
    {
        // TODO
        // rowSumOddNumbers(4) = 3 + 2 + 1
        //getLower(System.out.println(countSum));



        // 1
        // 2
        // 3
        // 4
        // 5

    }
    static void Main(String[] args)
    {
        Console.WriteLine(getLower(4));
    }
}