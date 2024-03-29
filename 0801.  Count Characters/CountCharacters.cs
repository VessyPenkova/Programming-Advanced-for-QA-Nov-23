﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0801.__Count_Characters
{
    public class CountCharacters
    {
        public static string Count(List<string> input)
        {
            Dictionary<char, int> charCount = input.SelectMany(s => s)
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            StringBuilder sb = new();
            foreach (KeyValuePair<char, int> pair in charCount)
            {
                sb.AppendLine($"{pair.Key} -> {pair.Value}");
            }

            return sb.ToString().Trim();
        }
    }
}
