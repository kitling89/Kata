namespace Kata;

public class Cubes
{
    public static long CalculateCubeSum(long n)
    {
        return (n * (n + 1) / 2) * (n * (n + 1) / 2);
    }
    public static long findNb(long m)
    {
        long n = 1;
        while (CalculateCubeSum(n) < m)
        {
            n++;
        }

        return CalculateCubeSum(n) == m ? n : -1;
    }
}