using System;
using System.Linq;
using System.Collections.Generic;
/*
2
Science, planets, Bill
Article, content, Johnny


 */
namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article article = new Article(title, content, author);

                list.Add(article);
            }
            foreach (Article smt in list)
            {
                Console.WriteLine(smt.ToString());
            }

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

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
    }
}