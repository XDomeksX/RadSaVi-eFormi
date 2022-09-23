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
    public partial class FormUnosNovogStudenta : Form
    {
        private Student student1;
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void FormUnosNovogStudenta_Load(object sender, EventArgs e)
        {

        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            // kreiranje novog objekta tipa Student

            student1 = new Student();

            // pristup odgovarajucim atrubutima klase Student

            student1.Ime = textBoxIme.Text;

            student1.Prezime = textBoxPrezime.Text;

            student1.BrojIndeksa = textBoxBrojIndeksa.Text;

            student1.Smjer = comboBoxSmjer.SelectedItem.ToString();

            student1.DatumRodjenja =
            dateTimePickerDatumRodjenja.Value;

            DialogResult = DialogResult.OK;
        }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
