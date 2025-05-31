using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekat2
{
    public partial class frmAnaliza : Form
    {
        public frmAnaliza()
        {
            InitializeComponent();
        }

        private void frmAnaliza_Load(object sender, EventArgs e)
        {
    
            BibliotekaGradBeogradDBDataContext ctx = new BibliotekaGradBeogradDBDataContext();
            var analize = from radnik in ctx.Radnicis
                          join pozajmica in ctx.Pozajmices //rezultat ovoga mi pretvori
                          on radnik.RadnikID equals pozajmica.RadnikID into inJoin
                          from outJoin in inJoin.DefaultIfEmpty()
                          orderby radnik.RadnikID descending
                          select new
                          {
                              ID = radnik.RadnikID,
                              Ime = radnik.Ime + " " + radnik.Prezime,
                              Pozajmljeno = outJoin != null ? outJoin.DatumPozajmice.ToString() : "Nema pozajmica",
                              Vraceno = outJoin != null ? outJoin.DatumVracanja.ToString() : "Nema pozajmica",
                          };
            //        inJoin = "Šta smo našli u spoju?"(grupa rezultata).
            //        outJoin = "Šta će ići u finalni rezultat?"(razvučeni podaci ili null).

            dataGridView1.DataSource = analize.ToList();

            var analiza2 = ctx.Radnicis.GroupJoin(ctx.Pozajmices, c => c.RadnikID, p => p.RadnikID,
                (c, o) => new
                {
                    ID = c.RadnikID,
                    Ime = c.Ime + " " + c.Prezime,
                    Pozajmice = o  // vrednost ovog objekta { ID = 1, Ime = "Darko Sel", Pozajmice = [Pozajmica1, Pozajmica2, ...] }
                }).SelectMany(radnikInfo => radnikInfo.Pozajmice.DefaultIfEmpty().Select(
                    poz => new // iz ovog objekta selektujemo radnika i pozajmicu
                    {
                        ID = radnikInfo.ID, // prikazujemo ID
                        Ime = radnikInfo.Ime, // Ime i prezime
                        Pozajmljeno = poz != null ? poz.DatumPozajmice.ToString() : "Nema pozajmica", // ukoliko nema pozajmicu vracamo tekst "Nema pozajmica"
                        Vraceno = poz != null ? poz.DatumVracanja.ToString() : "Nema pozajmica",// ukoliko nema pozajmicu vracamo tekst "Nema pozajmica"
                    })).OrderByDescending(r => r.ID); // sortiramo po ID-ju opadajuće
            dataGridView2.DataSource = analiza2.ToList();
            // Testiranje
            // MessageBox.Show($"Duzina prvog: {analize.Count()}, Duzina drugog: {analiza2.Count()} Isti su!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
