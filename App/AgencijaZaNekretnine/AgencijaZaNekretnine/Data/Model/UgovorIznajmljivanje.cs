using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Model
{
    public class UgovorIznajmljivanje
    {
        public int idUgovorIznajmljivanje { get; set; }
        public string klijentJMB { get; set; }
        public string agentJMB { get; set; }
        public double kirija { get; set; }
        public DateTime datum { get; set; }
        public string opis { get; set; }
        public double depozit { get; set; }
        public int minimalanPeriodIznajmljivanja { get; set; }
        public int idNekretnina { get; set; }

        public UgovorIznajmljivanje() { }
        public UgovorIznajmljivanje(int idUgovorIznajmljivanje, string klijentJMB, string agentJMB, double kirija, DateTime datum, 
                                    string opis, double depozit, int minimalanPeriodIznajmljivanja, int idNekretnina)
        {
            this.idUgovorIznajmljivanje = idUgovorIznajmljivanje;
            this.klijentJMB = klijentJMB;
            this.agentJMB = agentJMB;
            this.kirija = kirija;
            this.datum = datum;
            this.opis = opis;
            this.depozit = depozit;
            this.minimalanPeriodIznajmljivanja = minimalanPeriodIznajmljivanja;
            this.idNekretnina = idNekretnina;
        }
    }
}
