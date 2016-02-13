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
            n = n>>1;
            numberOf2s += 1;
        }
        return numberOf2s;
    }

}

public class EmailObfuscator
{

    public static string Obfuscate(string email)
    {
        return email.Replace("@"," [at] ").Replace("."," [dot] ");
    }
}