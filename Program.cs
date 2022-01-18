﻿using System;
using Balta.ContentContext;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao/objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            foreach(var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("-----------");
            }
        }
    }
}