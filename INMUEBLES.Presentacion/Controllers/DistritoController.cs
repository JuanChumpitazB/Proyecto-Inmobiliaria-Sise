using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using INMUEBLES.Entidades;
using INMUEBLES.Negocio;

namespace INMUEBLES.Presentacion.Controllers
{
    public class DistritoController : Controller
    {
        // GET: Distrito
        DistritoN distritoN = new DistritoN();
        public ActionResult Listado()
        {
            return View(distritoN.ListaDistrito());
        }
    }
}