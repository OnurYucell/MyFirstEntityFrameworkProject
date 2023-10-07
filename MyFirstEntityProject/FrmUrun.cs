using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstEntityProject
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtAD.Clear();
            txtID.Clear();
            txtDURUM.Clear();
            txtFIYAT.Clear();
            txtMARKA.Clear();
            txtSTOK.Clear();
            cmbKATEGORI.Text = " ";
        }

        DBENTITYEntities db = new DBENTITYEntities();
        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.Show();
        }
        Form1 form = new Form1();

        private void btnListele_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = (from i in db.TBLUrun
                                        select new
                                        {
                                            i.UrunID,
                                            i.UrunAD,
                                            i.Marka,
                                            i.Stok,
                                            i.Fiyat,
                                            i.Durum,
                                            i.TBLKategori.KategoriAD //Listede kategori numarası yerine adını çağırma.
                                        }).ToList();
            temizle();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Geçerli bir satır seçildiğinden emin olmak amacıyla yaptım.
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["UrunID"].Value != null) // "ID" sütunu varsa
                {
                    string idValue = selectedRow.Cells["UrunID"].Value.ToString();
                    txtID.Text = idValue;
                    string AdValue = selectedRow.Cells["UrunAD"].Value.ToString();
                    txtAD.Text = AdValue;
                    string MarkaValue = selectedRow.Cells["Marka"].Value.ToString();
                    txtMARKA.Text = MarkaValue;
                    string StokValue = selectedRow.Cells["Stok"].Value.ToString();
                    txtSTOK.Text = StokValue;
                    string FiyatValue = selectedRow.Cells["Fiyat"].Value.ToString();
                    txtFIYAT.Text = FiyatValue;
                    string DurumValue = selectedRow.Cells["Durum"].Value.ToString();
                    txtDURUM.Text = DurumValue;
                    string KategoriValue = selectedRow.Cells["Kategori"].Value.ToString();
                    cmbKATEGORI.Text = KategoriValue;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(txtID.Text);
            var urun = db.TBLUrun.Find(y);
            db.TBLUrun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLUrun u = new TBLUrun();
            u.UrunAD = txtAD.Text;
            u.Marka = txtMARKA.Text;
            u.Stok = short.Parse(txtSTOK.Text);
            u.Kategori = int.Parse(cmbKATEGORI.Text);
            u.Fiyat = Decimal.Parse(txtFIYAT.Text);
            u.Durum = true;
            db.TBLUrun.Add(u);
            db.SaveChanges();
            temizle();

            MessageBox.Show("Ürün Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(txtID.Text);
            var urun = db.TBLUrun.Find(y);
            urun.UrunAD = txtAD.Text;
            urun.Marka = txtMARKA.Text;
            urun.Stok = short.Parse(txtSTOK.Text);
            urun.Kategori = int.Parse(cmbKATEGORI.SelectedValue.ToString()); //Combobox da seçilen kategorinin ıd değerininekler.
            urun.Fiyat = Decimal.Parse(txtFIYAT.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKategori
                               select new
                               {
                                   x.KategoriID,
                                   x.KategoriAD
                               }
                              ).ToList();//Combobox un içine kategori tablosundan değer çekme.
            cmbKATEGORI.ValueMember = "KategoriID"; //Arkaplanda çalışacak değer.
            cmbKATEGORI.DisplayMember = "KategoriAD"; //Bana gözükecek değer.
            cmbKATEGORI.DataSource = kategoriler;
        }
    }
}
