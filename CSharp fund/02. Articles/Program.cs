using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                string commandType = commands[0];
                string commandValue = commands[1];
                if (commandType == "Edit")
                {
                    article.Edit(commandValue);
                }
                if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }
                if (commandType == "Rename")
                {
                    article.Rename(commandValue);
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

 
}
