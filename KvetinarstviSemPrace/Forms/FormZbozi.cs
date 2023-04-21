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

namespace KvetinarstviSemPrace.Forms
{
    public partial class FormZbozi : Form
    {
        Objednavka objednaka;
        public FormZbozi(Objednavka obj)
        {
            InitializeComponent();
            FormKvetiny.Nacti(lvZbozi);
            FormKytice.Nacti(lvZbozi);
            objednaka = obj;
        }


        private void LvZbozi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZbozi.SelectedItems.Count > 0)
            {
                int selectedId = int.Parse(lvZbozi.SelectedItems[0].SubItems[0].Text);
                Zbozi zb = HlavniOkno.zaznamy.DejSeznamZbozi().FirstOrDefault(objekt => objekt.Id == selectedId);


                if (zb is Kvetina)
                {
                    HlavniOkno.zaznamy.OdeberZbozi(zb);
                    objednaka.PridejZbozi(zb);
                }
                if (zb is Kytice)
                {
                    HlavniOkno.zaznamy.OdeberZbozi(zb);
                    objednaka.PridejZbozi(zb);
                }

                Close();

            }
        }

        
    }
}
