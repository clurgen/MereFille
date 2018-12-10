using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mere
{
    public partial class FFilles : Form
    {
        private string monNom;
        private FMere maMere;

        public FFilles(FMere maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            btnMaMere.Click += new EventHandler (btnMaMere_Click);
            this.FormClosing += new FormClosingEventHandler(FFilles_FormClosing);
            this.Load += new EventHandler(FFilles_Load);
            btnChanger.Click += new EventHandler(btnChanger_Click);
            /*this.tbChangeNom.TextChanged += new EventHandler(btnChanger_Click);*/
             
            

        }
        void btnMaMere_Click(object sender, EventArgs e)
        {
            FMere maman = new FMere();
            MessageBox.Show("Ma mere est: " + maman.GetNomMere);
        }
        public void FFilles_FormClosing(object sender, FormClosingEventArgs e) 
        {
            e.Cancel = true;
            this.Hide();
        }
        void FFilles_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur"+this.monNom);
        }
        void btnChanger_Click(object sender, EventArgs e)
        {   
            monNom = tbChangeNom.Text;
            this.Text = tbChangeNom.Text;
            maMere.MaFilleChangeDeNom(this,monNom);
        }

    }
}
