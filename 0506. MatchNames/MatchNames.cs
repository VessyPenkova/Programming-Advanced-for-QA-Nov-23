using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0506._MatchNames
{
    public class MatchNames
    {
        public static string Match(string names)
        {
            Regex pattern = new(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

            MatchCollection matches = pattern.Matches(names);

            StringBuilder sb = new();
            foreach (Match match in matches)
            {
                sb.Append($"{match.Value} ");
            }

            return sb.ToString().Trim();
        }
    }
}
