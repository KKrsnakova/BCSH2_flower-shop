using KvetinarstviSemPrace.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KvetinarstviSemPrace.Forms
{
    public partial class FormPridejKvetinu : Form
    {
        Kvetina kvetina;
        public FormPridejKvetinu(Zbozi zb)
        {
            InitializeComponent();
            kvetina = (Kvetina)zb;
            cbDruhyKvetin.DataSource = Enum.GetValues(typeof(DruhyKvetin));

            if (kvetina != null)
            {
                tbNazev.Text = kvetina.Nazev;
                tbCena.Text = kvetina.Cena.ToString();
                tbPopis.Text = kvetina.Popis;
                cbDruhyKvetin.SelectedItem = kvetina.Druh;

            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            if (kvetina == null)
            {
                if (!String.IsNullOrEmpty(tbNazev.Text) && !String.IsNullOrEmpty(tbPopis.Text) &&
                    int.TryParse(tbCena.Text, out int cena))
                {

                    Kvetina kvetina = new(
                        HlavniOkno.zaznamy.DejIdZbozi(),
                        tbNazev.Text,
                        (DruhyKvetin)cbDruhyKvetin.SelectedItem,
                        cena, tbPopis.Text);

                    HlavniOkno.zaznamy.PridejZbozi(kvetina);
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
                    kvetina.Nazev = tbNazev.Text;
                    kvetina.Druh = (DruhyKvetin)cbDruhyKvetin.SelectedItem;
                    kvetina.Cena = cena;
                    kvetina.Popis = tbPopis.Text;
                    HlavniOkno.zaznamy.EditZbozi(kvetina.Id, kvetina);
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
