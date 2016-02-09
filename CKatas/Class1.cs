public class Kata
{
    public static long FindNextSquare(long num)
    {

        // your code here
        var x = System.Math.Pow(num, 1 / 3);
        x = System.Math.Round(x);
        if (System.Math.Pow(x, 3) == num)
        {
            return (long)System.Math.Pow(x + 1, 3);
        }
        else
        {
            return -1;

        }
    }
}