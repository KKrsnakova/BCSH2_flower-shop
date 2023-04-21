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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KvetinarstviSemPrace.Forms
{
    public partial class FormObjednavky : Form
    {
        int selectedId;
        Zakaznik vybranyZakaznik;
        public FormObjednavky()
        {
            InitializeComponent();

            lvObjednavky.Columns[0].TextAlign = HorizontalAlignment.Center;
            lvObjednavky.Columns[4].TextAlign = HorizontalAlignment.Center;
            lvObjednavky.Items.Clear();


            CbZakaznik.DataSource = HlavniOkno.zaznamy.DejSeznamZakaznici();
            CbFiltr.Checked = false;
            Nacti(lvObjednavky);

        }

        private void BtnPridet_Click(object sender, EventArgs e)
        {
            Form detailForm = new FormNovaObjednavka(null);
            detailForm.ShowDialog();
            lvObjednavky.Items.Clear();
            CbFiltr.Checked = false;
            Nacti(lvObjednavky);
        }

        public static void Nacti(System.Windows.Forms.ListView lv)
        {
            lv.Items.Clear();
            foreach (Objednavka item in HlavniOkno.zaznamy.DejSeznamObjednavek())
            {
                Zakaznik zakaznik = HlavniOkno.zaznamy.DejZakaznikaPodleId(item.ZakaznikID);
                string splneno = "\u2717";
                if (item.Splneno)
                {
                    splneno = "\u2713"; ;
                }

                string[] zaznam = { zakaznik.Jmeno + " " + zakaznik.Prijemni, item.CenaObjednavky + "", item.DatumVytvoreni + "", splneno, item.DatumSplneni + "" };
                lv.Items.Add(item.Id + "").SubItems.AddRange(zaznam);
            }
        }

        private void NactiSFiltrem(int idZakaznika, bool jizSplneno)
        {
            lvObjednavky.Items.Clear();
            foreach (Objednavka item in HlavniOkno.zaznamy.DejSeznamObjednavek())
            {
                if (item.ZakaznikID.Equals(idZakaznika) && jizSplneno && item.Splneno)
                {
                    Zakaznik zakaznik = HlavniOkno.zaznamy.DejZakaznikaPodleId(item.ZakaznikID);
                    string splneno = "\u2717";
                    if (item.Splneno)
                    {
                        splneno = "\u2713"; ;
                    }

                    string[] zaznam = { zakaznik.Jmeno + " " + zakaznik.Prijemni, item.CenaObjednavky + "", item.DatumVytvoreni + "", splneno, item.DatumSplneni + "" };
                    lvObjednavky.Items.Add(item.Id + "").SubItems.AddRange(zaznam);
                } else 
                {
                    if (item.ZakaznikID == idZakaznika && !jizSplneno)
                    {
                        Zakaznik zakaznik = HlavniOkno.zaznamy.DejZakaznikaPodleId(item.ZakaznikID);
                        string splneno = "\u2717";
                        if (item.Splneno)
                        {
                            splneno = "\u2713"; ;
                        }

                        string[] zaznam = { zakaznik.Jmeno + " " + zakaznik.Prijemni, item.CenaObjednavky + "", item.DatumVytvoreni + "", splneno, item.DatumSplneni + "" };
                        lvObjednavky.Items.Add(item.Id + "").SubItems.AddRange(zaznam);
                    }
                }

            }
        }

        private void BtnOdebrat_Click(object sender, EventArgs e)
        {
            if (lvObjednavky.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvObjednavky.SelectedItems[0].SubItems[0].Text);
                Objednavka objednavka = HlavniOkno.zaznamy.DejSeznamObjednavek().FirstOrDefault(objekt => objekt.Id == selectedId);

                HlavniOkno.zaznamy.OdeberObjednavku(objednavka);
                CbFiltr.Checked = false;
                lvObjednavky.Items.Clear();
                Nacti(lvObjednavky);
            }
            else
            {
                MessageBox.Show("Chyba", "Není vybráno");
            }
        }


        private void BtnSplneno_Click(object sender, EventArgs e)
        {
            if (lvObjednavky.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvObjednavky.SelectedItems[0].SubItems[0].Text);
                Objednavka objednavka = HlavniOkno.zaznamy.DejSeznamObjednavek().FirstOrDefault(objekt => objekt.Id == selectedId);
                if (!objednavka.Splneno)
                {
                    objednavka.Splneno = true;
                    objednavka.DatumSplneni = DateTime.Now;
                }
                else
                {
                    objednavka.Splneno = false;
                    objednavka.DatumSplneni = null;
                }
                lvObjednavky.Items.Clear();
                Nacti(lvObjednavky);
            }
            else
            {
                MessageBox.Show("Chyba", "Není vybráno");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvObjednavky.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvObjednavky.SelectedItems[0].SubItems[0].Text);

                Objednavka objednavka = HlavniOkno.zaznamy.DejSeznamObjednavek().FirstOrDefault(objekt => objekt.Id == selectedId);

                MessageBox.Show("Objednávka ID" + objednavka.Id+"" + " ||  selectedID: " +selectedId , "Nelze editovat");

                if (objednavka.Splneno)
                {
                    MessageBox.Show("Objednávka je již splněna", "Nelze editovat");
                }
                else
                {
                    Form editForm = new FormNovaObjednavka(objednavka);
                    editForm.ShowDialog();
                    lvObjednavky.Items.Clear();
                    Nacti(lvObjednavky);
                }
            }
            else
            {
                MessageBox.Show("Není vybráno", "Chyba");
            }
        }

        private void CbZakaznik_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CbFiltr.Checked && ChbSplneno.Checked)
            {
                vybranyZakaznik = CbZakaznik.SelectedItem as Zakaznik;
                int idZakaznika = vybranyZakaznik.Id;
                NactiSFiltrem(idZakaznika, ChbSplneno.Checked);
            } else
            {
                Nacti(lvObjednavky);
            }
        }

        private void CbFiltr_CheckedChanged(object sender, EventArgs e)
        {
            if (CbFiltr.Checked)
            {
                vybranyZakaznik = CbZakaznik.SelectedItem as Zakaznik;
                int idZakaznika = vybranyZakaznik.Id;
                NactiSFiltrem(idZakaznika, ChbSplneno.Checked);
               
            }
            else
            {
                Nacti(lvObjednavky);
            }
        }

        private void ChbSplneno_CheckedChanged(object sender, EventArgs e)
        {
            if (CbFiltr.Checked && CbFiltr.Checked)
            {
                vybranyZakaznik = CbZakaznik.SelectedItem as Zakaznik;
                int idZakaznika = vybranyZakaznik.Id;
                NactiSFiltrem(idZakaznika, ChbSplneno.Checked);

            }
            else
            {
                Nacti(lvObjednavky);
            }
        }
    }

}
