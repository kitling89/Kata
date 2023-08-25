namespace Kata;

public class OddEven
{
    public static string OddOrEven(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        if (sum % 2 == 0)
            return "even";

        else
        {
            return "odd";
        }
    }
}