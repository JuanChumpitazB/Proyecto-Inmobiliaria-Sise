using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using INMUEBLES.Entidades;
using INMUEBLES.Negocio;

namespace INMUEBLES.Presentacion.Controllers
{
    public class PropietarioController : Controller
    {
        // GET: Propietario
        PropietarioN propietarioN = new PropietarioN();
        UsuarioN usuarioN = new UsuarioN();

        public ActionResult RegistrarPropietario()
        {
            TipoDocumentoN tipoDocumentoN = new TipoDocumentoN();
            List<TipoDocumentoE> lstDocumento = new List<TipoDocumentoE>();
            lstDocumento = tipoDocumentoN.ListarTipoDocumento();
            ViewBag.ListaDocumento = lstDocumento;

            return View();
        }

        public ActionResult Insertar(string txtNombres, string txtApellidoP, string txtApellidoM, 
                                string txtCelular, string txtTelefono, int cboDocumento, 
                                string txtNroDocumento , string txtEmail, string txtContraseña)
        {

            PropietarioE propietarioE = new PropietarioE();
            propietarioE.nombres = txtNombres;
            propietarioE.apellidoP = txtApellidoP;
            propietarioE.apellidoM = txtApellidoM;
            propietarioE.celular= txtCelular;
            propietarioE.telefono = txtTelefono;
            propietarioE.tipoDocumentoE.idDocumento = cboDocumento;
            propietarioE.nroDocumento = txtNroDocumento;

            string mensaje = "";

            if (propietarioN.AgregarPropietario(propietarioE)==true)
            {
                UsuarioE usuarioE = new UsuarioE();
                usuarioE.email = txtEmail;
                usuarioE.contraseña = txtContraseña;
                usuarioN.AgregarUsuario(usuarioE);

                mensaje = "<script language = 'javascrip' type='text/javascript'"+
                            ">alert('REGISTRADO, INGRESE CON SU EMAIL Y CONTRASEÑA');" + 
                            "window.location.href='/Publicacion/Inicio';"+
                            "</script>";
            }
            else
            {
                mensaje = "<script language = 'javascrip' type='text/javascript'" +
                            ">alert('ERROR!!!! NO Registrado');" +
                            "window.location.href='/Propietario/RegistrarPropietario';" +
                            "</script>";
            }

            return Content(mensaje);
        }
    }
}