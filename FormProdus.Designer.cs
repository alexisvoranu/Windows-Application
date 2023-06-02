namespace ProiectNou2
{
    partial class FormProdus
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
            this.LotFabricatie = new System.Windows.Forms.Label();
            this.textBoxLot = new System.Windows.Forms.TextBox();
            this.dateTimePickerf = new System.Windows.Forms.DateTimePicker();
            this.DataFabricatiei = new System.Windows.Forms.Label();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.dateTimePickere = new System.Windows.Forms.DateTimePicker();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.DatadeExpirare = new System.Windows.Forms.Label();
            this.DenumireProdus = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // LotFabricatie
            // 
            this.LotFabricatie.AutoSize = true;
            this.LotFabricatie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LotFabricatie.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LotFabricatie.Location = new System.Drawing.Point(127, 91);
            this.LotFabricatie.Name = "LotFabricatie";
            this.LotFabricatie.Size = new System.Drawing.Size(98, 18);
            this.LotFabricatie.TabIndex = 25;
            this.LotFabricatie.Text = "Lot Fabricatie:";
            // 
            // textBoxLot
            // 
            this.textBoxLot.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLot.Location = new System.Drawing.Point(229, 88);
            this.textBoxLot.Name = "textBoxLot";
            this.textBoxLot.Size = new System.Drawing.Size(171, 26);
            this.textBoxLot.TabIndex = 24;
            this.textBoxLot.TextChanged += new System.EventHandler(this.textBoxLot_TextChanged);
            this.textBoxLot.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLot_Validating);
            this.textBoxLot.Validated += new System.EventHandler(this.textBoxLot_Validated);
            // 
            // dateTimePickerf
            // 
            this.dateTimePickerf.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dateTimePickerf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerf.Location = new System.Drawing.Point(229, 127);
            this.dateTimePickerf.Name = "dateTimePickerf";
            this.dateTimePickerf.Size = new System.Drawing.Size(171, 26);
            this.dateTimePickerf.TabIndex = 23;
            // 
            // DataFabricatiei
            // 
            this.DataFabricatiei.AutoSize = true;
            this.DataFabricatiei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataFabricatiei.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFabricatiei.Location = new System.Drawing.Point(114, 133);
            this.DataFabricatiei.Name = "DataFabricatiei";
            this.DataFabricatiei.Size = new System.Drawing.Size(111, 18);
            this.DataFabricatiei.TabIndex = 22;
            this.DataFabricatiei.Text = "Data Fabricatiei:";
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttoncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttoncancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancel.Location = new System.Drawing.Point(327, 227);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(73, 41);
            this.buttoncancel.TabIndex = 21;
            this.buttoncancel.Text = "Renunta";
            this.buttoncancel.UseVisualStyleBackColor = false;
            // 
            // buttonok
            // 
            this.buttonok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonok.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonok.Location = new System.Drawing.Point(229, 227);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(73, 41);
            this.buttonok.TabIndex = 20;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = false;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // dateTimePickere
            // 
            this.dateTimePickere.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dateTimePickere.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickere.Location = new System.Drawing.Point(229, 171);
            this.dateTimePickere.Name = "dateTimePickere";
            this.dateTimePickere.Size = new System.Drawing.Size(171, 26);
            this.dateTimePickere.TabIndex = 19;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.Location = new System.Drawing.Point(229, 50);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(171, 26);
            this.textBoxDenumire.TabIndex = 18;
            this.textBoxDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDenumire_Validating);
            this.textBoxDenumire.Validated += new System.EventHandler(this.textBoxDenumire_Validated);
            // 
            // DatadeExpirare
            // 
            this.DatadeExpirare.AutoSize = true;
            this.DatadeExpirare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DatadeExpirare.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatadeExpirare.Location = new System.Drawing.Point(109, 177);
            this.DatadeExpirare.Name = "DatadeExpirare";
            this.DatadeExpirare.Size = new System.Drawing.Size(116, 18);
            this.DatadeExpirare.TabIndex = 17;
            this.DatadeExpirare.Text = "Data de Expirare:";
            // 
            // DenumireProdus
            // 
            this.DenumireProdus.AutoSize = true;
            this.DenumireProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DenumireProdus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenumireProdus.Location = new System.Drawing.Point(112, 53);
            this.DenumireProdus.Name = "DenumireProdus";
            this.DenumireProdus.Size = new System.Drawing.Size(113, 18);
            this.DenumireProdus.TabIndex = 16;
            this.DenumireProdus.Text = "Denumire Produs:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectNou2.Properties.Resources.Great_Beverage_Advertising_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LotFabricatie);
            this.Controls.Add(this.textBoxLot);
            this.Controls.Add(this.dateTimePickerf);
            this.Controls.Add(this.DataFabricatiei);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.dateTimePickere);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.DatadeExpirare);
            this.Controls.Add(this.DenumireProdus);
            this.Name = "FormProdus";
            this.Text = "FormProdus";
            this.Load += new System.EventHandler(this.FormProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LotFabricatie;
        private System.Windows.Forms.TextBox textBoxLot;
        private System.Windows.Forms.DateTimePicker dateTimePickerf;
        private System.Windows.Forms.Label DataFabricatiei;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.DateTimePicker dateTimePickere;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label DatadeExpirare;
        private System.Windows.Forms.Label DenumireProdus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}