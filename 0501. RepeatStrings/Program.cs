using System.Text;

namespace _0501._RepeatStrings
{
    public class RepeatStrings
    {
        public static string Repeat(string[] input)
        {
            StringBuilder sb = new();

            foreach (string s in input)
            {
                string repeatedString = string.Concat(Enumerable.Repeat(s, s.Length));
                sb.Append(repeatedString);
            }

            return sb.ToString().Trim();
        }
    }
}
