using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class KarakteristikaNekretnine
    {
        public int idKarakteristikaNekretnine { get; set; }
        public string naziv { get; set; }

        public KarakteristikaNekretnine() { }
        public KarakteristikaNekretnine(int isKarakteristikaNekretnine, string naziv)
        {
            this.idKarakteristikaNekretnine = idKarakteristikaNekretnine;
            this.naziv = naziv;
        }
    }
}
