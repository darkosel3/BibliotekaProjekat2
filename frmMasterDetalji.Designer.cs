namespace BibliotekaProjekat2
{
    partial class frmMasterDetalji
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
            this.saveXML = new System.Windows.Forms.Button();
            this.btnNovaPozajmica = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtGodinaIzdavanja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.broj_kopija = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwPozajmice = new System.Windows.Forms.DataGridView();
            this.cbKnjiga = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDKnjige = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPozajmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveXML
            // 
            this.saveXML.Location = new System.Drawing.Point(32, 462);
            this.saveXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveXML.Name = "saveXML";
            this.saveXML.Size = new System.Drawing.Size(171, 46);
            this.saveXML.TabIndex = 26;
            this.saveXML.Text = "Sacuvaj podatke (XML)";
            this.saveXML.UseVisualStyleBackColor = true;
            // 
            // btnNovaPozajmica
            // 
            this.btnNovaPozajmica.Location = new System.Drawing.Point(592, 462);
            this.btnNovaPozajmica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovaPozajmica.Name = "btnNovaPozajmica";
            this.btnNovaPozajmica.Size = new System.Drawing.Size(168, 46);
            this.btnNovaPozajmica.TabIndex = 25;
            this.btnNovaPozajmica.Text = "Novi";
            this.btnNovaPozajmica.UseVisualStyleBackColor = true;
            this.btnNovaPozajmica.Click += new System.EventHandler(this.btnNovaPozajmica_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(768, 462);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(168, 46);
            this.btnIzmeni.TabIndex = 24;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(948, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 46);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Izbrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(899, 53);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(217, 22);
            this.txtAutor.TabIndex = 22;
            // 
            // txtGodinaIzdavanja
            // 
            this.txtGodinaIzdavanja.Location = new System.Drawing.Point(899, 91);
            this.txtGodinaIzdavanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGodinaIzdavanja.Name = "txtGodinaIzdavanja";
            this.txtGodinaIzdavanja.Size = new System.Drawing.Size(217, 22);
            this.txtGodinaIzdavanja.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Godina Izdavanja:";
            // 
            // broj_kopija
            // 
            this.broj_kopija.AutoSize = true;
            this.broj_kopija.Location = new System.Drawing.Point(892, 26);
            this.broj_kopija.Name = "broj_kopija";
            this.broj_kopija.Size = new System.Drawing.Size(74, 16);
            this.broj_kopija.TabIndex = 18;
            this.broj_kopija.Text = "broj_kopija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Broj slobodnih kopija:";
            // 
            // dgwPozajmice
            // 
            this.dgwPozajmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPozajmice.Location = new System.Drawing.Point(32, 135);
            this.dgwPozajmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwPozajmice.Name = "dgwPozajmice";
            this.dgwPozajmice.RowHeadersWidth = 51;
            this.dgwPozajmice.RowTemplate.Height = 24;
            this.dgwPozajmice.Size = new System.Drawing.Size(1084, 313);
            this.dgwPozajmice.TabIndex = 16;
            // 
            // cbKnjiga
            // 
            this.cbKnjiga.FormattingEnabled = true;
            this.cbKnjiga.Location = new System.Drawing.Point(184, 54);
            this.cbKnjiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKnjiga.Name = "cbKnjiga";
            this.cbKnjiga.Size = new System.Drawing.Size(367, 24);
            this.cbKnjiga.TabIndex = 15;
            this.cbKnjiga.SelectedIndexChanged += new System.EventHandler(this.cbKnjiga_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 98);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID Knjige:";
            // 
            // IDKnjige
            // 
            this.IDKnjige.AutoSize = true;
            this.IDKnjige.Location = new System.Drawing.Point(265, 97);
            this.IDKnjige.Name = "IDKnjige";
            this.IDKnjige.Size = new System.Drawing.Size(18, 16);
            this.IDKnjige.TabIndex = 29;
            this.IDKnjige.Text = "id";
            // 
            // frmMasterDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 526);
            this.Controls.Add(this.IDKnjige);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveXML);
            this.Controls.Add(this.btnNovaPozajmica);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtGodinaIzdavanja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.broj_kopija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwPozajmice);
            this.Controls.Add(this.cbKnjiga);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMasterDetalji";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMasterDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPozajmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveXML;
        private System.Windows.Forms.Button btnNovaPozajmica;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtGodinaIzdavanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label broj_kopija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwPozajmice;
        private System.Windows.Forms.ComboBox cbKnjiga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDKnjige;
    }
}