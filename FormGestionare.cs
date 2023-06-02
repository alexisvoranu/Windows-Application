using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectNou2
{
    public partial class FormGestionare : Form
    {

        public FormGestionare()
        {
            InitializeComponent();
        }

        private void FormGestionare_Load(object sender, EventArgs e)
        {
            this.gestionareTableAdapter.Fill(this.proiectNou2DataSet.Gestionare);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProiectNou2;Integrated Security=True;Pooling=False";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string query = "INSERT INTO Gestionare VALUES (@DenumireProdus, @Cantitate, @PretVanzare, @Furnizor)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cantitate", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@PretVanzare", double.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Furnizor", textBox3.Text); 
                cmd.Parameters.AddWithValue("@DenumireProdus", textBox4.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvarea a fist efectuata cu succes!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProiectNou2;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "Update Gestionare set DenumireProdus=@DenumireProdus, Cantitate=@Cantitate, PretVanzare=@PretVanzare, Furnizor=@Furnizor WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBoxId.Text));
            cmd.Parameters.AddWithValue("@Cantitate", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PretVanzare", double.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Furnizor", textBox3.Text);
            cmd.Parameters.AddWithValue("@DenumireProdus", textBox4.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Actualizarea a fost efectuata cu succes!");
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProiectNou2;Integrated Security=True;Pooling=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DenumireProdus, Cantitate, PretVanzare, Furnizor FROM Gestionare WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", int.Parse(textBoxId.Text));

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox4.Text = reader["DenumireProdus"].ToString();
                    textBox1.Text = reader["Cantitate"].ToString();
                    textBox2.Text = reader["PretVanzare"].ToString();
                    textBox3.Text = reader["Furnizor"].ToString();
                }

                else
                {
                    textBox4.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                }
                reader.Close();
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProiectNou2;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "Delete Gestionare WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBoxId.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Stergerea a fost efectuata cu succes!");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
