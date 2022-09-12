using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace INMUEBLES.Dao
{
    public class OperacionDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<OperacionE> ListadoOperacion()
        {
            List<OperacionE> listado = new List<OperacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spOperacion_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    OperacionE operacionE = new OperacionE();
                    operacionE.idOperacion = Convert.ToInt32(dr["ID"]);
                    operacionE.descripcion = dr["OPERACION"].ToString();

                    listado.Add(operacionE);
                }
                cn.Close();
            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }
    }
}
