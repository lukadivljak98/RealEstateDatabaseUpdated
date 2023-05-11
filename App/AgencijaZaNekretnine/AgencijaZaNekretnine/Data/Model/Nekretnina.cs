using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Nekretnina
    {
        public int idNekretnina { get; set; }
        public string brPoste { get; set; }
        public string adresa { get; set; }
        public string vlasnikJMB { get; set; }

        public Nekretnina() { }
        public Nekretnina(int idNekretnina, string brPoste, string adresa, string vlasnikJMB)
        {
            this.idNekretnina = idNekretnina;
            this.brPoste = brPoste;
            this.adresa = adresa;
            this.vlasnikJMB = vlasnikJMB;
        }

        public Nekretnina(int idNekretnina)
        {
            this.idNekretnina = idNekretnina;
        }

        public override string ToString()
        {
            return idNekretnina + " " + brPoste + " " + adresa + " " + vlasnikJMB;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
