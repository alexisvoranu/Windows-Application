using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectNou2
{
    public partial class Form1 : Form
    {
        int pagcurenta;
        private bool isLoggedIn = false;
        public Form1()
        {
            InitializeComponent();
            Produse p1 = new Produse("Fresh de portocale", new DateTime(2023, 5, 27, 14, 30, 0), new DateTime(2023, 6, 9, 14, 30, 0), 82367451);
            FisaConsum f1 = new FisaConsum("Portocale", 100);
            p1.adauga(f1);

            treeView1.Nodes.Add(p1.denumire);
            treeView1.Nodes[0].Nodes.Add(p1.dataFabricatiei.ToString("dd.MM.yyyy"));
            treeView1.Nodes[0].Nodes.Add(p1.dataDeExpirare.ToString("dd.MM.yyyy"));
            treeView1.Nodes[0].Nodes.Add(p1.nrLot.ToString());
            foreach (string c in p1.compozitii)
                treeView1.Nodes[0].Nodes.Add(c);
            treeView1.Nodes[0].Tag = p1;


            Produse p2 = new Produse("Fresh de portocale si mere", new DateTime(2023, 5, 26, 10, 15, 0), new DateTime(2023, 6, 8, 10, 15, 0), 82363461);
            FisaConsum f2 = new FisaConsum("Portocale", 50);
            FisaConsum f3 = new FisaConsum("Mere", 50);
            p2.adauga(f2);
            p2.adauga(f3);

            treeView1.Nodes.Add(p2.denumire);
            treeView1.Nodes[1].Nodes.Add(p2.dataFabricatiei.ToString("dd.MM.yyyy"));
            treeView1.Nodes[1].Nodes.Add(p2.dataDeExpirare.ToString("dd.MM.yyyy"));
            treeView1.Nodes[1].Nodes.Add(p2.nrLot.ToString());
            foreach (string c in p2.compozitii)
                treeView1.Nodes[1].Nodes.Add(c);
            treeView1.Nodes[1].Tag = p2;

            Produse p3 = new Produse("Fresh de portocale, mere si grapefruit", new DateTime(2023, 5, 28, 18, 35, 0), new DateTime(2023, 6, 10, 18, 35, 0), 82368615);
            FisaConsum f4 = new FisaConsum("Portocale", 34);
            FisaConsum f5 = new FisaConsum("Mere", 33);
            FisaConsum f6 = new FisaConsum("Grapefruit", 33);
            p3.adauga(f4);
            p3.adauga(f5);
            p3.adauga(f6);


            treeView1.Nodes.Add(p3.denumire);
            treeView1.Nodes[2].Nodes.Add(p3.dataFabricatiei.ToString("dd.MM.yyyy"));
            treeView1.Nodes[2].Nodes.Add(p3.dataDeExpirare.ToString("dd.MM.yyyy"));
            treeView1.Nodes[2].Nodes.Add(p3.nrLot.ToString());
            foreach (string c in p3.compozitii)
                treeView1.Nodes[2].Nodes.Add(c);
            treeView1.Nodes[2].Tag = p3;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void textBoxf_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes.Contains(treeView1.SelectedNode))
            {
                textBoxf.Text = treeView1.SelectedNode.Nodes[0].Text;
                textBoxe.Text = treeView1.SelectedNode.Nodes[1].Text;
                textBoxl.Text = treeView1.SelectedNode.Nodes[2].Text;
            }
        }


        private void salveazaDateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisiere fresh-uri *.xml|*.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Produse> lista = new List<Produse>();
                foreach (TreeNode t in treeView1.Nodes)
                    lista.Add((Produse)t.Tag);

                XmlSerializer serializator1 = new XmlSerializer(typeof(List<Produse>));
                TextWriter writer = new StreamWriter(fd.FileName);
                serializator1.Serialize(writer, lista);
                writer.Close();

            }
        }

        private void incarcaDateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Fisiere fresh-uri *.frs|*.xml";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Produse> lista = new List<Produse>();

                try
                {
                    XmlSerializer serializator = new XmlSerializer
                   (typeof(List<Produse>));

                    StreamReader reader =
                        new StreamReader(fd.FileName);

                    lista.AddRange((List<Produse>)serializator.Deserialize(reader));
                    reader.Close();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                foreach (Produse p in lista)
                {
                    TreeNode nod = new TreeNode(p.denumire);
                    treeView1.Nodes.Add(nod);
                    int n = treeView1.Nodes.Count;
                    nod.Text = p.denumire;
                    nod.Nodes.Add(p.dataFabricatiei.ToString("dd.MM.yyyy"));
                    nod.Nodes.Add(p.dataDeExpirare.ToString("dd.MM.yyyy"));
                    nod.Nodes.Add(p.nrLot.ToString());
                    foreach (string c in p.compozitii)
                        treeView1.Nodes[n - 1].Nodes.Add(c);
                    nod.Tag = p;
                }

            }
        }

        private void adaugaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormProdus fp = new FormProdus(null);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                Produse p = new Produse(fp.mFormProduse.denumire, fp.mFormProduse.dataFabricatiei, fp.mFormProduse.dataDeExpirare, fp.mFormProduse.nrLot);
                treeView1.Nodes.Add(fp.mFormProduse.denumire.ToString());
                int n = treeView1.Nodes.Count;
                treeView1.Nodes[n - 1].Nodes.Add(fp.mFormProduse.dataFabricatiei.ToString("dd.MM.yyyy"));
                treeView1.Nodes[n - 1].Nodes.Add(fp.mFormProduse.dataDeExpirare.ToString("dd.MM.yyyy"));
                treeView1.Nodes[n - 1].Nodes.Add(fp.mFormProduse.nrLot.ToString());
                treeView1.Nodes[n - 1].Tag = p;
            }
        }

        private void editeazaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Contains(treeView1.SelectedNode))
            {
                Produse p = new Produse(treeView1.SelectedNode.Text, DateTime.Parse(treeView1.SelectedNode.Nodes[0].Text), DateTime.Parse(treeView1.SelectedNode.Nodes[1].Text), 23423432/*int.Parse(treeView1.SelectedNode.Nodes[2].ToString())*/);
                FormProdus fp = new FormProdus(p);
                if (fp.ShowDialog() == DialogResult.OK)
                {
                    treeView1.SelectedNode.Text = (fp.mFormProduse.denumire);
                    treeView1.SelectedNode.Nodes[0].Text = (fp.mFormProduse.dataFabricatiei.ToString("dd.MM.yyyy"));
                    treeView1.SelectedNode.Nodes[1].Text = (fp.mFormProduse.dataDeExpirare.ToString("dd.MM.yyyy"));
                    treeView1.SelectedNode.Nodes[2].Text = (fp.mFormProduse.nrLot.ToString());
                    treeView1.SelectedNode.Tag = fp.mFormProduse;
                }
            }
        }

        private void LoginControl_LoginSuccess(object sender, EventArgs e)
        {
            isLoggedIn = true;
            MessageBox.Show("Autentificare cu succes.");
            if (treeView1.Nodes.Contains(treeView1.SelectedNode))
                treeView1.SelectedNode.Remove();

            if (!(treeView1.Nodes.Contains(treeView1.SelectedNode)))
                treeView1.SelectedNode.Remove();
        }

        private void stergeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserControlLog loginControl = new UserControlLog();
            loginControl.LoginSuccess += LoginControl_LoginSuccess;
            this.Controls.Add(loginControl);
            loginControl.Location = new Point((this.Width - loginControl.Width) / 2, (this.Height - loginControl.Height) / 2);
            loginControl.Size = new Size(300, 300);
            loginControl.BringToFront();

                

        }

        private void adaugaProdusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if ((treeView1.Nodes.Contains(treeView1.SelectedNode)))
            {
                FormFisaCosnum ff = new FormFisaCosnum(null);
                if (ff.ShowDialog() == DialogResult.OK)
                    if (ff.mFormFisa.materiePrima.ToString().Length != 0 && ff.mFormFisa.proportie.ToString().Length != 0)
                    {
                        TreeNode t = treeView1.SelectedNode;
                        Produse p1 = (Produse)t.Tag;
                        p1.adauga(ff.mFormFisa);
                        int n = treeView1.SelectedNode.Nodes.Count;
                        string c = p1.compozitii[n - 3];
                        treeView1.SelectedNode.Nodes.Add(c);
                    }
            }
        }

        private void editeazaProdusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!(treeView1.Nodes.Contains(treeView1.SelectedNode)))
            {
                string[] cuvinte = treeView1.SelectedNode.Text.Split(',');
                string digitsOnly = "";
                foreach (char c in cuvinte[1])
                {
                    if (Char.IsDigit(c))
                    {
                        digitsOnly += c;
                    }
                }
                FisaConsum f = new FisaConsum(cuvinte[0], int.Parse(digitsOnly));
                FormFisaCosnum ff = new FormFisaCosnum(f);
                if (ff.ShowDialog() == DialogResult.OK)
                    treeView1.SelectedNode.Text = (ff.mFormFisa.materiePrima + ", " + ff.mFormFisa.proportie.ToString() + "%");
            }
        }

        private void stergeProdusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserControlLog loginControl = new UserControlLog();
            loginControl.LoginSuccess += LoginControl_LoginSuccess;
            this.Controls.Add(loginControl);
            loginControl.Location = new Point((this.Width - loginControl.Width) / 2, (this.Height - loginControl.Height) / 2);
            loginControl.Size = new Size(300, 300);
            loginControl.BringToFront();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes.Contains(treeView1.SelectedNode))
            {
                textBoxf.Text = treeView1.SelectedNode.Nodes[0].Text;
                textBoxe.Text = treeView1.SelectedNode.Nodes[1].Text;
                textBoxl.Text = treeView1.SelectedNode.Nodes[2].Text;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(treeView1.Nodes.Contains(treeView1.SelectedNode)) && treeView1.SelectedNode.Text.Count(c => c == ',') == 1)
            {
                editeazaProdusToolStripMenuItem.Enabled = true;
                stergeProdusToolStripMenuItem.Enabled = true;
            }
            else
            {
                editeazaProdusToolStripMenuItem.Enabled = false;
                stergeProdusToolStripMenuItem.Enabled = false;
            }
            if (!(treeView1.Nodes.Contains(treeView1.SelectedNode)))
                adaugaProdusToolStripMenuItem.Enabled = false;
            else
                adaugaProdusToolStripMenuItem.Enabled = true;
        }

        private void produseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Contains(treeView1.SelectedNode))
            {
                editeazaToolStripMenuItem.Enabled = true;
                stergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                editeazaToolStripMenuItem.Enabled = false;
                stergeToolStripMenuItem.Enabled = false;
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGestionare fg = new FormGestionare();
            fg.Show();
        }

        private void labellot_Click(object sender, EventArgs e)
        {

        }

        private void textBoxf_TextChanged_1(object sender, EventArgs e)
        {

        }

        private int elementCurent = 0;  
        private int elementePePagina = 0;  
        private int elementePePaginaMax = 15;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 1;
            while (elementCurent < treeView1.Nodes.Count)
            {
                TreeNode t = treeView1.Nodes[elementCurent];

                e.Graphics.DrawString(t.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 125 + 40 * i);
                i++;
                elementePePagina++;

                foreach (TreeNode t2 in t.Nodes)
                {
                    e.Graphics.DrawString("- " + t2.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 125 + 40 * i);
                    i++;
                    elementePePagina++;
                }

                elementCurent++;

                if (elementePePagina >= elementePePaginaMax)
                {
                    elementePePagina = 0;
                    e.HasMorePages = true; 
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void printeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                pagcurenta = 0;
                printDocument1.Print();
            }
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic fg=new FormGrafic();
            fg.Show();
        }
    }
}