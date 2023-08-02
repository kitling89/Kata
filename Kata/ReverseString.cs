using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class ReverseString
    {
        public static string Solution(string str)
        {
            int    len       = str.Length;
            char[] arraChars = str.ToCharArray();
            string outp      = string.Empty;

            for (int i = len - 1; i >= 0; i--)
            {
                outp += arraChars[i];
            }

            return outp;
        }
    }
}
