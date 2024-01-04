using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0507._MatchPhoneNumbers
{
    public class MatchPhoneNumbers
    {
        public static string Match(string phones)
        {
            Regex pattern = new(@"\+359(?<seperators>[ -])2\k<seperators>[0-9]{3}\k<seperators>[0-9]{4}\b");
            MatchCollection matches = pattern.Matches(phones);

            return string.Join(", ", matches.Select(x => x.Value.Trim()).ToArray());
        }
    }

}
