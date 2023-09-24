using System.Text;

namespace Kata;

public class LetterPosition
{
    public static string AlphabetPosition(string text)
    {
        char[] textChars = text.ToCharArray();
        StringBuilder resultBuilder = new StringBuilder();

        foreach (char currentChar in textChars)
        {
            if (char.IsLetter(currentChar))
            {
                int position = GetPosition(currentChar);
                resultBuilder.Append(position);
                resultBuilder.Append(" "); // Add a space after each letter's position
            }
        }

        // Remove the trailing space, if any
        if (resultBuilder.Length > 0)
        {
            resultBuilder.Length--; // Remove the last character (space)
        }

        return resultBuilder.ToString();
    }

    static int GetPosition(char letter)
    {
        return char.ToUpper(letter) - 'A' + 1;
    }
}