namespace _1302._Enter_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {

            static int ReadNumber(int startRange, int endRange)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= startRange || number >= endRange)
                {
                    throw new ArgumentException();
                }

                return number;
            }

            List<int> numbers = new List<int>();

            int previousNumber = 1;

            while (numbers.Count < 10)
            {
                try
                {
                    int number = ReadNumber(previousNumber, 100);

                    numbers.Add(number);
                    previousNumber = number;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Your number is not in range {previousNumber} - 100!");
                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }

}
