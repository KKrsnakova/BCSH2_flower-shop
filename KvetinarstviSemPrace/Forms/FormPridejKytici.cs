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
    public partial class FormPridejKytici : Form
    {
        Kytice kytice;
        public FormPridejKytici(Zbozi zb)
        {
            InitializeComponent();
            kytice = (Kytice)zb;

            if (kytice != null)
            {
                tbNazev.Text = kytice.Nazev;
                tbCena.Text = kytice.Cena.ToString();
                tbPopis.Text = kytice.Popis.ToString();
                numPocet.Value = kytice.PocetKvetin;
            }
        }

        private void BtnPridej_Click(object sender, EventArgs e)
        {
            if (kytice == null)
            {
                if (!String.IsNullOrEmpty(tbNazev.Text) && !String.IsNullOrEmpty(tbPopis.Text) &&
                    int.TryParse(tbCena.Text, out int cena))
                {
                    Kytice kytice = new
                (
                HlavniOkno.zaznamy.DejIdZbozi(),
                tbNazev.Text,
                cena,
                (int)numPocet.Value,
                tbPopis.Text
                );

                    HlavniOkno.zaznamy.PridejZbozi(kytice);
                    Close();
                }
                else
                {
                    MessageBox.Show("Chybně zadáno", "Chyba");

                }
                Close();
            }
            else
            {
                if (!String.IsNullOrEmpty(tbNazev.Text) && !String.IsNullOrEmpty(tbPopis.Text) &&
                    int.TryParse(tbCena.Text, out int cena))
                {
                    kytice.Nazev = tbNazev.Text;
                    kytice.Cena = cena;
                    kytice.PocetKvetin = (int)numPocet.Value;
                    kytice.Popis = tbPopis.Text;
                    HlavniOkno.zaznamy.EditZbozi(kytice.Id, kytice);
                }
                else
                {
                    MessageBox.Show("Chybně zadáno", "Chyba");
                }
                Close();
            }
        }

        private void BtnKonec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
