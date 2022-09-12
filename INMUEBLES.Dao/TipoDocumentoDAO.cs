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
    public class TipoDocumentoDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<TipoDocumentoE> ListarTipoDocumento()
        {
            List<TipoDocumentoE> listado = new List<TipoDocumentoE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spTipoDocumento_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    TipoDocumentoE tipoDocumentoE = new TipoDocumentoE();
                    tipoDocumentoE.idDocumento = Convert.ToInt32(dr["ID"]);
                    tipoDocumentoE.descripcion = dr["DESCRIPCION COMPLETA"].ToString();
                    tipoDocumentoE.descripcionCorta = dr["DESCRIPCION"].ToString();

                    listado.Add(tipoDocumentoE);
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
