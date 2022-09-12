using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class TipoDocumentoN
    {
        TipoDocumentoDAO tipoDocumentoDAO = new TipoDocumentoDAO();

        public List<TipoDocumentoE> ListarTipoDocumento()
        {
            return tipoDocumentoDAO.ListarTipoDocumento();
        }
    }
}
