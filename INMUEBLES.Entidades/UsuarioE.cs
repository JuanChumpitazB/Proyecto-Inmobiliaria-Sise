using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INMUEBLES.Entidades
{
    public class UsuarioE
    {
        public int idUsuario { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public PropietarioE propietarioE = new PropietarioE();
    }
}
