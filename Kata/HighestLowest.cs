namespace Kata;

public class HighestLowest
{
    public static string HighAndLow(string numbers)
    {
        string[] numberString =numbers.Split(' ');
        int[] numberArray = new int[numberString.Length];

        for (int i = 0; i < numberArray.Length; i++)
        {
            numberArray[i] = int.Parse(numberString[i]);
        }

        int min = numberArray.Min();
        int max = numberArray.Max();

        return $"{max} {min}";
    }
}