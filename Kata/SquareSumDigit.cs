
namespace Kata
{
    public class SquareSumDigit
    {
        public static int SquareDigits(int n)
        {
            var concatenatedSquareDigits = string.Empty;

            foreach (char digitChar in n.ToString())
            {
                int digit  = int.Parse(digitChar.ToString());
                int square = digit * digit;
                concatenatedSquareDigits += square.ToString();
            }

            int result = int.Parse(concatenatedSquareDigits);

            return result;
        }
    }
}