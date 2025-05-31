using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekat2
{
    public partial class frmNovi : Form
    {
        public int knjigaID;
        BibliotekaGradBeogradDBDataContext ctx = new BibliotekaGradBeogradDBDataContext();
        public frmNovi()
        {
            InitializeComponent();
        }

        private void frmNovi_Load(object sender, EventArgs e)
        {
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


            //Formatiranje DateTimePicker-a
            dtpDatumPozajmice.Format = DateTimePickerFormat.Custom;
            dtpDatumPozajmice.CustomFormat = "MM/dd/yyyy";
            dtpDatumIstekaPozajmice.Format = DateTimePickerFormat.Custom;
            dtpDatumIstekaPozajmice.CustomFormat = "MM/dd/yyyy";


            cbKnjiga.SelectedValue = knjigaID;
            cbKnjiga.Enabled = false; // onemogućava promenu knjige
        }


             private void btnDodaj_Click(object sender, EventArgs e)
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


            
            int knjigaID = (int)cbKnjiga.SelectedValue;
            int clanID = (int)cbClan.SelectedValue;
            int radnikID = (int)cbRadnik.SelectedValue;

            ctx.InsertPozajmica(clanID,knjigaID,radnikID,datumPozajmice,datumIsteka,null);
            this.Close(); //Zatvaramo novu pozajmicu
        }

        private void btnNazadNovi_Click(object sender, EventArgs e)
        {
            this.Close(); //Zatvaramo i ne menjamo nista!
        }
    }
}
