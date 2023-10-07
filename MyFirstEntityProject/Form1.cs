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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        DBENTITYEntities db = new DBENTITYEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            //Entity Framework yapısıyla listeleme modülü Select ile değil ToList methodu ile olur.
            dataGridView1.DataSource = (from x in db.TBLKategori
                                        select new
                                        {
                                            x.KategoriID,
                                            x.KategoriAD
                                        }).ToString();
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKategori T = new TBLKategori(); //Veri eklemeyi düşündüğün tablonun bağlı olduğu sınıfın içinden nesne türet.
            T.KategoriAD = textBox2.Text;
            db.TBLKategori.Add(T); //Entity Framework yapısıyla ekleme modülü Insert into ile değil Add methodu ile olur.
            db.SaveChanges(); //ExecuteNoneQuary nin entity yapısında karşılığı.
            MessageBox.Show("Kategori Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgri = db.TBLKategori.Find(x); // x'in olduğu satırı hafızaya al.
            db.TBLKategori.Remove(ktgri); //Delete işlemini gören Remove methodu.
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Geçerli bir satır seçildiğinden emin olmak amacıyla yaptım.
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["KategoriID"].Value != null) // "ID" sütunu varsa
                {
                    string idValue = selectedRow.Cells["KategoriID"].Value.ToString();
                    textBox1.Text = idValue;
                    string AdValue = selectedRow.Cells["KategoriAD"].Value.ToString();
                    textBox2.Text = AdValue;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgri = db.TBLKategori.Find(x);
            ktgri.KategoriAD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.Show();
        }
    }
}
