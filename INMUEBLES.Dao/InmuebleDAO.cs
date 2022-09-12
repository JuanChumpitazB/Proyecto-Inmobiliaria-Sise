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
    public class InmuebleDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();


        public List<InmuebleE> ListadoInmuebles()
        {
            List<InmuebleE> listado = new List<InmuebleE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spInmueble_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    InmuebleE inmuebleE = new InmuebleE();
                    inmuebleE.idInmueble = Convert.ToInt32(dr["ID"]);
                    inmuebleE.direccion = dr["DIRECCION"].ToString();
                    inmuebleE.antiguedad = dr["ANTIGUEDAD"].ToString();
                    inmuebleE.superficie = dr["SUPERFICIE"].ToString();
                    inmuebleE.baños = Convert.ToInt32(dr["BAÑOS"]);
                    inmuebleE.dormitorios = Convert.ToInt32(dr["DORMITORIOS"]);
                    inmuebleE.garage = dr["GARAGE"].ToString();
                    inmuebleE.descripcion = dr["DESCRIPCION"].ToString();
                    inmuebleE.precio = Convert.ToDouble(dr["PRECIO"]);
                    inmuebleE.estado = dr["ESTADO"].ToString();
                    inmuebleE.tipoInmuebleE.descripcion = dr["TIPO"].ToString();
                    inmuebleE.propietarioE.nombres = dr["PROPIETARIO"].ToString();
                    inmuebleE.distritoE.distrito = dr["DISTRITO"].ToString();
                    inmuebleE.operacionE.descripcion = dr["OPERACION"].ToString();

                    listado.Add(inmuebleE);
                }
                cn.Close();
            }
            catch(Exception E)
            {
                throw;
            }
            return listado;
        }

        public bool AgregarInmueble(InmuebleE inmuebleE)
        {
            bool agregado = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spInmueble_Agregar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pDireccion = new SqlParameter();
                pDireccion.ParameterName = "@direccion";
                pDireccion.SqlDbType = SqlDbType.VarChar;
                pDireccion.Size = 65;
                pDireccion.Value = inmuebleE.direccion;

                SqlParameter pAntiguedad = new SqlParameter();
                pAntiguedad.ParameterName = "@antiguedad";
                pAntiguedad.SqlDbType = SqlDbType.VarChar;
                pAntiguedad.Size = 7;
                pAntiguedad.Value = inmuebleE.antiguedad;

                SqlParameter pSuperficie = new SqlParameter();
                pSuperficie.ParameterName = "@superficie";
                pSuperficie.SqlDbType = SqlDbType.VarChar;
                pSuperficie.Size = 15;
                pSuperficie.Value = inmuebleE.superficie;

                SqlParameter pBaños = new SqlParameter();
                pBaños.ParameterName = "@baños";
                pBaños.SqlDbType = SqlDbType.Int;
                pBaños.Value = inmuebleE.baños;

                SqlParameter pDormitorios = new SqlParameter();
                pDormitorios.ParameterName = "@dormitorios";
                pDormitorios.SqlDbType = SqlDbType.Int;
                pDormitorios.Value = inmuebleE.dormitorios;

                SqlParameter pGarage = new SqlParameter();
                pGarage.ParameterName = "@garage";
                pGarage.SqlDbType = SqlDbType.Char;
                pGarage.Size = 2;
                pGarage.Value = inmuebleE.garage;

                SqlParameter pDescripcion = new SqlParameter();
                pDescripcion.ParameterName = "@descripcion";
                pDescripcion.SqlDbType = SqlDbType.VarChar;
                pDescripcion.Size = 200;
                pDescripcion.Value = inmuebleE.descripcion;

                SqlParameter pPrecio = new SqlParameter();
                pPrecio.ParameterName = "@precio";
                pPrecio.SqlDbType = SqlDbType.Decimal;
                pPrecio.Value = inmuebleE.precio;

                SqlParameter pEstado = new SqlParameter();
                pEstado.ParameterName = "@estado";
                pEstado.SqlDbType = SqlDbType.VarChar;
                pEstado.Size = 13;
                pEstado.Value = inmuebleE.estado;

                SqlParameter pIdTipo = new SqlParameter();
                pIdTipo.ParameterName = "@idTipo";
                pIdTipo.SqlDbType = SqlDbType.Int;
                pIdTipo.Value = inmuebleE.tipoInmuebleE.idTipoInmueble;

                SqlParameter pIdPropietario = new SqlParameter();
                pIdPropietario.ParameterName = "@idPropietario";
                pIdPropietario.SqlDbType = SqlDbType.Int;
                pIdPropietario.Value = inmuebleE.propietarioE.idPropietario;

                SqlParameter pIdDistrito = new SqlParameter();
                pIdDistrito.ParameterName = "@idDistrito";
                pIdDistrito.SqlDbType = SqlDbType.Int;
                pIdDistrito.Value = inmuebleE.distritoE.idDistrito;

                SqlParameter pIdOperacion = new SqlParameter();
                pIdDistrito.ParameterName = "@idOperacion";
                pIdDistrito.SqlDbType = SqlDbType.Int;
                pIdDistrito.Value = inmuebleE.operacionE.idOperacion;

                cmd.Parameters.Add(pDireccion);
                cmd.Parameters.Add(pAntiguedad);
                cmd.Parameters.Add(pSuperficie);
                cmd.Parameters.Add(pBaños);
                cmd.Parameters.Add(pDormitorios);
                cmd.Parameters.Add(pGarage);
                cmd.Parameters.Add(pDescripcion);
                cmd.Parameters.Add(pPrecio);
                cmd.Parameters.Add(pEstado);
                cmd.Parameters.Add(pIdTipo);
                cmd.Parameters.Add(pIdPropietario);
                cmd.Parameters.Add(pIdDistrito);
                cmd.Parameters.Add(pIdOperacion);

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

        public InmuebleE BuscarXiD(int idInmueble)
        {
            InmuebleE inmuebleE = new InmuebleE();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spInmueble_BuscarXiD", cn);
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
                    inmuebleE.idInmueble = Convert.ToInt32(dr["ID"]);
                    inmuebleE.direccion = dr["DIRECCION"].ToString();
                    inmuebleE.antiguedad = dr["ANTIGUEDAD"].ToString();
                    inmuebleE.superficie = dr["SUPERFICIE"].ToString();
                    inmuebleE.baños = Convert.ToInt32(dr["BAÑOS"]);
                    inmuebleE.dormitorios = Convert.ToInt32(dr["DORMITORIOS"]);
                    inmuebleE.garage = dr["GARAGE"].ToString();
                    inmuebleE.descripcion = dr["DESCRIPCION"].ToString();
                    inmuebleE.precio = Convert.ToDouble(dr["PRECIO"]);
                    inmuebleE.estado = dr["ESTADO"].ToString();
                    inmuebleE.tipoInmuebleE.descripcion = dr["TIPO"].ToString();
                    inmuebleE.propietarioE.nombres = dr["NOMBRES"].ToString();
                    inmuebleE.propietarioE.apellidoP = dr["APELLIDO PATERNO"].ToString();
                    inmuebleE.propietarioE.apellidoM = dr["APELLIDO MATERNO"].ToString();
                    inmuebleE.distritoE.distrito = dr["DISTRITO"].ToString();
                    inmuebleE.propietarioE.celular = dr["CELULAR"].ToString(); 
                    inmuebleE.propietarioE.telefono = dr["TELEFONO"].ToString();
                    inmuebleE.operacionE.descripcion = dr["OPERACION"].ToString();

                }
                cn.Close();
            }
            catch (Exception E)
            {
                throw;
            }
            return inmuebleE;
        }

        public bool ActualizarInmueble(InmuebleE inmuebleE)
        {
            bool actualizado = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spInmueble_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdInmueble = new SqlParameter();
                pIdInmueble.ParameterName = "@idInmueble";
                pIdInmueble.SqlDbType = SqlDbType.Int;
                pIdInmueble.Value = inmuebleE.idInmueble;

                SqlParameter pDireccion = new SqlParameter();
                pDireccion.ParameterName = "@direccion";
                pDireccion.SqlDbType = SqlDbType.VarChar;
                pDireccion.Size = 65;
                pDireccion.Value = inmuebleE.direccion;

                SqlParameter pAntiguedad = new SqlParameter();
                pAntiguedad.ParameterName = "@antiguedad";
                pAntiguedad.SqlDbType = SqlDbType.VarChar;
                pAntiguedad.Size = 7;
                pAntiguedad.Value = inmuebleE.antiguedad;

                SqlParameter pSuperficie = new SqlParameter();
                pSuperficie.ParameterName = "@superficie";
                pSuperficie.SqlDbType = SqlDbType.VarChar;
                pSuperficie.Size = 15;
                pSuperficie.Value = inmuebleE.superficie;

                SqlParameter pBaños = new SqlParameter();
                pBaños.ParameterName = "@baños";
                pBaños.SqlDbType = SqlDbType.Int;
                pBaños.Value = inmuebleE.baños;

                SqlParameter pDormitorios = new SqlParameter();
                pDormitorios.ParameterName = "@dormitorios";
                pDormitorios.SqlDbType = SqlDbType.Int;
                pDormitorios.Value = inmuebleE.dormitorios;

                SqlParameter pGarage = new SqlParameter();
                pGarage.ParameterName = "@garage";
                pGarage.SqlDbType = SqlDbType.Char;
                pGarage.Size = 2;
                pGarage.Value = inmuebleE.garage;

                SqlParameter pDescripcion = new SqlParameter();
                pDescripcion.ParameterName = "@descripcion";
                pDescripcion.SqlDbType = SqlDbType.VarChar;
                pDescripcion.Size = 200;
                pDescripcion.Value = inmuebleE.descripcion;

                SqlParameter pPrecio = new SqlParameter();
                pPrecio.ParameterName = "@precio";
                pPrecio.SqlDbType = SqlDbType.Decimal;
                pPrecio.Value = inmuebleE.precio;

                SqlParameter pEstado = new SqlParameter();
                pEstado.ParameterName = "@estado";
                pEstado.SqlDbType = SqlDbType.VarChar;
                pEstado.Size = 13;
                pEstado.Value = inmuebleE.estado;

                SqlParameter pIdTipo = new SqlParameter();
                pIdTipo.ParameterName = "@idTipo";
                pIdTipo.SqlDbType = SqlDbType.Int;
                pIdTipo.Value = inmuebleE.tipoInmuebleE.idTipoInmueble;

                SqlParameter pIdPropietario = new SqlParameter();
                pIdPropietario.ParameterName = "@idPropietario";
                pIdPropietario.SqlDbType = SqlDbType.Int;
                pIdPropietario.Value = inmuebleE.propietarioE.idPropietario;

                SqlParameter pIdDistrito = new SqlParameter();
                pIdDistrito.ParameterName = "@idDistrito";
                pIdDistrito.SqlDbType = SqlDbType.Int;
                pIdDistrito.Value = inmuebleE.distritoE.idDistrito;

                SqlParameter pIdOperacion = new SqlParameter();
                pIdOperacion.ParameterName = "@idOperacion";
                pIdOperacion.SqlDbType = SqlDbType.Int;
                pIdOperacion.Value = inmuebleE.operacionE.idOperacion;

                cmd.Parameters.Add(pIdInmueble);
                cmd.Parameters.Add(pDireccion);
                cmd.Parameters.Add(pAntiguedad);
                cmd.Parameters.Add(pSuperficie);
                cmd.Parameters.Add(pBaños);
                cmd.Parameters.Add(pDormitorios);
                cmd.Parameters.Add(pGarage);
                cmd.Parameters.Add(pDescripcion);
                cmd.Parameters.Add(pPrecio);
                cmd.Parameters.Add(pEstado);
                cmd.Parameters.Add(pIdTipo);
                cmd.Parameters.Add(pIdPropietario);
                cmd.Parameters.Add(pIdDistrito);
                cmd.Parameters.Add(pIdOperacion);

                cmd.ExecuteNonQuery();

                actualizado = true;

                cn.Close();
            }
            catch (Exception E)
            {
                throw;
            }
            return actualizado;
        }

        public bool DarDeBajaInmueble(int idInmueble)
        {
            bool dadoDeBaja = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("spInmueble_DarDeBaja", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdInmueble = new SqlParameter();
                pIdInmueble.ParameterName = "@idInmueble";
                pIdInmueble.SqlDbType = SqlDbType.Int;
                pIdInmueble.Value = idInmueble;

                cmd.Parameters.Add(pIdInmueble);

                cmd.ExecuteNonQuery();

                dadoDeBaja = true;
                cn.Close();
            }
            catch(Exception)
            {
                throw;
            }
            return dadoDeBaja;
        }
    }
}
