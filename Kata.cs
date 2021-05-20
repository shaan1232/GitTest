using System;
using System.Linq;

public class Kata
{
    private static Boolean isUsed(char[] usedLettersArray, char c)
    {
        return (usedLettersArray.Contains(c));
    }

    public static int DuplicateCount(string str)
    {
        // we can loop for each letter inside the input, but that will be
        // very unoptimized, since it would run 26 times

        // a better solution would be to keep an array of each letter
        // that has already been run, and skip if it has. And go left 
        // to right on the WHOLE input.
        char[] usedLetter = new char[36]; // this takes into account all english letters a-z and numerals 0-9
        char C;
        char c;
        int numDoubles = 0;
        int counter = 0;
        char d;

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsUpper(str[i]))
            {
                C = str[i];
                c = Char.ToLower(C);
            }
            else
            {
                c = str[i];
                C = Char.ToUpper(c);
            }

            if (!isUsed(usedLetter, c))
            {
                usedLetter[counter] = c;
                counter++;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (Char.IsUpper(str[j]))
                    {
                        d = Char.ToLower(str[j]);
                    }
                    else
                    {
                        d = str[j];
                    }
                    if (c == d)
                    {
                        numDoubles++;
                        Console.WriteLine(c + " and " + d + " is a double!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(c + " and " + d + " is NOT a double!");

                    }
                }
            }
        }
        return numDoubles;
    }

    static void Main(String[] args)
    {
        Console.WriteLine(DuplicateCount("Hello World"));
    }

}