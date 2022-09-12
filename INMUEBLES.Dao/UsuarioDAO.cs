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
    public class UsuarioDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<UsuarioE> ListadoUsuarios()
        {
            List<UsuarioE> listado = new List<UsuarioE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spUsuario_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    UsuarioE usuarioE = new UsuarioE();
                    usuarioE.idUsuario = Convert.ToInt32(dr["ID"]);
                    usuarioE.email = dr["EMAIL"].ToString();
                    usuarioE.contraseña = dr["CONTRASEÑA"].ToString();
                    usuarioE.propietarioE.nombres = dr["PROPIETARIO"].ToString();

                    listado.Add(usuarioE);
                }
            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }

        public bool AgregarUsuario(UsuarioE usuarioE)
        {
            bool agregado = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spUsuario_Agregar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Size = 30;
                pEmail.Value = usuarioE.email;

                SqlParameter pContraseña = new SqlParameter();
                pContraseña.ParameterName = "@contraseña";
                pContraseña.SqlDbType = SqlDbType.VarChar;
                pContraseña.Size = 30;
                pContraseña.Value = usuarioE.contraseña;
                

                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pContraseña);

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

        public bool ExisteUsuario(string email)
        {
            bool existe = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spUsuario_ExisteUsuario",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Size = 30;
                pEmail.Value = email;

                cmd.Parameters.Add(pEmail);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string emaill = dr["email"].ToString();
                    existe = true;
                }
                cn.Close();
            }
            catch(Exception E)
            {
                throw;
            }
            return existe;
        }
        public string ValidarLogeo(string email, string contraseña)
        {
            string ingresa = "";
            try
            {
                cn.Open();
                cmd = new SqlCommand("spUsuario_Login",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Size = 30;
                pEmail.Value = email;

                SqlParameter pContraseña = new SqlParameter();
                pContraseña.ParameterName = "@contraseña";
                pContraseña.SqlDbType = SqlDbType.VarChar;
                pContraseña.Size = 30;
                pContraseña.Value = contraseña;

                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pContraseña);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    string nombres = dr["NOMBRES"].ToString();
                    string apellidoP = dr["APELLIDO PATERNO"].ToString();
                    string apellidoM = dr["APELLIDO MATERNO"].ToString();

                    ingresa = nombres + " " + apellidoP;
                } 
                cn.Close();
            }
            catch(Exception E)
            {
                throw;
            }
            return ingresa;
        }
        public List<PublicacionE> PublicacionesDeUsuario(string email)
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spUsuario_PublicacionesDeUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Size = 30;
                pEmail.Value = email;

                cmd.Parameters.Add(pEmail);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PublicacionE publicacionE = new PublicacionE();
                    publicacionE.inmuebleE.idInmueble = Convert.ToInt32(dr["ID_INMUEBLE"]);
                    publicacionE.fotoE.FotoURL = dr["URL"].ToString();
                    publicacionE.inmuebleE.distritoE.distrito = dr["DISTRITO"].ToString();
                    publicacionE.inmuebleE.baños = Convert.ToInt32(dr["BAÑOS"]);
                    publicacionE.inmuebleE.dormitorios = Convert.ToInt32(dr["DORMITORIOS"]);
                    publicacionE.inmuebleE.garage = dr["GARAGE"].ToString();
                    publicacionE.inmuebleE.superficie = dr["SUPERFICIE"].ToString();
                    publicacionE.inmuebleE.tipoInmuebleE.descripcion = dr["TIPO"].ToString();
                    publicacionE.inmuebleE.precio = Convert.ToDouble(dr["PRECIO"]);

                    listado.Add(publicacionE);
                }
                cn.Close();

            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }


        public int DameIDpropietario(string email)
        {
            int idPropietario = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spUsuario_DevuelveIDPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Size = 30;
                pEmail.Value = email;

                cmd.Parameters.Add(pEmail);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    idPropietario = Convert.ToInt32(dr["IDPropietario"]);
                }
                cn.Close();
            }
            catch (Exception E)
            {
                throw;
            }
            return idPropietario;
        }
    }
}
