using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_Hotel
{
    class connexion_BD
    {
        public SqlConnection reqSql;

        public void sendConn()
        {
            string connexion = "Data Source=DJODEV;Initial Catalog=db_reservaton;Integrated Security=True";
            try
            {
                reqSql = new SqlConnection(connexion);
                reqSql.Open();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
        }
    }
}
