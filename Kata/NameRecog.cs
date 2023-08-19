using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class NameRecog
    {
        public static string AreYouPlayingBanjo(string name)
        {
            char[] nameChars = name.ToLower().ToCharArray();
            if (nameChars[0] == 'r')
            {
                return name + " plays banjo";
            }

            else return name + "does not play banjo";
        }
    }
}
