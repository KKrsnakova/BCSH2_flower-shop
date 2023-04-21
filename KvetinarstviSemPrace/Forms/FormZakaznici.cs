using KvetinarstviSemPrace.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KvetinarstviSemPrace.Forms
{
    public partial class FormZakaznici : Form
    {
        int selectedId;
        public FormZakaznici()
        {
            InitializeComponent();
            if (HlavniOkno.zaznamy.DejSeznamZakaznici() != null)
            {
                Nacti();
            }
        }

        public void Nacti()
        {
            foreach (Zakaznik item in HlavniOkno.zaznamy.DejSeznamZakaznici())
            {
                string[] zaznam = { item.Jmeno, item.Prijemni, "" + item.Adresa, "" + item.TelCislo, "" + item.Email };
                lvZakaznici.Items.Add(item.Id +"").SubItems.AddRange(zaznam);
            }
        }

        private void BtnPridet_Click(object sender, EventArgs e)
        {
            FormPridejZakaznika pridejZakaznika = new(null);
            pridejZakaznika.ShowDialog();
            lvZakaznici.Items.Clear();
            Nacti();
        }

        private void BtnOdebrat_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvZakaznici.SelectedItems[0].SubItems[0].Text);
                int odebrat = lvZakaznici.Items.IndexOf(lvZakaznici.SelectedItems[0]);
                Zakaznik zk = HlavniOkno.zaznamy.DejSeznamZakaznici().FirstOrDefault(objekt => objekt.Id == selectedId);
                HlavniOkno.zaznamy.OdeberZakaznika(odebrat);
                foreach (var objednavka in HlavniOkno.zaznamy.DejSeznamObjednavek().ToList())
                {
                    if (objednavka.ZakaznikID.Equals(zk.Id))
                    {
                        HlavniOkno.zaznamy.OdeberObjednavku(objednavka);
                    }
                }
                lvZakaznici.Items.Clear();
                Nacti();

            }
            else
            {
                string message = "Chyba";
                string title = "Není vybráno";
                MessageBox.Show(message, title);
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvZakaznici.SelectedItems[0].SubItems[0].Text);
                Zakaznik zakaznik = HlavniOkno.zaznamy.DejSeznamZakaznici().FirstOrDefault(objekt => objekt.Id == selectedId);
                Form editForm = new FormPridejZakaznika(zakaznik);
                editForm.ShowDialog();
                lvZakaznici.Items.Clear();
                Nacti();
            }
            else
            {
                MessageBox.Show("Chyba", "Není vybráno");
            }
        }

    }
}
