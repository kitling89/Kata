using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class FirstLast
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
