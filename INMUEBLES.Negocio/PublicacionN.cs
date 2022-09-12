using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class PublicacionN
    {
        PublicacionDAO publicacionDAO = new PublicacionDAO();

        public List<PublicacionE> MostrarPublicacionEnVenta()
        {
            return publicacionDAO.MostrarPublicacionEnVenta();
        }
        public List<PublicacionE> MostrarPublicacionEnAlquiler()
        {
            return publicacionDAO.MostrarPublicacionEnAlquiler();
        }
        public List<PublicacionE> MostrarPublicacionEnAlquilerCasa()
        {
            return publicacionDAO.MostrarPublicacionEnAlquilerCasa();
        }
        public List<PublicacionE> MostrarPublicacionEnAlquilerDepartamento()
        {
            return publicacionDAO.MostrarPublicacionEnAlquilerDepartamento();
        }
        public List<PublicacionE> MostrarPublicacionEnAlquilerGarage()
        {
            return publicacionDAO.MostrarPublicacionEnAlquilerGarage();
        }
        public List<PublicacionE> MostrarPublicacionEnAlquilerLocal()
        {
            return publicacionDAO.MostrarPublicacionEnAlquilerLocal();
        }
        public List<PublicacionE> MostrarPublicacionEnAlquilerOficina()
        {
            return publicacionDAO.MostrarPublicacionEnAlquilerOficina();
        }
        public List<PublicacionE> MostrarPublicacionEnVentaApartamento()
        {
            return publicacionDAO.MostrarPublicacionEnVentaApartamento();
        }
        public List<PublicacionE> MostrarPublicacionEnVentaCasa()
        {
            return publicacionDAO.MostrarPublicacionEnVentaCasa();
        }
        public List<PublicacionE> MostrarPublicacionEnVentaOficina()
        {
            return publicacionDAO.MostrarPublicacionEnVentaOficina();
        }
        public List<PublicacionE> MostrarPublicacionEnVentaLocal()
        {
            return publicacionDAO.MostrarPublicacionEnVentaLocal();
        }
        public List<PublicacionE> MostrarPublicacionEnVentaGarage()
        {
            return publicacionDAO.MostrarPublicacionEnVentaGarage();
        }
    }
}
