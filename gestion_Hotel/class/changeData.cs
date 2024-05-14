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
        public void ChangeData()
        {
            connexion_BD sqlconn = new connexion_BD();

            string req = "INSERT INTO[dbo].[tReserver] (nom, prenom, sexe, tel, numChambre, typeChambre, montant, datePayement, datePrevu, nombreJours) VALUES(@nom, @prenom, @sexe, @tel, @numChambre, @typeChambre, @montant, @datePayement, @datePrevu, @nombreJours)";

            SqlCommand command = new SqlCommand(req, sqlconn.reqSql);

            //command.Parameters.AddWithValue("@idReserver", idReserver);

        }
    }
}
