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

namespace CodeFirst.Formlar
{
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmSeri_Load(object sender, EventArgs e)
        {
            Listele();
            var comboliste = db.TBLMarka.ToList();
            comboBox1.DataSource = comboliste;
            comboBox1.DisplayMember = "MarkaAdi";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedItem = null;
        }

        private void Listele()
        {
            listView1.Items.Clear();
            var liste = from x in db.TBLSeri
                        join y in db.TBLMarka on
   x.MarkaID equals y.ID //databasede birleştirilecek yerler 
                        select new
                        {
                            x.ID,
                            y.MarkaAdi,
                            x.seri
                        };
            foreach (var item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdi);
                viewItem.SubItems.Add(item.seri);
                listView1.Items.Add(viewItem);

            }
        }
        void temizle()
        {
            txtSeri.Text = txtID.Text = comboBox1.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ( txtSeri.Text != "" && comboBox1.Text != "")
            {
                int markaid = (int)comboBox1.SelectedValue;
                var ekle = new Seri();
                ekle.MarkaID = markaid;
                ekle.seri = txtSeri.Text;
                db.TBLSeri.Add(ekle);
                db.SaveChanges();
                temizle();
                Listele();
                MessageBox.Show("Araca Yeni Model Eklendi", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information); comboBox1.SelectedItem = null;
            }
            else MessageBox.Show("BOŞ BIRAKILAN YERLERİ DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //list view de seçilen ID ye göre sılme ıslemı yapcak
            if(txtID.Text!=""&&txtSeri.Text!=""&&comboBox1.Text!="")
             {
                ListViewItem SecilenID = listView1.SelectedItems[0];
                int secilenID = int.Parse(SecilenID.SubItems[0].Text);
                var sil = db.TBLSeri.FirstOrDefault(x => x.ID == secilenID);
                db.TBLSeri.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("Araç Modeli Başarıyla Silindi", "MODEL SİL", MessageBoxButtons.OK, MessageBoxIcon.Information); comboBox1.SelectedItem = null;
                Listele();
                temizle();
            }
            else MessageBox.Show("BOŞ BIRAKILAN YERLERİ DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtSeri.Text != "" && comboBox1.Text != "")
            {
                int ıd = int.Parse(txtID.Text);
                var guncelle = db.TBLSeri.FirstOrDefault(x => x.ID == ıd);
                guncelle.MarkaID = (int)comboBox1.SelectedValue;
                guncelle.seri = txtSeri.Text;
                db.SaveChanges();
                MessageBox.Show("Araç Modeli Başarıyla Düzenlendi", "DÜZENLE", MessageBoxButtons.OK, MessageBoxIcon.Information); comboBox1.SelectedItem = null;
                Listele();
                temizle();
            }
            else MessageBox.Show("BOŞ BIRAKILAN YERLERİ DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0) //seçili ise
            {
                txtID.Text = secilen.SubItems[0].Text;
                comboBox1.Text = secilen.SubItems[1].Text;
                txtSeri.Text = secilen.SubItems[2].Text;

            }
        }
    }
}
