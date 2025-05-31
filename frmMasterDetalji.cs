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
    public partial class frmMasterDetalji : Form
    {
        BibliotekaGradBeogradDBDataContext ctx;
        public frmMasterDetalji()
        {
            InitializeComponent();
        }

        private void frmMasterDetalji_Load(object sender, EventArgs e)
        {
            ctx = new BibliotekaGradBeogradDBDataContext();
            cbKnjiga.DataSource = ctx.Knjiges.ToList();
            cbKnjiga.DisplayMember = "Naziv";
            cbKnjiga.ValueMember = "KnjigaID";
            //cbKnjiga.SelectedIndex = 0;
            txtGodinaIzdavanja.ReadOnly = true; // Autor je samo za čitanje
            txtAutor.ReadOnly = true; // Autor je samo za čitanje

            popuniCBiDGW();
            dgwPozajmice.Columns["Vraćeno"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgwPozajmice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwPozajmice.MultiSelect = false;
            dgwPozajmice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwPozajmice.ReadOnly = true; // samo za čitanje
        }
        private void cbKnjiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKnjiga.SelectedValue == null || !(cbKnjiga.SelectedValue is int))
                return; // prekini ako još uvek nije spremno
            ctx = new BibliotekaGradBeogradDBDataContext();

            popuniCBiDGW();
        }
        private void popuniCBiDGW()
        {
            ctx = new BibliotekaGradBeogradDBDataContext();
            int selectedKnjigaId = Convert.ToInt32(cbKnjiga.SelectedValue);
            var izabranaKnjiga = ctx.Knjiges.Where(k => k.KnjigaID == selectedKnjigaId); 
            txtAutor.Text = izabranaKnjiga.Select(k => k.Autor).FirstOrDefault();
            txtGodinaIzdavanja.Text = izabranaKnjiga.Select(k => k.GodinaIzdavanja.ToString()).FirstOrDefault();
            IDKnjige.Text = izabranaKnjiga.Select(k => k.KnjigaID.ToString()).FirstOrDefault();
            broj_kopija.Text = izabranaKnjiga.Select(k => k.DostupneKopije.ToString()).FirstOrDefault();
            var pozajmice = from pozajmica in ctx.Pozajmices
                            join knjiga in ctx.Knjiges
                            on pozajmica.KnjigaID equals knjiga.KnjigaID
                            join radnik in ctx.Radnicis
                            on pozajmica.RadnikID equals radnik.RadnikID
                            join clan in ctx.Clanovis
                            on pozajmica.ClanID equals clan.ClanID
                            where pozajmica.KnjigaID == selectedKnjigaId
                            select new
                            {
                                ID = pozajmica.PozajmicaID,
                                Član = clan.Ime + " " + clan.Prezime,
                                Radnik = radnik.Ime + " " + radnik.Prezime,
                                Pozajmljeno = pozajmica.DatumPozajmice.ToString(),
                                Ističe = pozajmica.DatumIstekaPozajmice.ToString(),
                                Vraćeno = pozajmica.DatumVracanja.ToString()
                            };


            dgwPozajmice.DataSource = pozajmice.ToList();
        }

        private void btnNovaPozajmica_Click(object sender, EventArgs e)
        {

            frmNovi frmNovi = new frmNovi();
            //MessageBox.Show("" + (cbKnjiga.SelectedValue - 1));
            frmNovi.knjigaID = Convert.ToInt32(cbKnjiga.SelectedValue);
            frmNovi.ShowDialog();
            popuniCBiDGW(); 
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            frmIzmeni frmIzmeni = new frmIzmeni();
            if (dgwPozajmice.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgwPozajmice.SelectedRows[0].Index;
                if (selectedRowIndex >= 0 && selectedRowIndex < dgwPozajmice.Rows.Count)
                {
                    int pozajmicaID = Convert.ToInt32(dgwPozajmice.Rows[selectedRowIndex].Cells["ID"].Value);
                    Pozajmice pozajmicaZaMenjanje = ctx.Pozajmices.FirstOrDefault(p => p.PozajmicaID == pozajmicaID);
                    frmIzmeni.pozajmica = pozajmicaZaMenjanje;
                    frmIzmeni.ShowDialog();
                    popuniCBiDGW();
                }
            }
            else
            {
                MessageBox.Show("Molimo pozajmicu za izmenu.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgwPozajmice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo izaberite pozajmicu za brisanje.");
                return;
            }
            var result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu pozajmicu?", "Brisanje pozajmice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                ctx.DeletePozajmica((int)dgwPozajmice.SelectedRows[0].Cells["ID"].Value);
                popuniCBiDGW();
            }
        }
    }
}
