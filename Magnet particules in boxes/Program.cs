using System;

public class Magnets
{
    public static void Main()
    {
        // Test
        var t = Doubles(1, 3);
        // ...should return 0.4236111111111111
    }

    public static double Doubles(int maxk, int maxn)
    {
        double sum = 0;

        for (int k = 1; k <= maxk; k++)
        {
            for (int n = 1; n <= maxn; n++)
                sum += 1d / (k * Math.Pow(n + 1, 2 * k));
        }

        return sum;
    }
}