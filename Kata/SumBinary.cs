namespace Kata;

public class SumBinary
{
    public static string AddBinary(int a, int b)
    {
       int sum = a + b;
       return Convert.ToString(sum, 2);
    }
}