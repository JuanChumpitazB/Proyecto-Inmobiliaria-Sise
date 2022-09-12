using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class UsuarioN
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public List<UsuarioE> ListadoUsuarios()
        {
            return usuarioDAO.ListadoUsuarios();
        }
        public bool AgregarUsuario(UsuarioE usuarioE)
        {
            return usuarioDAO.AgregarUsuario(usuarioE);
        }
        public bool ExisteUsuario(string email)
        {
            return usuarioDAO.ExisteUsuario(email);
        }
        public string ValidarLogeo(string email, string contraseña)
        {
            return usuarioDAO.ValidarLogeo(email,contraseña);
        }
        public List<PublicacionE> PublicacionesDeUsuario(string email)
        {
            return usuarioDAO.PublicacionesDeUsuario(email);
        }
        public int DameIDpropietario(string email)
        {
            return usuarioDAO.DameIDpropietario(email);
        }
    }
}
