using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Agencija
    {
        public int idAgencija { get; set; }
        public string naziv { get; set; }
        public string brTelefona { get; set; }
        public string adresa { get; set; }
        public string brPoste { get; set; }

        public Agencija() { }
        public Agencija(int idAgencija, string naziv, string brTelefona, string adresa, string brPoste)
        {
            this.idAgencija = idAgencija;
            this.naziv = naziv;
            this.brTelefona = brTelefona;
            this.adresa = adresa;
            this.brPoste = brPoste;
        }
    }
}
