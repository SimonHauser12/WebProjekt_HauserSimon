using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Hauser_WebProjekt.Models
{
    public class Artikel
    {
        public int ArtikelID { get; set; }

        public string ArtikelName { get; set; }

        public decimal Preis { get; set; }

        public string Beschreibung { get; set; }

        public Artikel() : this(0, "", 0.0m, "") { }
        public Artikel(int id, string name, decimal preis, string beschreibung)
        {
            this.ArtikelID = id;
            this.ArtikelName = name;
            this.Preis = preis;
            this.Beschreibung = beschreibung;
        }

        public override string ToString()
        {
            return "Der Artikel mit der ID "+ this.ArtikelID + " (" + this.ArtikelName + ") kostet " + this.Preis + " Euro";
        }
    }
}
