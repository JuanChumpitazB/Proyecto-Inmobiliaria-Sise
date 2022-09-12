using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INMUEBLES.Entidades
{
    public class PublicacionE
    {
        public int idPublicacion { get; set; }
        public InmuebleE inmuebleE = new InmuebleE();
        public FotoE fotoE = new FotoE();
    }
}
