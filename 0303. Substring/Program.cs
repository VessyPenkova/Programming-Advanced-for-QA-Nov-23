﻿namespace _0303._Substring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            int index = secondString.IndexOf(firstString);

            while (index != -1)
            {
                secondString = secondString.Remove(index, firstString.Length);
                index = secondString.IndexOf(firstString);
            }

            Console.WriteLine(secondString);
        }
    }
}
