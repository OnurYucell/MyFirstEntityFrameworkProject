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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DBENTITYEntities db = new DBENTITYEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKategori.Count().ToString();
            label3.Text = db.TBLUrun.Count().ToString();
            label5.Text = db.TBLMusteri.Count(x =>/*Lambda işareti*/ x.Durum == true).ToString();
            label9.Text = db.TBLUrun.Sum(x => x.Stok).ToString();
            label27.Text = db.TBLSatis.Sum(x => x.Fiyat).ToString() + " TL";
            label17.Text = (from x in db.TBLUrun orderby x.Fiyat descending select x.Fiyat).FirstOrDefault().ToString();//Sıralamada ilk olanı getirmek.
            label29.Text = (from x in db.TBLUrun orderby x.Fiyat ascending select x.Fiyat).FirstOrDefault().ToString();
            label7.Text = db.TBLMusteri.Count(x => x.Durum == false).ToString();
            label11.Text = db.TBLUrun.Count(x=>x.Kategori==1).ToString();
            label13.Text = db.TBLUrun.Count(x => x.Kategori == 2).ToString();
            label15.Text = db.TBLUrun.Count(x => x.Kategori == 7).ToString();
            label19.Text = db.TBLUrun.Count(x => x.Kategori == 5).ToString();
            label21.Text = db.TBLUrun.Count(x => x.Kategori == 4).ToString();
            label23.Text = db.TBLUrun.Count(x => x.Kategori == 6).ToString();
            label25.Text = (from x in db.TBLMusteri select x.Sehir).Distinct().Count().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
