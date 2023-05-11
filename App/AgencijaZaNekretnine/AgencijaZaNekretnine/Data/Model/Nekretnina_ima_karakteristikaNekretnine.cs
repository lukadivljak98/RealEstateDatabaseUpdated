using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Nekretnina_ima_karakteristikaNekretnine
    {
        public int idNekretnina { get; set; }
        public int idKarakteristikaNekretnine { get; set; }
        public string dodatniOpis { get; set; }

        public Nekretnina_ima_karakteristikaNekretnine() { }
        public Nekretnina_ima_karakteristikaNekretnine(int idNekretnina, int idKarakteristikaNekretnine, string dodatniOpis)
        {
            this.idNekretnina = idNekretnina;
            this.idKarakteristikaNekretnine = idKarakteristikaNekretnine;
            this.dodatniOpis = dodatniOpis;
        }
    }
}
