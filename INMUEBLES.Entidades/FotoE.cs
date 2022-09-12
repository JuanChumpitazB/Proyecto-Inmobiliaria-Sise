using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INMUEBLES.Entidades
{
    public class FotoE
    {
        public int idFoto { get; set; }
        public string FotoURL { get; set; }
        public InmuebleE inmuebleE = new InmuebleE();
    }
}
