using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class OperacionN
    {
        OperacionDAO operacionDAO = new OperacionDAO();

        public List<OperacionE> ListadoOperacion()
        {
            return operacionDAO.ListadoOperacion();
        }
    }
}
