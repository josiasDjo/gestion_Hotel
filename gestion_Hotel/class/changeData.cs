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

            string req = "SELECT * FROM tReserver WHERE idReserver=@idReserver";

            SqlCommand command = new SqlCommand(req, sqlconn.reqSql);

            //command.Parameters.AddWithValue("@idReserver", idReserver);

        }
    }
}
