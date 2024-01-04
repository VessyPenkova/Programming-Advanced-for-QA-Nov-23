namespace _0601._Count_Real_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            SortedDictionary<int, int> counts = new();

            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number] += 1;
                }
                else
                {
                    counts[number] = 1;
                }
            }
            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
