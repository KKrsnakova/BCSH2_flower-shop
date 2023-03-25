using KvetinarstviSemPrace.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace
{
    public class Kvetina :Zbozi
    {
        public DruhyKvetin Druh { get; set; }
        public string Popis { get; set; }

        public Kvetina( int id, string nazev, DruhyKvetin druh, int cena, string popis) :base(id, nazev, cena)
        {
            
            Druh = druh;
            Popis = popis;
        }
    }

}
