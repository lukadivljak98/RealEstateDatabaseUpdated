using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Agent : Osoba
    {
        public double plata { get; set; }
        public int idAgencija { get; set; }

        public Agent() { }
        public Agent(string jMB, string ime, string prezime, string brTelefona, bool pol, string brPoste, string adresa, double plata, int idAgencija)
            : base(jMB, ime, prezime, brTelefona, pol, brPoste, adresa)
        {
            this.plata = plata;
            this.idAgencija = idAgencija;
        }
    }
}
