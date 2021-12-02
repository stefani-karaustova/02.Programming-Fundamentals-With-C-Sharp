using System;

namespace _02.Articles
{
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

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article(input[0], input[1], input[2]);

            var commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] line = Console.ReadLine().Split(": ");
                var command = line[0];
                var newLine = line[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(newLine);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newLine);
                        break;
                    case "Rename":
                        article.Rename(newLine);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
