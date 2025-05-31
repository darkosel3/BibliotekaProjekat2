namespace BibliotekaProjekat2
{
    partial class frmIzmeni
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
            this.btnNazadIzmeni = new System.Windows.Forms.Button();
            this.btnIzmeniPozajmicu = new System.Windows.Forms.Button();
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
            this.dtpDatumVracanja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNazadIzmeni
            // 
            this.btnNazadIzmeni.Location = new System.Drawing.Point(33, 384);
            this.btnNazadIzmeni.Name = "btnNazadIzmeni";
            this.btnNazadIzmeni.Size = new System.Drawing.Size(201, 36);
            this.btnNazadIzmeni.TabIndex = 42;
            this.btnNazadIzmeni.Text = "Nazad";
            this.btnNazadIzmeni.UseVisualStyleBackColor = true;
            this.btnNazadIzmeni.Click += new System.EventHandler(this.btnNazadIzmeni_Click);
            // 
            // btnIzmeniPozajmicu
            // 
            this.btnIzmeniPozajmicu.Location = new System.Drawing.Point(275, 322);
            this.btnIzmeniPozajmicu.Name = "btnIzmeniPozajmicu";
            this.btnIzmeniPozajmicu.Size = new System.Drawing.Size(201, 98);
            this.btnIzmeniPozajmicu.TabIndex = 41;
            this.btnIzmeniPozajmicu.Text = "Izmeni pozajmicu";
            this.btnIzmeniPozajmicu.UseVisualStyleBackColor = true;
            this.btnIzmeniPozajmicu.Click += new System.EventHandler(this.btnIzmeniPozajmicu_Click);
            // 
            // dtpDatumIstekaPozajmice
            // 
            this.dtpDatumIstekaPozajmice.Location = new System.Drawing.Point(276, 279);
            this.dtpDatumIstekaPozajmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumIstekaPozajmice.Name = "dtpDatumIstekaPozajmice";
            this.dtpDatumIstekaPozajmice.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumIstekaPozajmice.TabIndex = 40;
            // 
            // dtpDatumPozajmice
            // 
            this.dtpDatumPozajmice.Location = new System.Drawing.Point(33, 279);
            this.dtpDatumPozajmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumPozajmice.Name = "dtpDatumPozajmice";
            this.dtpDatumPozajmice.Size = new System.Drawing.Size(201, 22);
            this.dtpDatumPozajmice.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Datum Isteka Pozajmice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Datum Pozajmice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Clan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Knjiga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Radnik";
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(33, 201);
            this.cbClan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(443, 24);
            this.cbClan.TabIndex = 33;
            // 
            // cbRadnik
            // 
            this.cbRadnik.FormattingEnabled = true;
            this.cbRadnik.Location = new System.Drawing.Point(33, 127);
            this.cbRadnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRadnik.Name = "cbRadnik";
            this.cbRadnik.Size = new System.Drawing.Size(443, 24);
            this.cbRadnik.TabIndex = 32;
            // 
            // cbKnjiga
            // 
            this.cbKnjiga.FormattingEnabled = true;
            this.cbKnjiga.Location = new System.Drawing.Point(33, 57);
            this.cbKnjiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKnjiga.Name = "cbKnjiga";
            this.cbKnjiga.Size = new System.Drawing.Size(443, 24);
            this.cbKnjiga.TabIndex = 31;
            // 
            // dtpDatumVracanja
            // 
            this.dtpDatumVracanja.Location = new System.Drawing.Point(33, 347);
            this.dtpDatumVracanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumVracanja.Name = "dtpDatumVracanja";
            this.dtpDatumVracanja.Size = new System.Drawing.Size(201, 22);
            this.dtpDatumVracanja.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Datum Vracanja:";
            // 
            // frmIzmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.dtpDatumVracanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNazadIzmeni);
            this.Controls.Add(this.btnIzmeniPozajmicu);
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
            this.Name = "frmIzmeni";
            this.Text = "frmNoviIzmeni";
            this.Load += new System.EventHandler(this.frmNoviIzmeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazadIzmeni;
        private System.Windows.Forms.Button btnIzmeniPozajmicu;
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
        private System.Windows.Forms.DateTimePicker dtpDatumVracanja;
        private System.Windows.Forms.Label label1;
    }
}