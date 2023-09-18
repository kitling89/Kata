namespace Kata;

public class SentenceSmash
{
    public static string Smash(string[] words)
    {
        string sentence = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            sentence = sentence + " " + words[i];
        }

        return sentence;
    }
}