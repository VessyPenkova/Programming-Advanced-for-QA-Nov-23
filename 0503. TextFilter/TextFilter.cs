using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextFilter
{
    public static string Filter(string[] bannedWords, string text)
    {
        foreach (string word in bannedWords)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, new string('*', word.Length));
            }
        }

        return text;
    }
}
