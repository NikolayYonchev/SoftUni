using System;
using System.Linq;
using System.Collections.Generic;
/*
some title, some content, some author
3
Edit: better content
ChangeAuthor: better author
Rename: better title

 */
namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            int n = int.Parse(Console.ReadLine());
            string title = input[0];
            string content = input[1];
            string author = input[2];
            Article article = new Article(title, content, author);
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                switch (commands[0])
                {
                    case "Edit":
                        string newContent = commands[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = commands[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = commands[1];
                        article.Rename(newTitle);
                        break;
                }




            }
            Console.WriteLine(article.ToString());
        }


        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public void Edit(string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Title = newTitle;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
    }
}