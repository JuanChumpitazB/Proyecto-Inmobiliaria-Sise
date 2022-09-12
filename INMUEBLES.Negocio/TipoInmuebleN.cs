using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class TipoInmuebleN
    {
        TipoInmuebleDAO tipoInmuebleDAO = new TipoInmuebleDAO();
        public List<TipoInmuebleE> ListarTipoInmueble()
        {
            return tipoInmuebleDAO.ListarTipoInmueble();
        }
    }
}
