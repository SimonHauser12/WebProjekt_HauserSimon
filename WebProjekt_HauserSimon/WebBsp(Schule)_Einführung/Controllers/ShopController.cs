using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hauser_WebProjekt.Models;

namespace Hauser_WebProjekt.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Ruecksendungen()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(CreateArticleList());
        }

        public IActionResult Bilder()
        {
            return View();
        }

        private List<Artikel> CreateArticleList()
        {
            return new List<Artikel>()
            {
                new Artikel(1, "Whey Proteinpulver", 25.90m, "für optimalen Muskelaufbau"),
                new Artikel(2, "Creatin Monohydrat", 12.90m, "zur Kraftsteigerung und Muskelvergrößerung"),
                new Artikel(3, "Multi PRZ", 5.70m, "Vitamine und Minerale"),
                new Artikel(4, "Omega 3 Kapseln", 3.99m, "für einen gesunden Lebensstil"),
                new Artikel(5, "Magnesium Pulver", 4.50m, "zum auffüllen der Magnesiumspeicher nach hartem Training"),
                new Artikel(6, "Big Shot Booster", 8.99m, "Motivationsschub für unmotivierte Tage"),
                new Artikel(7, "Kurzhantel 20kg", 35.50m, "für Anfänger"),
                new Artikel(8, "Kurzhantel 30kg", 40.50m, "für Fortgeschrittene"),
                new Artikel(9, "Langhantel 60kg", 50.95m, "ideal zum Bankdrücken, sollte in Verbindung mit Handelbank gekauft werden"),
                new Artikel(10, "Hantelbank", 45.80m, "universal Hantelbank für Hometraining"),
            };
        }
    }
}