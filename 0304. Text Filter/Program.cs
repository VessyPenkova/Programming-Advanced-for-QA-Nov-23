namespace _0304._Text_Filter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                 .Split(", ")
                 .ToArray();

            string stringToSubstring = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (stringToSubstring.Contains(bannedWord))
                {
                    stringToSubstring = stringToSubstring.Replace(bannedWord,
                        new string('*', bannedWord.Length));
                }
            }
            Console.WriteLine(stringToSubstring);
        }
    }
}
