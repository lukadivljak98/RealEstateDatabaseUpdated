using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class NekretninaIznajmljivanje :Nekretnina
    {
        public double predlozenaKirija { get; set; }
        public DateTime slobodnoOd { get; set; }
        public DateTime slobodnoDo { get; set; }
        public Boolean jeIznajmljena { get; set; }

        public NekretninaIznajmljivanje() { }
        public NekretninaIznajmljivanje(int idNekretnina, string brPoste, string adresa, string vlasnikJMB, double predlozenaKirija, DateTime slobodnoOd, DateTime slobodnoDo, bool jeIznajmljena)
            : base(idNekretnina, brPoste, adresa, vlasnikJMB)
        {
            this.predlozenaKirija = predlozenaKirija;
            this.slobodnoOd = slobodnoOd;
            this.slobodnoDo = slobodnoDo;
            this.jeIznajmljena = jeIznajmljena;
        }
    }
}
