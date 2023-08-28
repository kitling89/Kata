using System.ComponentModel.Design;

namespace Kata;

public class BoolToString
{
    public static string boolToWord(bool word)
    {
        if (word) return "Yes";

        else return "No";
    }
}