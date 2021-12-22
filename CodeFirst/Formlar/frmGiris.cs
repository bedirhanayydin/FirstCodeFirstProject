using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst.Formlar
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        int hak = 5;

        int sayac = 20;
        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtKadi.Text = "admin";
            txtSifre.Text = "admin";
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "")
                txtKadi.Focus();
            else if (txtSifre.Text == "")
                txtSifre.Focus();
            else if (txtKadi.Text == "admin" && txtSifre.Text == "admin")
            {
                timer1.Stop();
                MessageBox.Show("Hoşgeldiniz");
                frmanaSayfa frm = new frmanaSayfa();
                frm.Show();
                this.Hide();

            }
            else
            {
                hak--;
                if (hak > 0)
                    MessageBox.Show("Hatalı Giriş\nKalan Hakkınız..:" + hak);
                else
                {
                    MessageBox.Show("Hakkınız Bitti.\nProgram sonlandırılıyor");
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            if (sayac > 0)
                lblSayac.Text = sayac.ToString();
            else if (sayac == 0)
            {
                lblSayac.Text = "Süreniz Dolmuştur";
                btnGiris.Enabled = false;
                txtKadi.Enabled = false;
                txtSifre.Enabled = false;
                //timer1.Stop();
            }
            else if (sayac == -2)
            {
                lblSayac.Text = "Program Kapatılıyor...";
            }
            else if (sayac == -3)
                Application.Exit();
        }

        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
    }
