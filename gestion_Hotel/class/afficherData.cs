using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_Hotel
{
    public partial class reserver
    {
        public void afficherDataInGrid()
        {
            connexion_BD sqlconn = new connexion_BD();
            sqlconn.sendConn();

            string req = "SELECT * FROM tReserver";

            using (SqlCommand command = new SqlCommand(req, sqlconn.reqSql))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
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


                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(idReserverbd, nombd, prenombd, sexebd, telbd, numChambrebd, nombreJoursbd, typeChambrebd, montantbd, datePrevubd);

                    }
                }
            }
        }
    }
}
