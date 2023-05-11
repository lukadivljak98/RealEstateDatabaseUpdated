using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class Posjeta
    {
        public int idPosjeta { get; set; }
        public DateTime datum { get; set; }
        public string klijentJMB { get; set; }
        public string agentJMB { get; set; }
        public int idNekretnina { get; set; }

        public Posjeta() { }
        public Posjeta(int idPosjeta, DateTime datum, string klijentJMB, string agentJMB, int idNekretnina)
        {
            this.idPosjeta = idPosjeta;
            this.datum = datum;
            this.klijentJMB = klijentJMB;
            this.agentJMB = agentJMB;
            this.idNekretnina = idNekretnina;
        }
    }
}
