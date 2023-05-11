using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Klijent : Osoba
    {
        public Klijent() { }
      
        public Klijent(string jMB, string ime, string prezime, string brTelefona, bool pol, string brPoste, string adresa) 
            : base(jMB, ime, prezime, brTelefona, pol, brPoste, adresa)
        {

        }
    }
}
