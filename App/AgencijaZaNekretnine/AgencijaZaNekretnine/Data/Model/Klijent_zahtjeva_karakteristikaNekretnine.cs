using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Klijent_zahtjeva_karakteristikaNekretnine
    {
        public int klijentJMB { get; set; }
        public int idKarakteristikaNekretnine { get; set; }
        public string  dodatniOpis { get; set; }

        public Klijent_zahtjeva_karakteristikaNekretnine() { }
        public Klijent_zahtjeva_karakteristikaNekretnine(int klijentJMB, int idKarakteristikaNekretnine, string dodatniOpis)
        {
            this.klijentJMB = klijentJMB;
            this.idKarakteristikaNekretnine = idKarakteristikaNekretnine;
            this.dodatniOpis = dodatniOpis;
        }
    }
}
