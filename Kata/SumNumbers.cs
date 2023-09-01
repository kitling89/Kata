namespace Kata;

public class SumNumbers
{
    public int GetSum(int a, int b)
    {
        int sum = 0;
        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
        }
        else if (a > b)
        {
            for (int i = b; i <= a; i++)
            {
                sum += i;
            }
        }
        else
        {
            return a;
        }
        
        return sum;
    }
}