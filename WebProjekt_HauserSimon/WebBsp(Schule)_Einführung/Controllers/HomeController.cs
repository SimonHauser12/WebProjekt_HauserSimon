using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hauser_WebProjekt.Models;

namespace Hauser_WebProjekt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Anbieterkennzeichnung()
        {
            return View();
        }

        public IActionResult UeberUns()
        {
            return View();
        }

        public IActionResult Trainer()
        {
            return View(CreateArticleList());
        }

        private List<Trainer> CreateArticleList()
        {
            return new List<Trainer>()
            {
                new Trainer(1, "Franz Müller", "Kraft- und Ausdauersport", 12.90m),
                new Trainer(2, "Christof Klein", "Ernährung(Kraftsport)", 10.50m),
                new Trainer(3, "Maria Huber", "rythmische Sportgymnastik", 8.90m),
                new Trainer(4, "Günther Einstein", "Ernährung(Ausdauersport)", 10.50m),
                new Trainer(5, "Max Post", "Kraft- und Ausdauersport", 12.90m),
                new Trainer(6, "Lea Haus", "Kraft- und Ausdauersport", 9.50m),
            };
        }
    }
}