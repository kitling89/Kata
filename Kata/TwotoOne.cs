using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class TwotoOne
    {
        public static string Longest(string s1, string s2)
        {
            string s3Str    = s1 + s2;
            string s3StrDis = new string(s3Str.Distinct().OrderBy(c => c).ToArray());
            return (s3StrDis);
        }
    }
}
