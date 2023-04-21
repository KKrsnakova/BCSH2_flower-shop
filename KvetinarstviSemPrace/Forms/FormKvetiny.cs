using KvetinarstviSemPrace.Class;
using KvetinarstviSemPrace.Manager;
using KvetinarstviSemPrace.Repository;
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

namespace KvetinarstviSemPrace.Forms
{
    public partial class FormKvetiny : Form
    {

        int selectedId;
        public FormKvetiny()
        {
            InitializeComponent();

            if (HlavniOkno.zaznamy.DejSeznamZbozi() != null)
            {
                Nacti(lvKvetiny);
            }
        }

        private void BtnPridet_Click(object sender, EventArgs e)
        {
            FormPridejKvetinu pridejKvetinu = new(null);
            pridejKvetinu.ShowDialog();
            lvKvetiny.Items.Clear();
            Nacti(lvKvetiny);
        }


        private void BtnOdebrat_Click(object sender, EventArgs e)
        {
            if (lvKvetiny.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvKvetiny.SelectedItems[0].SubItems[0].Text);
                Zbozi zbozi = HlavniOkno.zaznamy.DejSeznamZbozi().FirstOrDefault(objekt => objekt.Id == selectedId);

                HlavniOkno.zaznamy.OdeberZbozi(zbozi);
                lvKvetiny.Items.Clear();
                Nacti(lvKvetiny);

            }
            else
            {
                MessageBox.Show("Chyba", "Není vybráno");
            }
        }

        public static void Nacti(ListView lv)
        {
            foreach (Zbozi kvetina in HlavniOkno.zaznamy.DejSeznamZbozi())
            {
                if (kvetina is Kvetina item)
                {
                    string[] zaznam = { item.Nazev, DruhyKvetinInfo.DejNazevDruhu(item.Druh), item.Cena + " Kč", "" + item.Popis };
                    lv.Items.Add(item.Id + "").SubItems.AddRange(zaznam);
                }

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvKvetiny.SelectedItems.Count > 0)
            {
                selectedId = int.Parse(lvKvetiny.SelectedItems[0].SubItems[0].Text);
                Zbozi zbozi = HlavniOkno.zaznamy.DejSeznamZbozi().FirstOrDefault(objekt => objekt.Id == selectedId);
                Form editForm = new FormPridejKvetinu(zbozi);
                editForm.ShowDialog();
                lvKvetiny.Items.Clear();
                Nacti(lvKvetiny);
            }
            else
            {
                MessageBox.Show("Chyba", "Není vybráno");
            }
        }

    }
}
