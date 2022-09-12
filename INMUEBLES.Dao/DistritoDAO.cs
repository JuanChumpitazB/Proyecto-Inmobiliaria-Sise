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
    public class DistritoDAO
    {

        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<DistritoE> ListaDistrito()
        {
            List<DistritoE> listado = new List<DistritoE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spDistrito_Listar",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    DistritoE distritoE = new DistritoE();
                    distritoE.idDistrito = Convert.ToInt32(dr["ID"]);
                    distritoE.distrito = dr["DISTRITO"].ToString();

                    listado.Add(distritoE);
                }
            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }
    }
}
