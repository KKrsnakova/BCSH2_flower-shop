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
        public FormPridejZakaznika()
        {
            InitializeComponent();
        }

        private void BtnPridej_Click(object sender, EventArgs e)
        {
            Console.WriteLine("pocet  " + HlavniOkno.zaznamy.DejSeznamZakaznici().Count);

            Console.WriteLine(":::");
            string jmeno = tbJmeno.Text;
            string prijmeni = tbPrijmeni.Text;
            string adresa = tbAdresa.Text;
            long telCislo = long.Parse(tbTelCislo.Text);
            string email = tbEmail.Text;
            int id = DejIdZakaznik();
            Zakaznik zakaznik = new(id, jmeno, prijmeni, adresa, telCislo, email);

            HlavniOkno.zaznamy.PridejZakaznika(zakaznik);

            Close();
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
