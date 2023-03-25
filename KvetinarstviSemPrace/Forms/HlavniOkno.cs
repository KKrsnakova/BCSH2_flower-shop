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

namespace KvetinarstviSemPrace
{
    public partial class HlavniOkno : Form
    {
        private Button aktButton;
        private Form aktivniForm;

        public static Zaznamy zaznamy = new();
        public static ZboziMng ZboziMng { get; set; }
        public static ZakaznikMng ZakaznikMng { get; set; }
        public static ObjednavkaMng ObjednavkyMng { get; set; }


        public HlavniOkno()
        {

            Repo repo = new();

            InitializeComponent();
            ZboziMng = new ZboziMng(repo);
            ZakaznikMng = new ZakaznikMng(repo);
            ObjednavkyMng = new ObjednavkaMng(repo);

            zaznamy.SetSeznamZbozi(ZboziMng.GetAllZbozi());

            zaznamy.SetSeznamZakaznici(ZakaznikMng.GetAllZakaznik());

            zaznamy.SetSeznamObjednavek(ObjednavkyMng.GetAllObjednavky());
        }


        private void Aktivni(object btnSender)
        {
            if (btnSender != null)
            {
                if (aktButton != (Button)btnSender)
                {
                    ZakazBtn();
                    Color color = ColorTranslator.FromHtml("#FEB8D0");
                    aktButton = (Button)btnSender;
                    aktButton.BackColor = color;
                    aktButton.ForeColor = Color.Black;
                }
            }
        }

        private void ZakazBtn()
        {
            foreach (Control predchButton in menuPanel.Controls)
            {
                if (predchButton.GetType() == typeof(Button))
                {
                    predchButton.BackColor = ColorTranslator.FromHtml("#FFEFEC");
                    predchButton.ForeColor = Color.Black;

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKytice(), sender);
        }

        private void BtnKvetiny_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKvetiny(), sender);
        }

        private void BtnObjednavky_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormObjednavky(), sender);
        }

        private void BtnProdej_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProdej(), sender);
        }

        private void BtnZakaznici_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormZakaznici(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (aktivniForm != null)
            {
                aktivniForm.Close();
            }
            Aktivni(btnSender);
            aktivniForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.hlavniPanel.Controls.Add(childForm);
            this.hlavniPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbNazev.Text = childForm.Text;
        }

        private void BtnUloz_Click(object sender, EventArgs e)
        {
            UlozitZaznamy();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lbDatum.Text = DateTime.Now.ToLongDateString();
            lbCas.Text = DateTime.Now.ToLongTimeString();
        }

        private void UlozitZaznamy()
        {
            ZakaznikMng.RemoveAllZakaznik();
            ZakaznikMng.AddAllZakaznik(zaznamy.DejSeznamZakaznici());

            ZboziMng.RemoveAllZbozi();
            ZboziMng.AddAllZbozi(zaznamy.DejSeznamZbozi());

            ObjednavkyMng.RemoveAllObjednavka();
            ObjednavkyMng.AddAllObjednavka(zaznamy.DejSeznamObjednavek());

            string message = "Uloženo";
            string title = "Záznamy byly uloženy";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HlavniOkno_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uložit záznamy?", "Potvrzení zavření", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UlozitZaznamy();
                Close();
            }
        }
    }
}
