using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using INMUEBLES.Entidades;
using INMUEBLES.Negocio;

namespace INMUEBLES.Presentacion.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        UsuarioN usuarioN = new UsuarioN();

        [Route("Loguear")]
        public ActionResult Logear()
        {
            return View();
        }
        public ActionResult Publicaciones(string txtEmail, string txtContraseña)
        {
            string mensaje = "";

            if (usuarioN.ExisteUsuario(txtEmail) == true)
            {
                if (!(usuarioN.ValidarLogeo(txtEmail, txtContraseña).Equals("")))
                {
                    UsuarioN usuarN = new UsuarioN();
                    string usu = usuarN.ValidarLogeo(txtEmail,txtContraseña);
                    ViewBag.UsuarioLogueado = usu;

                    UsuarioN usurioN = new UsuarioN();
                    List<PublicacionE> lstPublicaciones = new List<PublicacionE>();
                    lstPublicaciones = usuarioN.PublicacionesDeUsuario(txtEmail);
                    ViewBag.ListaPublicaciones = lstPublicaciones;

                    UsuarioN usuaN = new UsuarioN();
                    int idPropietario = usuaN.DameIDpropietario(txtEmail);
                    ViewBag.IDPropietario = idPropietario;

                    return View(usuarioN.PublicacionesDeUsuario(txtEmail));
                }
                else
                {
                    mensaje = "<script language = 'javascrip' type='text/javascript'" +
                           ">alert('CONTRASEÑA INVALIDA');" +
                           "window.location.href='/Publicacion/Inicio';" +
                           "</script>";
                }

            }
            else
            {
                mensaje = "<script language = 'javascrip' type='text/javascript'" +
                           ">alert('USUARIO NO REGISTRADO');" +
                           "window.location.href='/Publicacion/Inicio';" +
                           "</script>";
            }

            return Content(mensaje);
        }
        
    }
}