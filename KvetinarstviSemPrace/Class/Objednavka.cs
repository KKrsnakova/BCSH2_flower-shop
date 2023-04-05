using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace
{
    public class Objednavka
    {
        public int Id{ get; set; }
        public int ZakaznikID { get; set; }
        public float CenaObjednavky { get; set; }
        public DateTime DatumVytvoreni { get; set; }
        public ObservableCollection<Zbozi> SeznamZbozi { get; set; }

        public bool Splneno { get; set; }
        public DateTime? DatumSplneni { get; set; }

        public Objednavka(int id, int zakaznikID, DateTime datumVytvoreni)
        {
            Id = id;
            ZakaznikID = zakaznikID;
            CenaObjednavky = 0;
            SeznamZbozi = new ObservableCollection<Zbozi>();
            DatumVytvoreni = datumVytvoreni;
            Splneno = false;
            DatumSplneni = null;
        }

        public void PridejZbozi(Zbozi zbozi)
        {
            SeznamZbozi.Add(zbozi);
        }

        public void OdeberZbozi(int index)
        {
            SeznamZbozi.Remove(SeznamZbozi[index]);
        }
    }
}
