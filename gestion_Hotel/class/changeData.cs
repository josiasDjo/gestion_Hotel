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
            sqlconn.sendConn();


            string reqGetId = "SELECT * FROM [dbo].[tReserver]";

            SqlCommand commandGet = new SqlCommand(reqGetId, sqlconn.reqSql);

            string idReserverS;

            using (SqlDataReader rd = commandGet.ExecuteReader())
            {
                while (rd.Read())
                {
                    idReserverS = rd["idReserver"].ToString();

                    MessageBox.Show("Id : " + idReserverS);

                }
            }


            string req = "UPDATE [dbo].[tReserver] SET nom=@nom, prenom=@prenom, sexe=@sexe, tel=@tel, numChambre=@numChambre, typeChambre=@typeChambre, montant=@montant, datePayement=@datePayement, datePrevu=@datePrevu, nombreJours=@nombreJours WHERE idReserver=@idReserver";

            SqlCommand command = new SqlCommand(req, sqlconn.reqSql);

            //command.Parameters.AddWithValue("@idReserver", idReserver);

        }
    }
}
