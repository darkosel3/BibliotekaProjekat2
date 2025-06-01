namespace BibliotekaProjekat2
{
    partial class frmGlavna
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
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUgasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.Location = new System.Drawing.Point(29, 21);
            this.btnAnaliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(255, 89);
            this.btnAnaliza.TabIndex = 0;
            this.btnAnaliza.Text = "Analiza pozajmica";
            this.btnAnaliza.UseVisualStyleBackColor = true;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 126);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pozajmice po knjigama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUgasi
            // 
            this.btnUgasi.Location = new System.Drawing.Point(29, 226);
            this.btnUgasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUgasi.Name = "btnUgasi";
            this.btnUgasi.Size = new System.Drawing.Size(255, 84);
            this.btnUgasi.TabIndex = 2;
            this.btnUgasi.Text = "Ugasi program";
            this.btnUgasi.UseVisualStyleBackColor = true;
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 334);
            this.Controls.Add(this.btnUgasi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAnaliza);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGlavna";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaliza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUgasi;
    }
}

