using System;
using System.Globalization;

public class Number
{
    public static bool isValidSum(int n)
    {
        return (n < 10);
    }
    static int DigitalRoot(long n)
    {
        // Your awesome code here!
        int sum = 0;
        bool flag = false;
        string num = n.ToString();
        while (sum < 10 && !flag)
        {
            foreach (char c in num)
            {
                sum += CharUnicodeInfo.GetDecimalDigitValue(c);
            }
            if (isValidSum(sum))
            {
                flag = true;
            }
            else
            {
                num = sum.ToString();
                sum = 0;
            }

        }
        return sum;
    }

    private static void testcases()
    {
        Console.WriteLine(DigitalRoot(16) == 7);
        Console.WriteLine(DigitalRoot(456) == 6);
        Console.WriteLine(DigitalRoot(942) == 6);
        Console.WriteLine(DigitalRoot(132189) == 6);
        Console.WriteLine(DigitalRoot(493193) == 2);

    }
    static void Main(String[] args)
    {
        testcases();
    }
}