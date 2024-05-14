using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_Hotel
{
    public partial class reserver
    {
        public void ChangeData()
        {
            reserver rsv = new reserver();
            connexion_BD sqlconn = new connexion_BD();
            //string idReserverS = rsv.idReserverbd;
            //MessageBox.Show("Id : " + idReserverS);

            string reqGetId = "SELECT * FROM [dbo].[tReserver]";
            string req = "UPDATE [dbo].[tReserver] SET nom=@nom, prenom=@prenom, sexe=@sexe, tel=@tel, numChambre=@numChambre, typeChambre=@typeChambre, montant=@montant, datePayement=@datePayement, datePrevu=@datePrevu, nombreJours=@nombreJours WHERE idReserver=@idReserver";

            SqlCommand command = new SqlCommand(req, sqlconn.reqSql);

            //command.Parameters.AddWithValue("@idReserver", idReserver);

        }
    }
}
