using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class FindWord
    {
        public static string FindNeedle(object[] haystack)
        {
            int pos = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == "needle")
                {
                    pos = i;
                }
            }

            return "found needle at position " + pos;
        }
    }
}
