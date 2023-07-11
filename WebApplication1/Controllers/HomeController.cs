using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        DemoContext db;
        public HomeController(DemoContext context)
        {
            db = context;
        }
        
        //DemoContext db;
        public IActionResult Index()
        {
            return View(db.Manga.ToList());
        }

        public IActionResult Privacy()
        {
            /*List<Anime> users = new List<Anime>();

            using (var db = new DemoContext())
            {
                users = db.Manga.ToList();
            }

            ViewBag.users = users;*/

            return View();
        }

        [HttpPost]
        public IActionResult Privacy(Anime user)
        {
            /*using (var db = new DemoContext())
            {
                db.Add(user);
                db.SaveChanges();
            }
            List<Anime> users = new List<Anime>();

            using (var db = new DemoContext())
            {
                users = db.Manga.ToList();
            }

            ViewBag.users = users;*/

            return View();
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.MangaId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
