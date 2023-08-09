using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class RemoveVowels
    {
        public static string Disemvowel(string str)
        {
            string vowels = "AEIOUaeiou";
            string result = "";

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
