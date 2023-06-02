using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectNou2
{
    public partial class FormFisaCosnum : Form
    {
        public FisaConsum mFormFisa;
        public FormFisaCosnum(FisaConsum f)
        {
            InitializeComponent();
            if (f == null) mFormFisa = new FisaConsum();
            else
            {
                mFormFisa = f;
                textBoxProportie.Text = mFormFisa.proportie.ToString();
                textBoxMaterie.Text = mFormFisa.materiePrima;
            }

        }

        private void FormFisaCosnum_Load(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            mFormFisa.proportie = int.Parse(textBoxProportie.Text);
            mFormFisa.materiePrima = textBoxMaterie.Text;
        }

        private void textBoxProportie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProportie_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(textBoxProportie.Text) < 0 || int.Parse(textBoxProportie.Text) > 100)
            {
                errorProvider1.SetError(textBoxProportie, "Proportia este cuprinsa intre 0 si 100");
                e.Cancel = true;
            }
        }

        private void textBoxMaterie_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            textBoxMaterie.Text = data;

            if (e.Effect == DragDropEffects.Move)
            {
                listBox1.Items.Remove(data);
            }
        }

        private void textBoxMaterie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaterie_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = e.AllowedEffect;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItems.Count > 0)
            {
                lb.DoDragDrop(lb.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void textBoxMaterie_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxProportie_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxProportie, "");
        }
    }
}
