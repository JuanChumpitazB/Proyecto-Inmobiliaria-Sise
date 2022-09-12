using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class DistritoN
    {
        DistritoDAO distritoDAO = new DistritoDAO();

        public List<DistritoE> ListaDistrito()
        {
            return distritoDAO.ListaDistrito();
        }

    }
}
