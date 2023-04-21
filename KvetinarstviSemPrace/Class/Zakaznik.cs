using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijemni { get; set; }
        public string Adresa { get; set; }
        public long TelCislo { get; set; }
        public string Email { get; set; }


        public Zakaznik(int id, string jmeno, string prijemni, string adresa, long telCislo, string email)
        {
            Id = id;
            Jmeno = jmeno;
            Prijemni = prijemni;
            Adresa = adresa;
            TelCislo = telCislo;
            Email = email;
        }

        public override string ToString()
        {
            return Jmeno.ToString() + " " + Prijemni.ToString() + " " + Adresa.ToString() + " " + TelCislo.ToString() + " " + Email.ToString();
        }

        public string ToStringJmenoPrijmeni()
        {
            return Jmeno.ToString() + " " + Prijemni.ToString();
        }


    }

}
