using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectNou2
{
    public partial class FormProdus : Form
    {
        public Produse mFormProduse;
        public FormProdus(Produse p)
        {
            InitializeComponent();
            if (p == null) mFormProduse = new Produse();
            else
            {
                mFormProduse = p;
                textBoxDenumire.Text = mFormProduse.denumire;
                textBoxLot.Text = mFormProduse.nrLot.ToString();
                dateTimePickerf.Value = mFormProduse.dataFabricatiei;
                dateTimePickere.Value = mFormProduse.dataDeExpirare;
            }
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            mFormProduse.denumire = textBoxDenumire.Text;
            mFormProduse.nrLot = int.Parse(textBoxLot.Text);
            mFormProduse.dataFabricatiei = dateTimePickerf.Value;
            mFormProduse.dataDeExpirare = dateTimePickere.Value;
        }

        private void FormProdus_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDenumire.Text.Length < 5)
            {
                errorProvider1.SetError(textBoxDenumire,
                    "Denumirea este mai scurta de 5 caractere");
                e.Cancel = true;
            }
        }

        private void textBoxLot_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLot_Validating(object sender, CancelEventArgs e)
        {
            string text = "1234567890";
            bool containsOnlyDigits = Regex.IsMatch(textBoxLot.Text, @"^\d+$");

            if (!(containsOnlyDigits))
            {
                errorProvider1.SetError(textBoxLot,
                    "Lotul trebuie sa contina numai cifre!");
                e.Cancel = true;
            }
        }

        private void textBoxLot_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLot,"");
        }

        private void textBoxDenumire_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxDenumire,"");
        }
    }
}
