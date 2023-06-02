using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectNou2
{
    public partial class UserControlLog : UserControl
    {
        public event EventHandler LoginSuccess;
        public UserControlLog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "pass")
            {
                // Autentificare cu succes
                OnLoginSuccess(EventArgs.Empty);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                // Autentificare eșuată
                MessageBox.Show("Autentificare eșuată. Numele de utilizator sau parola incorecte.");
            }
        }

        protected virtual void OnLoginSuccess(EventArgs e)
        {
            LoginSuccess?.Invoke(this, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
