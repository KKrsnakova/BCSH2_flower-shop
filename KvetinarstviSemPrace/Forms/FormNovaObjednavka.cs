using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KvetinarstviSemPrace.Forms
{
    public partial class FormNovaObjednavka : Form
    {
        int? indexZakaznika;
        bool pridano;
        Objednavka objednavka;
        int cena = 0;
        public FormNovaObjednavka(int? index)
        {
            InitializeComponent();
            pridano = false;
            indexZakaznika = index;
            cbJmenoPrijmeni.DataSource = HlavniOkno.zaznamy.DejSeznamZakaznici();

            Zakaznik zakaznik = cbJmenoPrijmeni.SelectedItem as Zakaznik;
            objednavka = new Objednavka(HlavniOkno.zaznamy.DejIdObjednavky(), zakaznik.Id, DateTime.Now);
            HlavniOkno.zaznamy.PridejObjednavku(objednavka);
        }

        private void BtnPridatDoSeznamu_Click(object sender, EventArgs e)
        {
            pridano = true;
            Form formZbozi = new FormZbozi(objednavka);
            formZbozi.ShowDialog();
            lvObjednavka.Items.Clear();
            foreach (Zbozi item in objednavka.SeznamZbozi)
            {
                lvObjednavka.Items.Add(item.Nazev);
            }
           cena = CenaObjednavky(objednavka);
            tbCena.Text = cena.ToString();

        }

        private void CbJmenoPrijmeni_SelectedIndexChanged(object sender, EventArgs e)
        {

            Zakaznik zakaznik = cbJmenoPrijmeni.SelectedItem as Zakaznik;
            tbJmenoPrijmeni.Text = zakaznik.Jmeno + " " + zakaznik.Prijemni;
            tbAdresa.Text = zakaznik.Adresa;
            tbTelCislo.Text = zakaznik.TelCislo.ToString();
            tbEmail.Text = zakaznik.Email.ToString();
        }

        private void BtnPridej_Click(object sender, EventArgs e)
        {
            if (pridano)
            {
                objednavka.CenaObjednavky = cena;
                Close();
            }
            else
            {
                MessageBox.Show("Chyba", "Nejsou přidané žádné položky");
            }
        }

        private int CenaObjednavky(Objednavka obj)
        {
            int cena = 0;
            foreach (var item in obj.SeznamZbozi)
            {
                cena += item.Cena;
            }
            return cena;
        }
    }
}
