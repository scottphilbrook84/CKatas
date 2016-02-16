using System;
using System.Linq;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        if (System.Math.Sqrt(num) % 1 == 0D)
        {
            return (long)System.Math.Pow(System.Math.Sqrt(num) + 1, 2);
        }
        else
        {
            return -1;

        }
    }

    public static double Chain(double input, Func<double, double>[] fs)
    {
        fs.ToList().ForEach(x => input = x.Invoke(input));
        return input;
    }

    public static int TwoCount(int n)
    {
        int numberOf2s = 0;
        while (n % 2 == 0)
        {
            n = n >> 1;
            numberOf2s += 1;
        }
        return numberOf2s;
    }

}

public class EmailObfuscator
{

    public static string Obfuscate(string email)
    {
        return email.Replace("@", " [at] ").Replace(".", " [dot] ");
    }
}

public class TwistedSum
{
    public static long Solution(long n)
    {
        long hundreds = n / 100;
        long sum = 900 * hundreds;

        for (long start = 1; start < hundreds; start ++)
        {
            long digit = start;
            long digitsum = 0;
            while (digit > 0)
            {
                digitsum += digit % 10;
                digit = digit / 10;
            }
            sum += 100 * digitsum;
        }

        long remainder = n % 100;
        for (long loopindex = (n - remainder); loopindex <= n; loopindex++)
        {
            long digit = loopindex;
            while (digit > 0)
            {
                sum += digit % 10;
                digit = digit / 10;
            }
        }


        return sum;
    }
}

public class PlayPass
{

    public static string playPass(string s, int n)
    {
        return new string(s.ToCharArray()
                           .Select(x => Char.IsLetter(x) ? (char)((int)x + n > 90 ? (int)x + n - 26 : (int)x + n) : (Char.IsDigit(x) ? Char.Parse((9 - int.Parse(x.ToString())).ToString()) : (char)x))
                           .Select((x, i) => i % 2 == 1 ? (Char.IsLetter(x) ? Char.ToLower(x) : x) : x)
                           .Reverse()
                           .ToArray());
    }
}
