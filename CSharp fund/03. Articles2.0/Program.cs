using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    class Articles
    {
        public Articles(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return $"{this.Title} -{this.Content}:{this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Articles> newArticle = new List<Articles>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine()
                .Split(',')
                .ToArray();

                string title = article[0];
                string content = article[1];
                string author = article[2];

                Articles articles = new Articles(title, content, author);
                newArticle.Add(articles);

            }
           

            
            Console.WriteLine(String.Join(Environment.NewLine, newArticle));
        }

    }
}
