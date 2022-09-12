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
    public class PropietarioDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<PropietarioE> ListaPropietario()
        {
            List<PropietarioE> listado = new List<PropietarioE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPropietario_Listar",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    PropietarioE propietarioE = new PropietarioE();
                    propietarioE.idPropietario = Convert.ToInt32(dr["ID"]);
                    propietarioE.nombres = dr["NOMBRES"].ToString();
                    propietarioE.apellidoP = dr["APE. PATERNO"].ToString();
                    propietarioE.apellidoM = dr["APE. MATERNO"].ToString();
                    propietarioE.celular = dr["CELULAR"].ToString();
                    propietarioE.telefono = dr["TELEFONO"].ToString();
                    propietarioE.tipoDocumentoE.descripcionCorta = dr["DESCRIPCION"].ToString();
                    propietarioE.nroDocumento = dr["Nº"].ToString();

                    listado.Add(propietarioE);
                }

            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }

        public bool AgregarPropietario(PropietarioE propietarioE)
        {
            bool agregado = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPropietario_Agregar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pNombres = new SqlParameter();
                pNombres.ParameterName = "@nombre";
                pNombres.SqlDbType = SqlDbType.VarChar;
                pNombres.Size = 45;
                pNombres.Value = propietarioE.nombres;

                SqlParameter pApellidoP = new SqlParameter();
                pApellidoP.ParameterName = "@apellidoP";
                pApellidoP.SqlDbType = SqlDbType.VarChar;
                pApellidoP.Size = 20;
                pApellidoP.Value = propietarioE.apellidoP;

                SqlParameter pApellidoM = new SqlParameter();
                pApellidoM.ParameterName = "@apellidoM";
                pApellidoM.SqlDbType = SqlDbType.VarChar;
                pApellidoM.Size = 20;
                pApellidoM.Value = propietarioE.apellidoM;

                SqlParameter pCelular = new SqlParameter();
                pCelular.ParameterName = "@celular";
                pCelular.SqlDbType = SqlDbType.VarChar;
                pCelular.Size = 15;
                pCelular.Value = propietarioE.celular;

                SqlParameter pTelefono = new SqlParameter();
                pTelefono.ParameterName = "@telefono";
                pTelefono.SqlDbType = SqlDbType.VarChar;
                pTelefono.Size = 12;
                pTelefono.Value = propietarioE.telefono;

                SqlParameter pDocumento = new SqlParameter();
                pDocumento.ParameterName = "@idDocumento";
                pDocumento.SqlDbType = SqlDbType.Int;
                pDocumento.Value = propietarioE.tipoDocumentoE.idDocumento;

                SqlParameter pNroDocumento = new SqlParameter();
                pNroDocumento.ParameterName = "@nroDocumento";
                pNroDocumento.SqlDbType = SqlDbType.VarChar;
                pNroDocumento.Size = 12;
                pNroDocumento.Value = propietarioE.nroDocumento;

                cmd.Parameters.Add(pNombres);
                cmd.Parameters.Add(pApellidoP);
                cmd.Parameters.Add(pApellidoM);
                cmd.Parameters.Add(pCelular);
                cmd.Parameters.Add(pTelefono);
                cmd.Parameters.Add(pDocumento);
                cmd.Parameters.Add(pNroDocumento);

                cmd.ExecuteNonQuery();

                cn.Close();

                agregado = true;
            }
            catch(Exception E)
            {
                throw;
            }
            return agregado;
        }

        public int BuscarIDPropietarioXidInmueble(int idInmueble)
        {
            int idPropietario = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPropietario_BuscarXidInmueble", cn);
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
                    idPropietario = Convert.ToInt32(dr["IDPropietario"]);
                }
                cn.Close();
            }
            catch(Exception)
            {
                throw;
            }
            return idPropietario;
        }
    }
}
