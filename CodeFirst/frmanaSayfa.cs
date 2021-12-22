using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class frmanaSayfa : Form
    {
        public frmanaSayfa()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmanaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Formlar.frmMarka marka = new Formlar.frmMarka();
            marka.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void seriTool_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            Formlar.frmMarka marka = new Formlar.frmMarka();
            marka.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DESTEK HATTI 0538-951-99-55", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmPersonel personel = new Formlar.frmPersonel();
            personel.Show();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            Formlar.frmPersonel personel = new Formlar.frmPersonel();
            personel.Show();
        }
    }
}
