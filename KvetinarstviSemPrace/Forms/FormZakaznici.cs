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
    public partial class FormZakaznici : Form
    {
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
                string[] zaznam = { "" + item.Prijemni, "" + item.Adresa, "" + item.TelCislo, "" + item.Email };
                lvZakaznici.Items.Add(item.Jmeno).SubItems.AddRange(zaznam);
            }
        }

        private void BtnPridet_Click(object sender, EventArgs e)
        {
            FormPridejZakaznika pridejZakaznika = new();
            pridejZakaznika.ShowDialog();
            lvZakaznici.Items.Clear();
            Nacti();
        }

        private void BtnOdebrat_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count > 0)
            {
                int odebrat = lvZakaznici.Items.IndexOf(lvZakaznici.SelectedItems[0]);
                HlavniOkno.zaznamy.OdeberZakaznika(odebrat);
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

        private void LvZakaznici_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
