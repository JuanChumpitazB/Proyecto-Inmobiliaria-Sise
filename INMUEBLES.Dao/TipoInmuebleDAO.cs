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
    public class TipoInmuebleDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<TipoInmuebleE> ListarTipoInmueble()
        {
            List<TipoInmuebleE> listado = new List<TipoInmuebleE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spTipoInmueble_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    TipoInmuebleE tipoInmuebleE = new TipoInmuebleE();
                    tipoInmuebleE.idTipoInmueble = Convert.ToInt32(dr["ID"]);
                    tipoInmuebleE.descripcion = dr["DESCRIPCION"].ToString();

                    listado.Add(tipoInmuebleE);
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
