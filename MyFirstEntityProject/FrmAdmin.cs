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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        DBENTITYEntities db = new DBENTITYEntities();   
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.AdminPaneli where x.Kullanici == textBox1.Text && x.Sifre == textBox2.Text select x;
            if(sorgu.Any())
            {
                FrmMenu frm = new FrmMenu();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
