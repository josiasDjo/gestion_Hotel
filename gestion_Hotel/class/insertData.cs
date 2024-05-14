using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_Hotel
{
    public partial class reserver
    {

        public void getDataTwo()
        {
            connexion_BD sqlconn = new connexion_BD();
            sqlconn.sendConn();
            DateTime dt = DateTime.Now;

            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string sexe = txtSexe.Text;
            string phone = txtPhone.Text;
            int numChambre = int.Parse(txtNumChambre.Text);
            string typeChambre = txtTypeChambre.Text;
            int nombreJours = int.Parse(txtNbreJours.Text);
            decimal montant = decimal.Parse(txtMontant.Text);
            string datePayement = dt.ToString();
            string datePrevu = txtDatePrevu.Text;


            try
            {

                string querryInsert = "INSERT INTO[dbo].[tReserver] (nom, prenom, sexe, tel, numChambre, typeChambre, montant, datePayement, datePrevu, nombreJours) VALUES(@nom, @prenom, @sexe, @tel, @numChambre, @typeChambre, @montant, @datePayement, @datePrevu, @nombreJours)";


                SqlCommand command = new SqlCommand(querryInsert, sqlconn.reqSql);

                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@Sexe", sexe);
                command.Parameters.AddWithValue("@Tel", phone);


                command.Parameters.AddWithValue("@numChambre", numChambre);
                command.Parameters.AddWithValue("@typeChambre", typeChambre);

                command.Parameters.AddWithValue("@montant", montant);
                command.Parameters.AddWithValue("@datePayement", datePayement);

                command.Parameters.AddWithValue("@datePrevu", datePrevu.ToString());
                command.Parameters.AddWithValue("@nombreJours", nombreJours);


                command.ExecuteNonQuery();


                MessageBox.Show("Enregistrement réussi !! ");
                sqlconn.reqSql.Close();
                command.Dispose();
                afficherDataInGrid();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Une erreur est survenue ! " + exc);
            }
            finally
            {
                if (sqlconn.reqSql != null && sqlconn.reqSql.State == ConnectionState.Open)
                {
                    sqlconn.reqSql.Close();
                }
            }
        }

        public void insererInDb()
        {
            
        }
    }
}
