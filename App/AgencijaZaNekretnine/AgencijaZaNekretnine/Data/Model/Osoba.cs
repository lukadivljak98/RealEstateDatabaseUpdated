using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Osoba
    {
        public string JMB { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string brTelefona { get; set; }
        public Boolean pol { get; set; }
        public string brPoste { get; set; }
        public string adresa { get; set; }

        public Osoba() { }

        public Osoba(string jMB, string ime, string prezime, string brTelefona, bool pol, string brPoste, string adresa)
        {
            JMB = jMB;
            this.ime = ime;
            this.prezime = prezime;
            this.brTelefona = brTelefona;
            this.pol = pol;
            this.brPoste = brPoste;
            this.adresa = adresa;
        }

    }
}
