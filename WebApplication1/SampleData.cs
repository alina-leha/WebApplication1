using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1{
    public class SampleData 
    {
        public static void Initialize(DemoContext context)
        {
            if (!context.Manga.Any())
            {
                context.Manga.AddRange(
                    new Anime
                    {
                        img = "/img/1.jpg",
                        Name = "Игра героинь. Том 3",
                        Author = "Иори Табаса",
                        Price = 495
                    },
                    new Anime
                    {
                        img = "/img/2.jpeg",
                        Name = "Берсерк. Том 3.",
                        Author = "Кэнтаро Миура",
                        Price = 1245
                    },
                    new Anime
                    {
                        img = "/img/3.jpg",
                        Name = "Единственный конец злодейки - Смерть. Том 1",
                        Author = "Суволь и Квон Гёыль",
                        Price = 960
                    },
                    new Anime
                    {
                        img = "/img/4.jpg",
                        Name = "Императрица. Том 1",
                        Author = "Tutu",
                        Price = 900
                    },
                    new Anime
                    {
                        img = "/img/6.jpeg",
                        Name = "Франкенштейн",
                        Author = "Дзюндзи Ито",
                        Price = 840
                    },
                    new Anime
                    {
                        img = "/img/7.jpeg",
                        Name = "Нелюдь. Том 1.",
                        Author = "Гамон Сакураи и Цуйна Миура",
                        Price = 500
                    }
                 );
                context.SaveChanges();
            }
        }
     }
}