using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace
{
    public class Zbozi
    {
        public Zbozi(int id, string nazev, int cena)
        {
            Id = id;
            Nazev = nazev;
            Cena = cena;
        }

        public int Id { get; set; }
        public String Nazev { get; set; }
        public int Cena { get; set; }
    }
}
