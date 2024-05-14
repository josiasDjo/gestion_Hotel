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

            string req = "UPDATE [dbo].[tReserver] SET nom=@nom, prenom=@prenom, sexe=@sexe, tel=@tel, numChambre=@numChambre, typeChambre=@typeChambre, montant=@montant, datePayement=@datePayement, datePrevu=@datePrevu, nombreJours=@nombreJours WHERE idReserver=@idReserver";

            SqlCommand command = new SqlCommand(req, sqlconn.reqSql);

            //command.Parameters.AddWithValue("@idReserver", idReserver);

        }
    }
}
