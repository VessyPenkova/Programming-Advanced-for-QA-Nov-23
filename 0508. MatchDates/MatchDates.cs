﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0508._MatchDates
{
    public class MatchDates
    {
        public static string Match(string? dates)
        {
            if (dates is null)
            {
                throw new ArgumentException("Input cannot be null!");
            }

            Regex pattern = new(@"\b(?<day>\d{2})(?<seperator>[-.\/])(?<month>[A-Z][a-z]+)\k<seperator>(?<year>\d{4})");

            MatchCollection matches = pattern.Matches(dates);
            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                return $"Day: {day}, Month: {month}, Year: {year}";
            }

            return string.Empty;
        }
    }
}
