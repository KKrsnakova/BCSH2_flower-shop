using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace
{
    public class Kytice : Zbozi
    {
        public int PocetKvetin { get; set; }
        public string Popis { get; set; }

        

        public Kytice(int id, string nazev, int cena, int pocetKvetin, string popis): base(id, nazev, cena)
        {
            PocetKvetin = pocetKvetin;
            Popis = popis;
        }
    }
}

