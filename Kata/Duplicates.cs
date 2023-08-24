using System.ComponentModel;
using System.Linq;
using System;

namespace Kata;

public class Duplicates
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower(); // Convert the word to lowercase to ignore capitalization
            char[] chars = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                if (word.Count(c => c == word[i]) > 1)
                    chars[i] = ')';
                else
                {
                    chars[i] = '(';
                }
            }

            return new string(chars);
        }
    }
}