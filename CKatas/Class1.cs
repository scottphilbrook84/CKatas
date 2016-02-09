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
}