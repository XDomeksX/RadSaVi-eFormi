using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaVišeFormi
{
    public partial class FormStudenti : Form
    {
        public FormStudenti()
        {
            InitializeComponent();
        }
        public class Student
        {
            private string ime;
            private string prezime;
            private string brojIndeksa;
            private DateTime datumRodjenja;
            private string smjer;

            public Student()
            {

            }
            public string Ime
            {
                get { return ime; }
                set { ime = value; }
            }
            public string Prezime
            {
                get { return prezime; }
                set { prezime = value; }
            }
            public string BrojIndeksa
            {
                get { return brojIndeksa; }
                set { brojIndeksa = value; }
            }
            public DateTime DatumRodjenja
            {
                get { return datumRodjenja; }
                set { datumRodjenja = value; }
            }
            public string Smjer
            {
                get { return smjer; }
                set { smjer = value; }
            }
            public override string ToString()
            {
                return ime + " " + prezime + " " +
                brojIndeksa + " " +
                datumRodjenja.ToShortDateString() + " " + smjer;
            }
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();

            DialogResult rez = frm.ShowDialog();

            // unos novog studenta u listBox

            if (rez == System.Windows.Forms.DialogResult.OK)
            {
                listBoxStudenti.Items.Add(frm.Student1.ToString());
            }
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))
            {
                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
            }
        }
    }
}
