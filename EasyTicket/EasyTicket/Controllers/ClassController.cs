using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTicket.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(Models.Class1 clase)
        {
            Negocio.GestionClass1 gestor = new Negocio.GestionClass1();
            Entidad.Class1Entity entidad = new Entidad.Class1Entity
            {
                Codigo = clase.Codigo,
                Numero = clase.Numero
            };
            gestor.crearClase(entidad);
            return View();
        }
    }
}