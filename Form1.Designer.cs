namespace ProiectNou2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxl = new System.Windows.Forms.TextBox();
            this.textBoxe = new System.Windows.Forms.TextBox();
            this.labellot = new System.Windows.Forms.Label();
            this.labeldatae = new System.Windows.Forms.Label();
            this.labeldataf = new System.Windows.Forms.Label();
            this.textBoxf = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxl
            // 
            this.textBoxl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxl.Location = new System.Drawing.Point(589, 260);
            this.textBoxl.Name = "textBoxl";
            this.textBoxl.ReadOnly = true;
            this.textBoxl.Size = new System.Drawing.Size(89, 26);
            this.textBoxl.TabIndex = 14;
            // 
            // textBoxe
            // 
            this.textBoxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxe.Location = new System.Drawing.Point(589, 217);
            this.textBoxe.Name = "textBoxe";
            this.textBoxe.ReadOnly = true;
            this.textBoxe.Size = new System.Drawing.Size(89, 26);
            this.textBoxe.TabIndex = 13;
            // 
            // labellot
            // 
            this.labellot.AutoSize = true;
            this.labellot.BackColor = System.Drawing.Color.Cyan;
            this.labellot.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellot.Location = new System.Drawing.Point(529, 262);
            this.labellot.Name = "labellot";
            this.labellot.Size = new System.Drawing.Size(54, 18);
            this.labellot.TabIndex = 12;
            this.labellot.Text = "Nr. Lot:";
            this.labellot.Click += new System.EventHandler(this.labellot_Click);
            // 
            // labeldatae
            // 
            this.labeldatae.AutoSize = true;
            this.labeldatae.BackColor = System.Drawing.Color.Cyan;
            this.labeldatae.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatae.Location = new System.Drawing.Point(467, 219);
            this.labeldatae.Name = "labeldatae";
            this.labeldatae.Size = new System.Drawing.Size(116, 18);
            this.labeldatae.TabIndex = 11;
            this.labeldatae.Text = "Data de Expirare:";
            // 
            // labeldataf
            // 
            this.labeldataf.AutoSize = true;
            this.labeldataf.BackColor = System.Drawing.Color.Cyan;
            this.labeldataf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldataf.Location = new System.Drawing.Point(472, 175);
            this.labeldataf.Name = "labeldataf";
            this.labeldataf.Size = new System.Drawing.Size(111, 18);
            this.labeldataf.TabIndex = 10;
            this.labeldataf.Text = "Data Fabricatiei:";
            // 
            // textBoxf
            // 
            this.textBoxf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxf.Location = new System.Drawing.Point(589, 173);
            this.textBoxf.Name = "textBoxf";
            this.textBoxf.ReadOnly = true;
            this.textBoxf.Size = new System.Drawing.Size(89, 26);
            this.textBoxf.TabIndex = 9;
            this.textBoxf.TextChanged += new System.EventHandler(this.textBoxf_TextChanged_1);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(63, 96);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(328, 272);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.gestionareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaDateToolStripMenuItem,
            this.incarcaDateToolStripMenuItem,
            this.printeazaToolStripMenuItem});
            this.filToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.filToolStripMenuItem.Text = "Fisier";
            // 
            // salveazaDateToolStripMenuItem
            // 
            this.salveazaDateToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salveazaDateToolStripMenuItem.Name = "salveazaDateToolStripMenuItem";
            this.salveazaDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazaDateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.salveazaDateToolStripMenuItem.Text = "Salveaza date";
            this.salveazaDateToolStripMenuItem.Click += new System.EventHandler(this.salveazaDateToolStripMenuItem_Click_1);
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.incarcaDateToolStripMenuItem.Text = "Incarca date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click_1);
            // 
            // printeazaToolStripMenuItem
            // 
            this.printeazaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printeazaToolStripMenuItem.Name = "printeazaToolStripMenuItem";
            this.printeazaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printeazaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.printeazaToolStripMenuItem.Text = "Printeaza";
            this.printeazaToolStripMenuItem.Click += new System.EventHandler(this.printeazaToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.produseToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click_1);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga produs";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click_1);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza produs";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click_1);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.stergeToolStripMenuItem.Text = "Sterge produs";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click_1);
            // 
            // gestionareToolStripMenuItem
            // 
            this.gestionareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.graficToolStripMenuItem});
            this.gestionareToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionareToolStripMenuItem.Name = "gestionareToolStripMenuItem";
            this.gestionareToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.gestionareToolStripMenuItem.Text = "Gestionare";
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adaugaToolStripMenuItem1.Text = "Modifica";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProdusToolStripMenuItem,
            this.editeazaProdusToolStripMenuItem,
            this.stergeProdusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaProdusToolStripMenuItem
            // 
            this.adaugaProdusToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
            this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.adaugaProdusToolStripMenuItem.Text = "Adauga compozitie";
            this.adaugaProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugaProdusToolStripMenuItem_Click_1);
            // 
            // editeazaProdusToolStripMenuItem
            // 
            this.editeazaProdusToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeazaProdusToolStripMenuItem.Name = "editeazaProdusToolStripMenuItem";
            this.editeazaProdusToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editeazaProdusToolStripMenuItem.Text = "Editeaza compozitie";
            this.editeazaProdusToolStripMenuItem.Click += new System.EventHandler(this.editeazaProdusToolStripMenuItem_Click_1);
            // 
            // stergeProdusToolStripMenuItem
            // 
            this.stergeProdusToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
            this.stergeProdusToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.stergeProdusToolStripMenuItem.Text = "Sterge compozitie";
            this.stergeProdusToolStripMenuItem.Click += new System.EventHandler(this.stergeProdusToolStripMenuItem_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectNou2.Properties.Resources.Fresh;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxl);
            this.Controls.Add(this.textBoxe);
            this.Controls.Add(this.labellot);
            this.Controls.Add(this.labeldatae);
            this.Controls.Add(this.labeldataf);
            this.Controls.Add(this.textBoxf);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxl;
        private System.Windows.Forms.TextBox textBoxe;
        private System.Windows.Forms.Label labellot;
        private System.Windows.Forms.Label labeldatae;
        private System.Windows.Forms.Label labeldataf;
        private System.Windows.Forms.TextBox textBoxf;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem printeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
    }
}

