using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Hauser_WebProjekt.Models
{
    public class Anmeldung
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geschlecht { get; set; }
        public string Zusaetze { get; set; }
        public string EMail { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public int Alter { get; set; }
        public string Password { get; set; }

        public Anmeldung() : this("", "", "", "", "", null, 0, "") { }
        public Anmeldung(string vorname, string nachname, string geschlecht, string zusaetze, string email, DateTime? geburtsdatum, int alter, string password)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Geschlecht = geschlecht;
            this.Zusaetze = zusaetze;
            this.EMail = email;
            this.Geburtsdatum = geburtsdatum;
            this.Alter = alter;
            this.Password = password;
        }

        public override string ToString()
        {
            return this.Vorname + " " + this.Nachname + " " + this.EMail;
        }
    }
}
