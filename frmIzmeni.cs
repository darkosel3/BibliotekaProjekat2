using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekat2
{
    public partial class frmIzmeni : Form
    {
        public frmIzmeni()
        {
            InitializeComponent();
        }
        BibliotekaGradBeogradDBDataContext ctx;
        public Pozajmice pozajmica;
        private void frmNoviIzmeni_Load(object sender, EventArgs e)
        {
            ctx = new BibliotekaGradBeogradDBDataContext();
            var knjige = ctx.Knjiges.ToList();
            var radnici = from radnik in ctx.Radnicis
                          select new
                          {
                              ID = radnik.RadnikID,
                              Ime = radnik.Ime + " " + radnik.Prezime
                          };
            var clanovi = from clan in ctx.Clanovis
                          select new
                          {
                              ID = clan.ClanID,
                              Ime = clan.Ime + " " + clan.Prezime
                          };

            cbKnjiga.DataSource = knjige;
            cbKnjiga.DisplayMember = "Naziv";
            cbKnjiga.ValueMember = "KnjigaID";
            cbClan.DataSource = clanovi;
            cbClan.DisplayMember = "Ime";
            cbClan.ValueMember = "ID";
            cbRadnik.DataSource = radnici;
            cbRadnik.DisplayMember = "Ime";
            cbRadnik.ValueMember = "ID";
            cbKnjiga.SelectedValue = pozajmica.KnjigaID;
            cbClan.SelectedValue = pozajmica.ClanID;
            cbRadnik.SelectedValue = pozajmica.RadnikID;


            //Formatiranje DateTimePicker-a
            dtpDatumPozajmice.Format = DateTimePickerFormat.Custom;
            dtpDatumPozajmice.CustomFormat = "MM/dd/yyyy";
            dtpDatumIstekaPozajmice.Value = pozajmica.DatumPozajmice;

            dtpDatumIstekaPozajmice.Format = DateTimePickerFormat.Custom;
            dtpDatumIstekaPozajmice.CustomFormat = "MM/dd/yyyy";
            dtpDatumIstekaPozajmice.Value = pozajmica.DatumIstekaPozajmice;

            dtpDatumVracanja.Format = DateTimePickerFormat.Custom;
            dtpDatumVracanja.CustomFormat = "MM/dd/yyyy";
            dtpDatumVracanja.Value = pozajmica.DatumVracanja.HasValue ? pozajmica.DatumVracanja.Value : DateTime.Now;
            // Ako je DatumVracanja null, postavi na trenutni datum

            cbKnjiga.Enabled = false; // onemogućava promenu knjige
        }

        private void btnNazadIzmeni_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzmeniPozajmicu_Click(object sender, EventArgs e)
        {

            // Radnik nije izabran u combo boxu
            if (cbRadnik.SelectedIndex <= 0)
            {
                MessageBox.Show("Morate izabrati radnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRadnik.Focus();
                return;
            }

            // Clan nije izabran u combo 
            if (cbClan.SelectedIndex <= 0)
            {
                MessageBox.Show("Morate izabrati člana!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbClan.Focus();
                return;
            }

            // Neispravan datumPozajmice
            if (!DateTime.TryParse(dtpDatumPozajmice.Text, out DateTime datumPozajmice))
            {
                MessageBox.Show("Neispravan format datuma pozajmice!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumPozajmice.Focus();
                return;
            }
            // Neispravan datum Isteka
            if (!DateTime.TryParse(dtpDatumIstekaPozajmice.Text, out DateTime datumIsteka))
            {
                MessageBox.Show("Neispravan format datuma isteka pozajmice!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumIstekaPozajmice.Focus();
                return;
            }

            // Datum isteka mora biti posle datuma pozajmice
            if (datumIsteka <= datumPozajmice)
            {
                MessageBox.Show("Datum isteka mora biti posle datuma pozajmice!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumIstekaPozajmice.Focus();
                return;
            }


            ctx.UpdatePozajmica(pozajmica.PozajmicaID,
                Convert.ToInt32(cbKnjiga.SelectedValue),
                Convert.ToInt32(cbRadnik.SelectedValue),
                Convert.ToInt32(cbClan.SelectedValue),
                dtpDatumPozajmice.Value,
                dtpDatumIstekaPozajmice.Value,
                dtpDatumVracanja.Value);

            this.Close();  
        }
    }
}
