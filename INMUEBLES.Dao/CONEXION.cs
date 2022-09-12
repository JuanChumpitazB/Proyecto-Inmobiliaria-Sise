using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using INMUEBLES.Entidades;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace INMUEBLES.Dao
{
    public class CONEXION
    {
        public static SqlConnection getConexion()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            }
            catch(Exception E)
            {
                throw;
            }
            return cn;
        }
    }
}
