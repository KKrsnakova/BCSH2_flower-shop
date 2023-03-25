using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KvetinarstviSemPrace
{
    public class Zaznamy
    {
        public static ObservableCollection<Zakaznik> seznamZakaznici;
        public static ObservableCollection<Objednavka> seznamObjednavek;
        public static ObservableCollection<Zbozi> seznamZbozi;


        public Zaznamy()
        {
            seznamZakaznici = new ObservableCollection<Zakaznik>();
            seznamObjednavek = new ObservableCollection<Objednavka>();
            seznamZbozi = new ObservableCollection<Zbozi>();
        }


        public void PridejZakaznika(Zakaznik zakaznik)
        {
            seznamZakaznici.Add(zakaznik);
        }

        public void PridejObjednavku(Objednavka objednavka)
        {
            seznamObjednavek.Add(objednavka);
        }
        public void PridejZbozi(Zbozi zbozi)
        {
            seznamZbozi.Add(zbozi);
        }

        // vrat seznam
        public ObservableCollection<Zakaznik> DejSeznamZakaznici() { return seznamZakaznici; }
        public ObservableCollection<Objednavka> DejSeznamObjednavek() { return seznamObjednavek; }
        public ObservableCollection<Zbozi> DejSeznamZbozi() { return seznamZbozi; }
        


        // dej další id

        public int DejIdZakaznik()
        {
            int pocet;
            if (HlavniOkno.zaznamy.DejSeznamZakaznici().Count() == 0)
            {
                pocet = 1;
            }
            else
            {
                pocet = HlavniOkno.zaznamy.DejSeznamZakaznici().Last().Id;
                pocet++;
            }


            return pocet;
        }

        public int DejIdObjednavky()
        {
            int pocet;
            if (HlavniOkno.zaznamy.DejSeznamObjednavek().Count() == 0)
            {
                pocet = 1;
            }
            else
            {
                pocet = HlavniOkno.zaznamy.DejSeznamObjednavek().Last().Id;
                pocet++;
            }


            return pocet;
        }

        public int DejIdZbozi()
        {
            int pocet;
            if (HlavniOkno.zaznamy.DejSeznamZbozi().Count() == 0)
            {
                pocet = 1;
            }
            else
            {
                pocet = HlavniOkno.zaznamy.DejSeznamZbozi().Last().Id;
                pocet++;
            }


            return pocet;
        }

        public void OdeberZakaznika(int id)
        {
            seznamZakaznici.RemoveAt(id);
        }
        public void OdeberZbozi(Zbozi zbozi)
        {
            seznamZbozi.Remove(zbozi);
        }

        //nastav seznam
      
        public void SetSeznamZakaznici(ObservableCollection<Zakaznik> list)
        {
            seznamZakaznici = list;
        }
        public void SetSeznamZbozi(ObservableCollection<Zbozi> list)
        {
            seznamZbozi = list;
        }
        public void SetSeznamObjednavek(ObservableCollection<Objednavka> list)
        {
            seznamObjednavek = list;
        }

        //dej podle id

        public Zakaznik DejZakaznika(int index)
        {
            return seznamZakaznici[index];

        }

        public Objednavka DejObjednavku(int index)
        {
            return seznamObjednavek[index];
        }
        public Zbozi DejZbozi(int index)
        {
            return seznamZbozi[index];
        }

        //edituj 
      

        public void EditZbozi(int id, Zbozi zbozi)
        {
            for (int i = 0; i < seznamZbozi.Count; i++)
            {
                MessageBox.Show("Chyba", seznamZbozi[i].Id+"");
                if (seznamZbozi[i].Equals(id))
                {
                    MessageBox.Show("v ifu editacš " +id);
                    seznamZbozi[i] = zbozi;
                }
            }
            
        }

        //dejPodleID
        public Zakaznik DejZakaznikaPodleId(int id)
        {
            Zakaznik vratZakaznika = null;
            foreach (Zakaznik zakaznik in seznamZakaznici)
            {
                if (zakaznik.Id.Equals(id))
                {
                    vratZakaznika = zakaznik;
                }
                
            }
            return vratZakaznika;
        }
    }
}
