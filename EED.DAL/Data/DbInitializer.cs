using EED.DAL.Context;
using EED.DAL.Models;
using System;
using System.Linq;

namespace EED.DAL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EEDSqlContext context)
        {
            Console.Write("Db create");
            context.Database.EnsureCreated();
            if (context.Articles.Any())
            {
                Console.Write("Db create");
                return;
            }
            Console.Write("Generate db");
            var TypeArticles = new TypeAricles
            {
                ID = "2",
                NameType = "asdas",
                Type = "sdsda"
            };


            var Articles = new Article[]
            {
                new Article
                {
                    content="abcasdasdasdasd",
                    title="asdasdlkjasjldkasjlk",
                    IDArticles="1",
                    TypeAricles=TypeArticles
                }
            };
            context.Type.Add(TypeArticles);
            context.SaveChanges();
            context.Articles.Add(Articles[0]);
            context.SaveChanges();
        }
    }
}
