using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using INMUEBLES.Entidades;
using INMUEBLES.Negocio;

namespace INMUEBLES.Presentacion.Controllers
{
    public class PublicacionController : Controller
    {
        // GET: Publicacion
        PublicacionN publicacionN = new PublicacionN();

        //[Route("Inicio")]
        
        public ActionResult Inicio()
        {
            InmuebleN inmuebleN = new InmuebleN();
            List<InmuebleE> lstInmuebles = new List<InmuebleE>();
            lstInmuebles = inmuebleN.ListadoInmuebles();
            ViewBag.ListaInmuebles = lstInmuebles;
            

            PublicacionN publicacioN = new PublicacionN();
            List<PublicacionE> lstPublicacionVenta = new List<PublicacionE>();
            lstPublicacionVenta = publicacionN.MostrarPublicacionEnVenta();
            ViewBag.ListaPublicacionVenta = lstPublicacionVenta;

            PublicacionN publicacioNn = new PublicacionN();
            List<PublicacionE> lstPublicacionAlquiler = new List<PublicacionE>();
            lstPublicacionAlquiler = publicacioNn.MostrarPublicacionEnAlquiler();
            ViewBag.ListaPublicacionAlquiler = lstPublicacionAlquiler;

            return View();
        }
        public ActionResult InmueblesEnVenta()
        {
            return View(publicacionN.MostrarPublicacionEnVenta());
        }
        public ActionResult InmueblesEnAlquiler()
        {
            return View(publicacionN.MostrarPublicacionEnAlquiler());
        }
        public ActionResult InmueblesEnAlquilerDepartamento()
        {
            return View(publicacionN.MostrarPublicacionEnAlquilerDepartamento());
        }
        public ActionResult InmueblesEnAlquilerCasa()
        {
            return View(publicacionN.MostrarPublicacionEnAlquilerCasa());
        }
        public ActionResult InmueblesEnAlquilerGarage()
        {
            return View(publicacionN.MostrarPublicacionEnAlquilerGarage());
        }
        public ActionResult InmueblesEnAlquilerLocal()
        {
            return View(publicacionN.MostrarPublicacionEnAlquilerLocal());
        }
        public ActionResult InmueblesEnAlquilerOficina()
        {
            return View(publicacionN.MostrarPublicacionEnAlquilerOficina());
        }


        public ActionResult InmueblesEnVentaApartamento()
        {
            return View(publicacionN.MostrarPublicacionEnVentaApartamento());
        }
        public ActionResult InmueblesEnVentaCasa()
        {
            return View(publicacionN.MostrarPublicacionEnVentaCasa());
        }
        public ActionResult InmueblesEnVentaOficina()
        {
            return View(publicacionN.MostrarPublicacionEnVentaOficina());
        }
        public ActionResult InmueblesEnVentaLocal()
        {
            return View(publicacionN.MostrarPublicacionEnVentaLocal());
        }
        public ActionResult InmueblesEnVentaGarage()
        {
            return View(publicacionN.MostrarPublicacionEnVentaGarage());
        }



    }
}