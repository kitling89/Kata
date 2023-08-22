namespace Kata;

public class Factorial
{
    public static int TrailingZeros(int n)
    {
        int count = 0;
        int divisor = 5; // Counting the number of 5s in the prime factorization of the factorial

        while (n >= divisor)
        {
            count += n / divisor;
            divisor *= 5;
        }

        return count;
    }
}