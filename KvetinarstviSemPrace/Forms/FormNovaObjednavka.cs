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
        bool pridano;
        bool editace = false;
        readonly Objednavka objednavka;
        Zakaznik zakaznik;
        int cena = 0;
        Zakaznik zakaznikObjednavky;
        public FormNovaObjednavka(Objednavka obj)
        {

            InitializeComponent();
            pridano = false;

            cbJmenoPrijmeni.DataSource = HlavniOkno.zaznamy.DejSeznamZakaznici();

            zakaznik = cbJmenoPrijmeni.SelectedItem as Zakaznik;
            if (obj == null)
            {
                objednavka = new Objednavka(HlavniOkno.zaznamy.DejIdObjednavky(), zakaznik.Id, DateTime.Now);
            }
            else
            {
                btnPridej.Text = "Uložit";
                editace = true;
                objednavka = obj;

                foreach (var item in HlavniOkno.zaznamy.DejSeznamZakaznici())
                {
                    if (obj.ZakaznikID.Equals(item.Id))
                    {
                        zakaznikObjednavky = item;

                    }
                }
                ReadOnlyPrvky();

                tbJmenoPrijmeni.Text = zakaznikObjednavky.Prijemni + " " + zakaznikObjednavky.Jmeno;
                tbAdresa.Text = zakaznikObjednavky.Adresa;
                tbEmail.Text = zakaznikObjednavky.Email;
                tbTelCislo.Text = zakaznikObjednavky.TelCislo.ToString();

                Nacti();

                tbCena.Text = objednavka.CenaObjednavky.ToString();
            }

        }

        private void ReadOnlyPrvky()
        {
            cbJmenoPrijmeni.Visible = false;
            tbTelCislo.ReadOnly = true;
            tbJmenoPrijmeni.ReadOnly = true;
            tbEmail.ReadOnly = true;
            tbAdresa.ReadOnly = true;
            tbCena.ReadOnly = true;
        }

        private void BtnPridatDoSeznamu_Click(object sender, EventArgs e)
        {
            pridano = true;
            Form formZbozi = new FormZbozi(objednavka);
            formZbozi.ShowDialog();
            lvObjednavka.Items.Clear();

            Nacti();

            cena = CenaObjednavky(objednavka);
            tbCena.Text = cena.ToString();

        }

        private void CbJmenoPrijmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            zakaznik = cbJmenoPrijmeni.SelectedItem as Zakaznik;
            tbJmenoPrijmeni.Text = zakaznik.Jmeno + " " + zakaznik.Prijemni;
            tbAdresa.Text = zakaznik.Adresa;
            tbTelCislo.Text = zakaznik.TelCislo.ToString();
            tbEmail.Text = zakaznik.Email.ToString();
        }

        private void BtnPridej_Click(object sender, EventArgs e)
        {
            if (editace)
            {
                float cena = CenaObjednavky(objednavka);
                objednavka.CenaObjednavky = cena;
                HlavniOkno.zaznamy.EditObjednavka(objednavka.Id, objednavka);
                Close();
            }
            else
            {
                if (pridano)
                {
                    Zakaznik zk = cbJmenoPrijmeni.SelectedItem as Zakaznik;
                    objednavka.CenaObjednavky = cena;
                    objednavka.ZakaznikID = zk.Id;
                    HlavniOkno.zaznamy.PridejObjednavku(objednavka);
                    Close();
                }
                else
                {
                    MessageBox.Show("Chyba", "Nejsou přidané žádné položky");
                }
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

        private void btnOdeberZeSeznamu_Click(object sender, EventArgs e)
        {
            if (lvObjednavka.SelectedItems.Count > 0)
            {
                int selectedId = int.Parse(lvObjednavka.SelectedItems[0].SubItems[0].Text);
                Zbozi zb = objednavka.SeznamZbozi.FirstOrDefault(objekt => objekt.Id == selectedId);

                objednavka.SeznamZbozi.Remove(zb);
                zb.Id = HlavniOkno.zaznamy.DejIdZbozi();
                HlavniOkno.zaznamy.PridejZbozi(zb);
                Nacti();
            }
        }

        private void Nacti()
        {
            lvObjednavka.Items.Clear();
            foreach (var item in objednavka.SeznamZbozi)
            {
                string[] zaznam = { item.Nazev, item.Cena + " Kč" };
                lvObjednavka.Items.Add(item.Id.ToString()).SubItems.AddRange(zaznam);
            }
            tbCena.Text = objednavka.CenaObjednavky.ToString();
        }
    }
}
