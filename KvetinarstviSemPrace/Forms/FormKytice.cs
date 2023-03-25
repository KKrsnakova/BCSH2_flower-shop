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
    public partial class FormKytice : Form
    {
        int selectedId;
        public FormKytice()
        {
            InitializeComponent();

            if (HlavniOkno.zaznamy.DejSeznamZbozi() != null)
            {
                Nacti(lvKytice);
            }
        }

        public static void Nacti(ListView lv)
        {
            foreach (Zbozi kytice in HlavniOkno.zaznamy.DejSeznamZbozi())
            {
                if (kytice is Kytice item)
                {
                    string[] zaznam = { item.Nazev, "" + item.PocetKvetin, "" + item.Cena, "" + item.Popis };
                    lv.Items.Add(item.Id + "").SubItems.AddRange(zaznam);


                }
            }
        }

        private void BtnPridet_Click(object sender, EventArgs e)
        {
            FormPridejKytici pridejKytici = new(null);
            pridejKytici.ShowDialog();
            lvKytice.Items.Clear();
            Nacti(lvKytice);
        }

        private void BtnOdebrat_Click(object sender, EventArgs e)
        {
            if (lvKytice.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvKytice.SelectedItems[0].SubItems[0].Text);
                Zbozi zbozi = HlavniOkno.zaznamy.DejSeznamZbozi().FirstOrDefault(objekt => objekt.Id == selectedId);

                HlavniOkno.zaznamy.OdeberZbozi(zbozi);
                lvKytice.Items.Clear();
                Nacti(lvKytice);

            }
            else
            {
                MessageBox.Show("Není vybráno", "Chyba");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvKytice.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvKytice.SelectedItems[0].SubItems[0].Text);
                Zbozi zbozi = HlavniOkno.zaznamy.DejSeznamZbozi().FirstOrDefault(objekt => objekt.Id == selectedId);
                Form editForm = new FormPridejKytici(zbozi);
                editForm.ShowDialog();
                lvKytice.Items.Clear();
                Nacti(lvKytice);
            }
            else
            {
                MessageBox.Show("Není vybráno", "Chyba");
            }
        }
    }
}
