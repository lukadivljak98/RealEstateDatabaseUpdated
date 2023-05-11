using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Mjesto
    {
        public string brPoste { get; set; }
        public string naziv { get; set; }

        public Mjesto() { }
        public Mjesto(string brPoste, string naziv)
        {
            this.brPoste = brPoste;
            this.naziv = naziv;
        }
    }
}
