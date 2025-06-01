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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            frmAnaliza frmAnaliza = new frmAnaliza();
            frmAnaliza.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMasterDetalji frmMasterDetalji = new frmMasterDetalji();
            frmMasterDetalji.ShowDialog();  
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {

        }
    }
}
