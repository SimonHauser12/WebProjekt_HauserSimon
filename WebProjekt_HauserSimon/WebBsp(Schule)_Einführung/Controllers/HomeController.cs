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

        public IActionResult NeueAnmeldung()
        {
            return View();
        }

        public IActionResult Anmeldung(Anmeldung a)
        {
            return View(CreateRegisterList(a));
        }

        /*private void DatenCheck(Anmeldung a)
        {
            if (a == null)
            {
                return;
            }

            a.Vorname = a.Vorname ?? "";
            a.Nachname = a.Nachname ?? "";
            a.Geschlecht = a.Geschlecht ?? "";
            a.Zusaetze = a.Zusaetze ?? "";
            a.EMail = a.EMail ?? "";
            a.Geburtsdatum = a.Geburtsdatum ?? null;
            a.Password = a.Password ?? "";

            
            if ((a.Vorname.Length < 3)||(a.Nachname.Length < 3))
            {
                ModelState.AddModelError(nameof(a.Nachname), "Vor- und Nachname müssen mind. 3 Zeichen lang sein!");
            }
            
            if (a.Geburtsdatum > new DateTime(2020, 1, 1))
            {
                ModelState.AddModelError(nameof(a.Geburtsdatum), "Geburtsdatum muss kleiner als 1.1.2020 sein!");
            }

            if (a.Alter < 0)
            {
                ModelState.AddModelError(nameof(a.Alter), "Alter darf nicht kleiner als 0 sein!");
            }

            if (a.Password.Length < 6)
            {
                ModelState.AddModelError(nameof(a.Password), "Das PW muss mind. 6 Zeichen lang sein!");
            }
        }*/

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

        private List<Anmeldung> CreateRegisterList(Anmeldung a)
        {
            return new List<Anmeldung>()
            {
                new Anmeldung(a.Vorname, a.Nachname, a.Geschlecht, a.Zusaetze, a.EMail, a.Geburtsdatum, a.Alter, a.Password),
            };
        }
    }
}