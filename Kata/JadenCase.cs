namespace Kata;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string[] words = phrase.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            if (letters.Length > 0)
            {
                letters[0] = char.ToUpper(letters[0]);
                words[i] = new string(letters);
            }
        }

        string result = string.Join(" ", words);
        return result;

    }
}