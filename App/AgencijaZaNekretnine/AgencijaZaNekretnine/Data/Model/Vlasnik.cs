using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Vlasnik : Osoba
    {

        public Vlasnik() { }
        public Vlasnik(string jMB, string ime, string prezime, string brTelefona, bool pol, string brPoste, string adresa)
            : base(jMB, ime, prezime, brTelefona, pol, brPoste, adresa)
        {

        }
    }
}
