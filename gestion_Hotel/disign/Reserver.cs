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
            afficherDataInGrid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            getDataTwo();
            //ajouter des utilisateurs !!!  
        }

        private void txtTypeChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeChambre = txtTypeChambre.Text;
            int nombreJours = int.Parse(txtNbreJours.Text);
            

            if (typeChambre == "Standard")
            {
                int resultat = 15 * nombreJours;
                txtMontant.Text = resultat.ToString();
            } else if (typeChambre == "VIP")
            {
                int resultat = 25 * nombreJours;
                txtMontant.Text = resultat.ToString();
            } else
            {
                txtMontant.Text = "Choisisez entre VIP et Standard";
            }
        }

        private void searchOption_TextChanged(object sender, EventArgs e)
        {
            //string searchData = searchOption.Text;
            rechercher();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ChangeData();
        }
    }
}
