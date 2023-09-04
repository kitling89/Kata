using System;

namespace Kata;

public class SumSeries
{
    static void Main(string[] args)
    {
        int n = 7;
        Console.WriteLine(seriesSum(n));
    }
    
    
    public static string seriesSum(int n)
    {
        double total = 0.0;
        for (int i = 1; i <= n; i++)
        {
            total += 1.0 / ((3 * i) - 2);
        }

        total = Math.Round(total, 2);

        return total.ToString("0.00");
    }
}