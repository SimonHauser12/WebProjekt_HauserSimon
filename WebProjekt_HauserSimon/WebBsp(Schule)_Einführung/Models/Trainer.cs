using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Hauser_WebProjekt.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }

        public string Name { get; set; }

        public string Spezialisierung { get; set; }

        public decimal StundenPreis { get; set; }

        public Trainer() : this(0, "", "", 0.0m) { }
        public Trainer(int trainerID, string name, string spezialisierung, decimal stundenpreis)
        {
            this.TrainerID = trainerID;
            this.Name = name;
            this.Spezialisierung = spezialisierung;
            this.StundenPreis = stundenpreis;
        }

        public override string ToString()
        {
            return "Der Trainer mit der ID " + this.TrainerID + " (" + this.Name + ") ist spezialisiert auf " + this.Spezialisierung + " und kostet "+ this.StundenPreis + " Euro/h";
        }

    }
}
