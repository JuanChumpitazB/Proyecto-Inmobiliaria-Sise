using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using INMUEBLES.Entidades;
using INMUEBLES.Negocio;

namespace INMUEBLES.Presentacion.Controllers
{
    public class FotoController : Controller
    {
        // GET: Foto
        FotoN fotoN = new FotoN();

        public ActionResult Inicio()
        {
            InmuebleN inmuebleN = new InmuebleN();
            List<InmuebleE> lstInmuebles = new List<InmuebleE>();
            lstInmuebles = inmuebleN.ListadoInmuebles();
            ViewBag.ListaInmuebles = lstInmuebles;

            return View(fotoN.ListadoFotos());
        }
    }
}