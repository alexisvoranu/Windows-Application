namespace ProiectNou2
{
    partial class FormFisaCosnum
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
            this.Proportie = new System.Windows.Forms.Label();
            this.textBoxProportie = new System.Windows.Forms.TextBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.textBoxMaterie = new System.Windows.Forms.TextBox();
            this.MateriePrima = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Proportie
            // 
            this.Proportie.AutoSize = true;
            this.Proportie.BackColor = System.Drawing.Color.Lime;
            this.Proportie.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proportie.Location = new System.Drawing.Point(331, 209);
            this.Proportie.Name = "Proportie";
            this.Proportie.Size = new System.Drawing.Size(68, 18);
            this.Proportie.TabIndex = 37;
            this.Proportie.Text = "Proportie:";
            // 
            // textBoxProportie
            // 
            this.textBoxProportie.BackColor = System.Drawing.Color.Red;
            this.textBoxProportie.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProportie.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProportie.Location = new System.Drawing.Point(407, 206);
            this.textBoxProportie.Name = "textBoxProportie";
            this.textBoxProportie.Size = new System.Drawing.Size(122, 26);
            this.textBoxProportie.TabIndex = 36;
            this.textBoxProportie.TextChanged += new System.EventHandler(this.textBoxProportie_TextChanged);
            this.textBoxProportie.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProportie_Validating);
            this.textBoxProportie.Validated += new System.EventHandler(this.textBoxProportie_Validated);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.Lime;
            this.buttoncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttoncancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancel.Location = new System.Drawing.Point(442, 251);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(87, 33);
            this.buttoncancel.TabIndex = 35;
            this.buttoncancel.Text = "Renunta";
            this.buttoncancel.UseVisualStyleBackColor = false;
            // 
            // buttonok
            // 
            this.buttonok.BackColor = System.Drawing.Color.Lime;
            this.buttonok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonok.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonok.Location = new System.Drawing.Point(303, 251);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(74, 33);
            this.buttonok.TabIndex = 34;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = false;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // textBoxMaterie
            // 
            this.textBoxMaterie.AllowDrop = true;
            this.textBoxMaterie.BackColor = System.Drawing.Color.Red;
            this.textBoxMaterie.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterie.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxMaterie.Location = new System.Drawing.Point(407, 168);
            this.textBoxMaterie.Name = "textBoxMaterie";
            this.textBoxMaterie.Size = new System.Drawing.Size(122, 26);
            this.textBoxMaterie.TabIndex = 33;
            this.textBoxMaterie.TextChanged += new System.EventHandler(this.textBoxMaterie_TextChanged);
            this.textBoxMaterie.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxMaterie_DragDrop);
            this.textBoxMaterie.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxMaterie_DragEnter);
            this.textBoxMaterie.Validated += new System.EventHandler(this.textBoxMaterie_Validated);
            // 
            // MateriePrima
            // 
            this.MateriePrima.AutoSize = true;
            this.MateriePrima.BackColor = System.Drawing.Color.Lime;
            this.MateriePrima.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriePrima.Location = new System.Drawing.Point(303, 168);
            this.MateriePrima.Name = "MateriePrima";
            this.MateriePrima.Size = new System.Drawing.Size(96, 18);
            this.MateriePrima.TabIndex = 32;
            this.MateriePrima.Text = "Materie Prima:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Lime;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "Mar",
            "Portocala",
            "Kiwi",
            "Banana",
            "Grapefruit",
            "Morcov"});
            this.listBox1.Location = new System.Drawing.Point(595, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 106);
            this.listBox1.TabIndex = 38;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // FormFisaCosnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectNou2.Properties.Resources.Rainbow_fruits_background_featuring_top_view__white__and_view1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Proportie);
            this.Controls.Add(this.textBoxProportie);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxMaterie);
            this.Controls.Add(this.MateriePrima);
            this.Name = "FormFisaCosnum";
            this.Text = "FormFisaCosnum";
            this.Load += new System.EventHandler(this.FormFisaCosnum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Proportie;
        private System.Windows.Forms.TextBox textBoxProportie;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.TextBox textBoxMaterie;
        private System.Windows.Forms.Label MateriePrima;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ListBox listBox1;
    }
}