using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class InmuebleN
    {
        InmuebleDAO inmuebleDAO = new InmuebleDAO();

        public List<InmuebleE> ListadoInmuebles()
        {
            return inmuebleDAO.ListadoInmuebles();
        }
        public bool AgregarInmueble(InmuebleE inmuebleE)
        {
            return inmuebleDAO.AgregarInmueble(inmuebleE);
        }
        public InmuebleE BuscarXiD(int idInmueble)
        {
            return inmuebleDAO.BuscarXiD(idInmueble);
        }
        public bool ActualizarInmueble(InmuebleE inmuebleE)
        {
            return inmuebleDAO.ActualizarInmueble(inmuebleE);
        }
        public bool DarDeBajaInmueble(int idInmueble)
        {
            return inmuebleDAO.DarDeBajaInmueble(idInmueble);
        }
    }
}
