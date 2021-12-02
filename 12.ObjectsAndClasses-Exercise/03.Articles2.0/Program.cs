using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < input; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                var title = tokens[0];
                var content = tokens[1];
                var author = tokens[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            var criteria = Console.ReadLine();

            switch (criteria)
            {
                case "title":
                    articles = articles.OrderBy(t => t.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(c => c.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
