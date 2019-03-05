using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lec00.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(FormCollection form)
        {
            ViewBag.Nombre = form["txtNombre"];
            ViewBag.Apellido1 = form["Apellido1"];
            ViewBag.Apellido2 = form["Apellido2"];
            ViewBag.Correo = form["Correo"];
            ViewBag.Genero = form["Genero"];
            return View("Estudiante");

        }
       
    }
}