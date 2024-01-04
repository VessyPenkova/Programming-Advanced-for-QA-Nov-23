﻿namespace _1102._Articles
{
    public class Program
    {
        static void Main(string[] args)
        {

            string inputInfo = Console.ReadLine();

            string[] infoParts = inputInfo.Split(", ").ToArray();

            string currenttTitle = infoParts[0];
            string currentContent = infoParts[1];
            string currentAuthor = infoParts[2];

            Article currentarticle = new Article()
            {
                Title = currenttTitle,
                Content = currentContent,
                Author = currentAuthor
            };

            int numberOFinputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFinputs; i++)
            {
                string[] commands = Console.ReadLine().Split(": ").ToArray();
                string command = commands[0];
                if (command == "Edit")
                {
                    string newContent = commands[1];
                    currentarticle.Edit(newContent);
                }
                if (command == "ChangeAuthor")
                {
                    string newAuthor = commands[1];
                    currentarticle.ChangeAuthor(newAuthor);
                }
                if (command == "Rename")
                {
                    string newTitle = commands[1];
                    currentarticle.Rename(newTitle);
                }
            }
            //Console.WriteLine($"{currentarticle.Title} - {currentarticle.Content}: {currentarticle.Author}");
            Console.WriteLine(currentarticle.ToString());
        }
    }
}
