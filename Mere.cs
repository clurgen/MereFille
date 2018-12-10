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
    public partial class FMere : Form
    {
        private List<FFilles> lesFilles;
        private int nombreFille;
        private string nomMere;
        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFilles>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnShow.Click += new EventHandler (btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);

        }
        void btnNew_Click(object sender, EventArgs e)
        {
            FFilles nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFilles(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }
        public string GetNomMere
        {
            get
            {
                return this.nomMere;
            }
        }
        void btnShow_Click(object sender, EventArgs e) 
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }
        void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }
        void btnClose_Click(object sender, EventArgs e) 
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Close();
                lesFilles.RemoveAt(lbLesFilles.SelectedIndex);
                lbLesFilles.Items.RemoveAt(lbLesFilles.SelectedIndex);
            }

        }
        void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }
        }
        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille à été instancié");
        }
        public void MaFilleChangeDeNom(FFilles ffille, string nouveauNom) 
        {
            int position = lesFilles.IndexOf(ffille);
            if (position != -1)
            {
                lesFilles[position] = ffille;
                lbLesFilles.Items[position] = nouveauNom;
            }
        }
        
    }
}
