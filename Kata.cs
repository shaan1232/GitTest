using System;
public class DigPow
{

    private static int getSum(int n, int p)
    {
        string number = Convert.ToString(n);
        int sum = 0;
        int _sum;
        Console.WriteLine(n);
        for (int i = 0; i < number.Length; i++)
        {
            _sum = (Convert.ToInt32(number[i]) - 48);
            Console.WriteLine("_sum: " + _sum);
            sum += (int)Math.Pow(_sum, i + p);
        }
        return sum;
    }

    public static long digPow(int n, int p)
    {
        // your code
        // get sum
        return getSum(n, p);
    }

    static void Main(String[] args)
    {
        Console.WriteLine(digPow(695, 2));
    }
}