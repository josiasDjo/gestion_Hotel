using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_Hotel
{
    public partial class reserver : Form
    {
        public reserver()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            getData();
            //ajouter des utilisateurs !!!  
        }
        public void getData()
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string sexe = txtSexe.Text;
            string phone = txtPhone.Text;
            int numChambre = int.Parse(txtNumChambre.Text);
            string typeChambre = txtTypeChambre.Text;
            int nombreJours = int.Parse(txtNbreJours.Text);
            decimal montant = decimal.Parse(txtMontant.Text);

            MessageBox.Show("Reussi !!!! ");

        }
    }
}
