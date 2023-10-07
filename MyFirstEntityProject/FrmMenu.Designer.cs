
namespace MyFirstEntityProject
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(114)))));
            this.btnKategori.ForeColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(12, 12);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(185, 172);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategori İşlemleri";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnUrun.Location = new System.Drawing.Point(203, 12);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(185, 172);
            this.btnUrun.TabIndex = 1;
            this.btnUrun.Text = "Ürün İşlemleri";
            this.btnUrun.UseVisualStyleBackColor = false;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.btnİstatistik.ForeColor = System.Drawing.Color.White;
            this.btnİstatistik.Location = new System.Drawing.Point(394, 12);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(185, 172);
            this.btnİstatistik.TabIndex = 2;
            this.btnİstatistik.Text = "İstatistikler";
            this.btnİstatistik.UseVisualStyleBackColor = false;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(588, 194);
            this.Controls.Add(this.btnİstatistik);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnİstatistik;
    }
}