using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class Isograms
    {
        public static bool IsIsogram(string str)
        {
            string lowStr      = str.ToLower();
            char[] lowStrArray = lowStr.ToCharArray();

            HashSet<char> seenChars  = new HashSet<char>();
            bool          isRepeated = false;

            foreach (char c in lowStrArray)
            {
                if (seenChars.Contains(c))
                {
                    isRepeated = true;
                    break;
                }
                else
                {
                    seenChars.Add(c);
                }
            }

            return !isRepeated;
        }
    }
}
