using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using INMUEBLES.Entidades;
using INMUEBLES.Negocio;

namespace INMUEBLES.Presentacion.Controllers
{
    public class InmueblesController : Controller
    {
        // GET: Inmuebles
        InmuebleN inmuebleN = new InmuebleN();

        public ActionResult VerInmueble(int id)
        {
            TipoInmuebleN tipoInmuebleN = new TipoInmuebleN();
            List<TipoInmuebleE> lstTipo= new List<TipoInmuebleE>();
            lstTipo = tipoInmuebleN.ListarTipoInmueble();
            ViewBag.ListaTipo = lstTipo;

            PropietarioN propietarioN = new PropietarioN();
            List<PropietarioE> lstPropietario = new List<PropietarioE>();
            lstPropietario = propietarioN.ListaPropietario();
            ViewBag.ListaPropietario = lstPropietario;

            DistritoN distritoN = new DistritoN();
            List<DistritoE> lstDistrito = new List<DistritoE>();
            lstDistrito = distritoN.ListaDistrito();
            ViewBag.ListaDistrito = lstDistrito;

            OperacionN operacionN = new OperacionN();
            List<OperacionE> lstOperacion = new List<OperacionE>();
            lstOperacion = operacionN.ListadoOperacion();
            ViewBag.ListaOperacion = lstOperacion;

            FotoN fotoN = new FotoN();
            List<FotoE> lstFotoURL = new List<FotoE>();
            lstFotoURL = fotoN.ListarURL_Foto(id);
            ViewBag.ListaURL = lstFotoURL;

            FotoN fotoNn = new FotoN();
            int cantidadFotosXinmueble = fotoNn.CantidadDeFotosXinmueble(id);
            ViewBag.CantidadFotosXinmueble = cantidadFotosXinmueble;

            return View(inmuebleN.BuscarXiD(id));
        }

        public ActionResult ActualizarInmueble(int id)
        {
            FotoN fotoN = new FotoN();
            List<FotoE> lstFotoURL = new List<FotoE>();
            lstFotoURL = fotoN.ListarURL_Foto(id);
            ViewBag.ListaURL = lstFotoURL;

            DistritoN distritoN = new DistritoN();
            List<DistritoE> lstDistrito = new List<DistritoE>();
            lstDistrito = distritoN.ListaDistrito();
            ViewBag.ListaDistrito = lstDistrito;

            TipoInmuebleN tipoInmuebleN = new TipoInmuebleN();
            List<TipoInmuebleE> lstTipoInmueble = new List<TipoInmuebleE>();
            lstTipoInmueble = tipoInmuebleN.ListarTipoInmueble();
            ViewBag.TiposDeInmueble = lstTipoInmueble;

            FotoN fotoNn = new FotoN();
            int cantidadFotosXinmueble = fotoNn.CantidadDeFotosXinmueble(id);
            ViewBag.CantidadFotosXinmueble = cantidadFotosXinmueble;

            PropietarioN propietarioN = new PropietarioN();
            int idPropietario = propietarioN.BuscarIDPropietarioXidInmueble(id);
            ViewBag.IDPropietario = idPropietario;

            OperacionN operacionN = new OperacionN();
            List<OperacionE> lstOperacion = new List<OperacionE>();
            lstOperacion = operacionN.ListadoOperacion();
            ViewBag.ListaOperaciones = lstOperacion;

            return View(inmuebleN.BuscarXiD(id));
        }
        public ActionResult EditarInmueble(int txtID, string txtDireccion,string txtAntiguedad, 
                                string txtSupierficie,int txtBaños, int txtDormitorios, string txtGarage,
                                string txtDescripcion, double txtPrecio,string cboEstado,int cboTipoInmueble,
                                int txtIDPropietario, int cboDistrito, int cboOperacion)
        {
            InmuebleE inmuebleE = new InmuebleE();
            inmuebleE.idInmueble = txtID;
            inmuebleE.direccion = txtDireccion;
            inmuebleE.antiguedad = txtAntiguedad;
            inmuebleE.superficie = txtSupierficie;
            inmuebleE.baños = txtBaños;
            inmuebleE.dormitorios = txtDormitorios;
            inmuebleE.garage = txtGarage;
            inmuebleE.descripcion = txtDescripcion;
            inmuebleE.precio = txtPrecio;
            inmuebleE.estado = cboEstado;
            inmuebleE.tipoInmuebleE.idTipoInmueble = cboTipoInmueble;
            inmuebleE.propietarioE.idPropietario = txtIDPropietario;
            inmuebleE.distritoE.idDistrito = cboDistrito;
            inmuebleE.operacionE.idOperacion = cboOperacion;
            
            string mensaje = "";
            if (inmuebleN.ActualizarInmueble(inmuebleE) == true)
            {
                mensaje = "<script language = 'javascrip' type='text/javascript'" +
                            ">alert('Inmueble Actualizado');" +
                            "window.location.href='/Inmuebles/ActualizarInmueble';" +
                            "</script>";
            }else
            {
                mensaje = "<script language = 'javascrip' type='text/javascript'" +
                            ">alert('ERROR !!!');" +
                            "window.location.href='/Inmuebles/ActualizarInmueble';" +
                            "</script>";
            }
            return Content(mensaje);
        }

        public ActionResult AgregarInmueble(int id)
        {

            ViewBag.idPropietario = id;

            TipoInmuebleN tipoInmuebleN = new TipoInmuebleN();
            List<TipoInmuebleE> lstTipoInmueble = new List<TipoInmuebleE>();
            lstTipoInmueble = tipoInmuebleN.ListarTipoInmueble();
            ViewBag.TiposDeInmueble = lstTipoInmueble;

            DistritoN distritoN = new DistritoN();
            List<DistritoE> lstDistrito = new List<DistritoE>();
            lstDistrito = distritoN.ListaDistrito();
            ViewBag.ListaDistrito = lstDistrito;

            OperacionN operacionN = new OperacionN();
            List<OperacionE> lstOperacion = new List<OperacionE>();
            lstOperacion = operacionN.ListadoOperacion();
            ViewBag.ListaOperaciones = lstOperacion;

            return View();
        }

        public ActionResult InsertarInmueble()
        {
            return ViewBag();
        }
    }
}