using CodeFirst.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // regular expressions regex ile email kontrolu ıcın ımport ettım

namespace CodeFirst.Formlar
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

    
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLPersonel.ToList();
        }
        void temizle()
        {
            foreach(Control item in Controls) // controlleri temizlemek için
            {
                if(item is TextBox)//itemler textbox ise içeriğini temizle
                {
                    item.Text = "";

                }
                txtTelefon.Text = "";
                pictureBox1.ImageLocation = "";
                dateTimePicker2.Value = DateTime.Now;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          //  Regex regex = new Regex(@"\d{5}");
           // bool regex = Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            var ekle = new Personel();
            if (txtEmail.Text!="" && txtAdiSoyadi.Text != ""&& txtAdres.Text != "" && txtTelefon.Text != "" )
            { ekle.Adisoyadi = txtAdiSoyadi.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.Adres = txtAdres.Text;      
                ekle.Email = txtEmail.Text;
            ekle.Resim = pictureBox1.ImageLocation;
            ekle.Tarih = dateTimePicker2.Value;
            MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.TBLPersonel.Add(ekle);
            db.SaveChanges();
            temizle();
            txtID.Enabled = false;
            dataGridView1.DataSource = db.TBLPersonel.ToList();
        }
            else MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ.", "UYARI", MessageBoxButtons.OK);
           
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //datagrıdwıevdekı secıleni silsin
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.TBLPersonel.FirstOrDefault(x=>x.ID==id);
            db.TBLPersonel.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            temizle();
            txtID.Enabled = false;
            dataGridView1.DataSource = db.TBLPersonel.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            // tek bır eleman döncegı ıcın fırstor default kullanıldı
            var guncelle = db.TBLPersonel.FirstOrDefault(x => x.ID == id);
            guncelle.Adisoyadi = txtAdiSoyadi.Text;
            guncelle.Telefon = txtTelefon.Text;
            guncelle.Adres = txtAdres.Text;
            guncelle.Email = txtEmail.Text;
            guncelle.Resim = pictureBox1.ImageLocation;
            guncelle.Tarih = dateTimePicker2.Value;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            txtID.Enabled = false;
            dataGridView1.DataSource = db.TBLPersonel.ToList();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.TBLPersonel
                      where x.ID.ToString() == txtID.Text
                      select x;
            foreach (var item in ara)
            {
                txtAdiSoyadi.Text = item.Adisoyadi;
                txtTelefon.Text = item.Telefon;
                txtAdres.Text = item.Adres;
                txtEmail.Text = item.Email;
                pictureBox1.ImageLocation = item.Resim;
                dateTimePicker2.Value = item.Tarih;
            }
            if (txtID.Text == "")
            {
                temizle();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            txtID.Enabled = false;
        }
    }
}
