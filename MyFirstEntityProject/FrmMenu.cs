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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.Show();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            this.Hide();
            frm.Show();
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }
    }
}
