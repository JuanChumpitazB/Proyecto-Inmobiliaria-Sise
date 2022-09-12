using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INMUEBLES.Entidades
{
    public class InmuebleE
    {
        public int idInmueble { get; set; }
        public string direccion { get; set; }
        public string antiguedad { get; set; }
        public string superficie { get; set; }
        public int baños { get; set; }
        public int dormitorios { get; set; }
        public string garage { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string estado { get; set; }
        public TipoInmuebleE tipoInmuebleE = new TipoInmuebleE();
        public PropietarioE propietarioE = new PropietarioE();
        public DistritoE distritoE = new DistritoE();
        public OperacionE operacionE = new OperacionE();
    }
}
