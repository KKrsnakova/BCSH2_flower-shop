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
    public partial class FormPridejZakaznika : Form
    {
        Zakaznik zakaznikEdit;
        public FormPridejZakaznika(Zakaznik zak)
        {
            InitializeComponent();
            zakaznikEdit = zak;
            if (zakaznikEdit != null)
            {
                tbJmeno.Text = zak.Jmeno;
                tbPrijmeni.Text = zak.Prijemni;
                tbAdresa.Text = zak.Adresa;
                tbTelCislo.Text = zak.TelCislo.ToString();
                tbEmail.Text = zak.Email;

            }
        }

        private void BtnPridej_Click(object sender, EventArgs e)
        {
            if (zakaznikEdit == null)
            {
                if (!String.IsNullOrEmpty(tbJmeno.Text) &&
                    !String.IsNullOrEmpty(tbPrijmeni.Text) &&
                    !String.IsNullOrEmpty(tbAdresa.Text) &&
                    !String.IsNullOrEmpty(tbEmail.Text) &&
                    long.TryParse(tbTelCislo.Text, out long telCislo))
                {

                    Zakaznik zakaznik = new(DejIdZakaznik(), tbJmeno.Text
                        , tbPrijmeni.Text, tbAdresa.Text, telCislo, tbEmail.Text);

                    HlavniOkno.zaznamy.PridejZakaznika(zakaznik);
                    Close();
                }
                else
                {
                    MessageBox.Show("Chybně zadáno", "Chyba");
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(tbJmeno.Text) &&
                    !String.IsNullOrEmpty(tbPrijmeni.Text) &&
                    !String.IsNullOrEmpty(tbAdresa.Text) &&
                    !String.IsNullOrEmpty(tbEmail.Text) &&
                    long.TryParse(tbTelCislo.Text, out long telCislo))
                {
                    zakaznikEdit.Jmeno= tbJmeno.Text;
                    zakaznikEdit.Prijemni= tbPrijmeni.Text;
                    zakaznikEdit.Adresa = tbAdresa.Text;
                    zakaznikEdit.Email = tbEmail.Text;
                    zakaznikEdit.TelCislo = telCislo;
                    HlavniOkno.zaznamy.EditZakaznika(zakaznikEdit.Id, zakaznikEdit);
                }
                else
                {
                    MessageBox.Show("Chybně zadáno", "Chyba");
                }
                Close();
            }


        }

        private int DejIdZakaznik()
        {
            int pocet = HlavniOkno.zaznamy.DejSeznamZakaznici().Count;
            foreach (var item in HlavniOkno.zaznamy.DejSeznamZakaznici())
            {
                Console.WriteLine(item.Id + "");
                if (item.Id == pocet)
                {
                    pocet++;
                }
            }
            return pocet;
        }


        private void BtnKonec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
