using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class DetectPangram
    {
        public static bool IsPangram(string str)
        {
            string strLwr  = str.ToLower();
            string letters = "abcdefghijklmnopqrstuvwxyz";

            foreach (char c in strLwr)
            {
                if (letters.Contains(c))
                {
                    letters = letters.Replace(c.ToString(), "");
                }
            }

            if (letters.Length > 0)
            {
                return false;
            }

            return true;
        }
    }
}
