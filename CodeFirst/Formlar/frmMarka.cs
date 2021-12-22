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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmMarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }
       
        private void MarkaListele()
        {
            listView1.Items.Clear();
            var markalistesi = db.TBLMarka.ToList();
            for (int i = 0; i < markalistesi.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markalistesi[i].ID.ToString());
                ekle.SubItems.Add(markalistesi[i].MarkaAdi);
                listView1.Items.Add(ekle);
            }
        }
        void Temizle()
        {
            txtID.Text = txtMarkaAdi.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {//var türünde marka tablosundan nesne türettik türetilen nesnenın  
         //marka ıd sıne eklemeden gelen ıd yı ekledık 
            if (txtMarkaAdi.Text != "")
            {
                var tbl = new Marka();
                tbl.MarkaAdi = txtMarkaAdi.Text;
                db.TBLMarka.Add(tbl);
                db.SaveChanges();
                MessageBox.Show("Araç Markası Başarıyla Eklendi", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MarkaListele();
                Temizle();
            }
          else MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count>0) //seçili ise
            {
                txtID.Text = secilen.SubItems[0].Text;
                txtMarkaAdi.Text = secilen.SubItems[1].Text;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {//list view de seçilen ID ye göre sılme ıslemı yapcak
            if (txtID.Text != "" )
            {
                ListViewItem SecilenID = listView1.SelectedItems[0];
                int secilenID = int.Parse(SecilenID.SubItems[0].Text);
                var sil = db.TBLMarka.FirstOrDefault(x => x.ID == secilenID);
                db.TBLMarka.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("Araç Markası Başarıyla Silindi", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MarkaListele();
                Temizle();
            }
            else MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtMarkaAdi.Text != "")
            {
                int ıd = int.Parse(txtID.Text);
                var guncelle = db.TBLMarka.FirstOrDefault(x => x.ID == ıd);
                guncelle.MarkaAdi = txtMarkaAdi.Text;
                db.SaveChanges();
                MessageBox.Show("Araç Markası Başarıyla Düzenlendi", "DÜZENLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MarkaListele();
                Temizle();
            }
            else MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
