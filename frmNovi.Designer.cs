namespace BibliotekaProjekat2
{
    partial class frmNovi
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
            this.dtpDatumIstekaPozajmice = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumPozajmice = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.cbRadnik = new System.Windows.Forms.ComboBox();
            this.cbKnjiga = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNazadNovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDatumIstekaPozajmice
            // 
            this.dtpDatumIstekaPozajmice.Location = new System.Drawing.Point(287, 281);
            this.dtpDatumIstekaPozajmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumIstekaPozajmice.Name = "dtpDatumIstekaPozajmice";
            this.dtpDatumIstekaPozajmice.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumIstekaPozajmice.TabIndex = 28;
            // 
            // dtpDatumPozajmice
            // 
            this.dtpDatumPozajmice.Location = new System.Drawing.Point(44, 281);
            this.dtpDatumPozajmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumPozajmice.Name = "dtpDatumPozajmice";
            this.dtpDatumPozajmice.Size = new System.Drawing.Size(201, 22);
            this.dtpDatumPozajmice.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Datum Isteka Pozajmice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Datum Pozajmice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Clan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Knjiga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Radnik";
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(44, 203);
            this.cbClan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(443, 24);
            this.cbClan.TabIndex = 19;
            // 
            // cbRadnik
            // 
            this.cbRadnik.FormattingEnabled = true;
            this.cbRadnik.Location = new System.Drawing.Point(44, 129);
            this.cbRadnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRadnik.Name = "cbRadnik";
            this.cbRadnik.Size = new System.Drawing.Size(443, 24);
            this.cbRadnik.TabIndex = 18;
            // 
            // cbKnjiga
            // 
            this.cbKnjiga.FormattingEnabled = true;
            this.cbKnjiga.Location = new System.Drawing.Point(44, 59);
            this.cbKnjiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKnjiga.Name = "cbKnjiga";
            this.cbKnjiga.Size = new System.Drawing.Size(443, 24);
            this.cbKnjiga.TabIndex = 17;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(287, 324);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(201, 36);
            this.btnDodaj.TabIndex = 29;
            this.btnDodaj.Text = "Dodaj novu pozajmicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNazadNovi
            // 
            this.btnNazadNovi.Location = new System.Drawing.Point(44, 324);
            this.btnNazadNovi.Name = "btnNazadNovi";
            this.btnNazadNovi.Size = new System.Drawing.Size(201, 36);
            this.btnNazadNovi.TabIndex = 30;
            this.btnNazadNovi.Text = "Nazad";
            this.btnNazadNovi.UseVisualStyleBackColor = true;
            this.btnNazadNovi.Click += new System.EventHandler(this.btnNazadNovi_Click);
            // 
            // frmNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 382);
            this.Controls.Add(this.btnNazadNovi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatumIstekaPozajmice);
            this.Controls.Add(this.dtpDatumPozajmice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.cbRadnik);
            this.Controls.Add(this.cbKnjiga);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNovi";
            this.Text = "frmNoviIzmeni";
            this.Load += new System.EventHandler(this.frmNovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDatumIstekaPozajmice;
        private System.Windows.Forms.DateTimePicker dtpDatumPozajmice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.ComboBox cbRadnik;
        private System.Windows.Forms.ComboBox cbKnjiga;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNazadNovi;
    }
}