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
    public class PublicacionDAO
    {
        SqlConnection cn = CONEXION.getConexion();
        SqlCommand cmd = new SqlCommand();

        public List<PublicacionE> MostrarPublicacionEnVenta()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
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

        public List<PublicacionE> MostrarPublicacionEnAlquiler()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnAlquiler", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnAlquilerCasa()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnAlquiler_Casa", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnAlquilerDepartamento()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnAlquiler_Departamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnAlquilerGarage()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnAlquiler_Garage", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnAlquilerLocal()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnAlquiler_Local", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnAlquilerOficina()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnAlquiler_Oficina", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnVentaApartamento()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnVenta_Departamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnVentaCasa()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnVenta_Casa", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnVentaOficina()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnVenta_Oficina", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnVentaLocal()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnVenta_Local", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }

        public List<PublicacionE> MostrarPublicacionEnVentaGarage()
        {
            List<PublicacionE> listado = new List<PublicacionE>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("spPublicacion_MostrarEnVenta_Garage", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception E)
            {
                throw;
            }
            return listado;
        }
    }
}
