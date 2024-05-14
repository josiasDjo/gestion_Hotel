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
        public void rechercher()
        {
            connexion_BD sqlconn = new connexion_BD();
            sqlconn.sendConn();
            string searchD = searchOption.Text;

            string req = "SELECT * FROM tReserver WHERE ";
            req += "nom LIKE @search OR prenom LIKE @search OR tel LIKE @search OR numChambre LIKE @search OR typeChambre LIKE @search OR montant LIKE @search OR datePrevu LIKE @search OR nombreJours LIKE @search";

            SqlCommand command = new SqlCommand(req, sqlconn.reqSql);

            command.Parameters.AddWithValue("@search", "%" + searchD + "%");

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();
                    while (reader.Read())
                    {
                        string idReserverbd = reader["idReserver"].ToString();
                        string nombd = reader["nom"].ToString();
                        string prenombd = reader["prenom"].ToString();
                        string sexebd = reader["sexe"].ToString();
                        string telbd = reader["tel"].ToString();

                        string numChambrebd = reader["numChambre"].ToString();
                        string typeChambrebd = reader["typeChambre"].ToString();

                        string montantbd = reader["montant"].ToString();

                        string datePrevubd = reader["datePrevu"].ToString();
                        string nombreJoursbd = reader["nombreJours"].ToString();

                        dataGridView1.Rows.Add(idReserverbd, nombd, prenombd, sexebd, telbd, numChambrebd, nombreJoursbd, typeChambrebd, montantbd, datePrevubd);

                    }
                }
            } catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            } finally
            {
                if (sqlconn.reqSql != null && sqlconn.reqSql.State == ConnectionState.Open)
                {
                    sqlconn.reqSql.Close();
                }
            }
        }
    }
}
