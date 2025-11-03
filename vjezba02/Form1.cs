using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string imePrezime, mjestoRodjenja, vozackaDozvola, mobilni, spol, fakultet;
            DateTime datumRodjenja, danasnjiDatum;
            imePrezime = txtIme.Text;
            mjestoRodjenja = cbMjestoRodenja.SelectedItem.ToString();
            if (rbMusko.Checked)
                spol = "Musko";
            else
                spol = "Zensko";
            if (cbA.Checked==true)
                vozackaDozvola = "A ";
            else if(cbB.Checked==true)
                vozackaDozvola = "B ";
            else if (cbC.Checked==true)
                vozackaDozvola = "C ";
            else if (cbD.Checked==true)
                vozackaDozvola = "D ";
            else
                vozackaDozvola = "Nema vozacku dozvolu ";
            mobilni = mtbMobilni.Text;
            fakultet = lbFakultet.SelectedItem.ToString();
            datumRodjenja = dtpDatumRodenja.Value;
            danasnjiDatum = DateTime.Now;

            MessageBox.Show("Ime i prezime: " + imePrezime + "\n" +
                            "Mjesto rodjenja: " + mjestoRodjenja + "\n" +
                            "Spol: " + spol + "\n" +
                            "Vozacka dozvola: " + vozackaDozvola + "\n" +
                            "Mobilni: " + mobilni + "\n" +
                            "Fakultet: " + fakultet + "\n" +
                            "Datum rodjenja: " + datumRodjenja.ToShortDateString() + "\n" +
                            "Danasnji datum: " + danasnjiDatum.ToShortDateString());

        }
    }
}
