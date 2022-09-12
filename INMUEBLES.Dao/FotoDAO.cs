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
    public class FotoDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<FotoE> ListadoFotos()
        {
            List<FotoE> listado = new List<FotoE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spFoto_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    FotoE fotoE = new FotoE();
                    fotoE.idFoto = Convert.ToInt32(dr["ID"]);
                    fotoE.FotoURL = dr["URL"].ToString();
                    fotoE.inmuebleE.descripcion = dr["DESCRIPCION"].ToString();

                    listado.Add(fotoE);
                } 
            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }

        public bool AgregarFoto(FotoE fotoE)
        {
            bool agregado = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spFoto_Agregar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pFotoURL = new SqlParameter();
                pFotoURL.ParameterName = "@FotoURL";
                pFotoURL.SqlDbType = SqlDbType.VarChar;
                pFotoURL.Value = fotoE.FotoURL;
                
                cmd.Parameters.Add(pFotoURL);

                cmd.ExecuteNonQuery();

                agregado = true;

                cn.Close();
            }
            catch(Exception E)
            {
                throw;
            }
            return agregado;
        }



        public List<FotoE> ListarURL_Foto(int idInmueble)
        {
            List<FotoE> listado = new List<FotoE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spFoto_ListarURLxIDInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdInmueble = new SqlParameter();
                pIdInmueble.ParameterName = "@idInmueble";
                pIdInmueble.SqlDbType = SqlDbType.Int;
                pIdInmueble.Value = idInmueble;

                cmd.Parameters.Add(pIdInmueble);

                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    FotoE fotoE = new FotoE();
                    fotoE.FotoURL = dr["URL"].ToString();

                    listado.Add(fotoE);
                }
                cn.Close();
            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }

        public int CantidadDeFotosXinmueble(int idInmueble)
        {
            int cantidad = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spFoto_CantidadDeFotosXInmueble",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdInmueble = new SqlParameter();
                pIdInmueble.ParameterName = "@idInmueble";
                pIdInmueble.SqlDbType = SqlDbType.Int;
                pIdInmueble.Value = idInmueble;

                cmd.Parameters.Add(pIdInmueble);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cantidad = Convert.ToInt32(dr["CANTIDAD"]);
                }
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return cantidad;
        }
    }
}
