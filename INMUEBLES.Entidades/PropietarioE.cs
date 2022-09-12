using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INMUEBLES.Entidades
{
    public class PropietarioE
    {
        public int idPropietario { get; set; }
        public string nombres { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string celular { get; set; }
        public string telefono { get; set; }

        public TipoDocumentoE tipoDocumentoE = new TipoDocumentoE();
        public string nroDocumento { get; set; }
    }
}
