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
    public partial class FormObjednavky : Form
    {
        public FormObjednavky()
        {
            InitializeComponent();
            Nacti(lvObjednavky);
        }

        private void BtnPridet_Click(object sender, EventArgs e)
        {
            Form detailForm = new FormNovaObjednavka(null);
            detailForm.ShowDialog();
            lvObjednavky.Items.Clear();

            Nacti(lvObjednavky);
        }

        public static void Nacti(ListView lv)
        {
            lv.Items.Clear();
            foreach (Objednavka item in HlavniOkno.zaznamy.DejSeznamObjednavek())
            {
                Zakaznik zakaznik = HlavniOkno.zaznamy.DejZakaznikaPodleId(item.ZakaznikID);

                string[] zaznam = { zakaznik.Jmeno + " " + zakaznik.Prijemni, item.CenaObjednavky +"", item.DatumVytvoreni +""};
                lv.Items.Add(item.Id + "").SubItems.AddRange(zaznam);
            }
        }

    }

}
