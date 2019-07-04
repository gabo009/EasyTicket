using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTicket.Controllers
{
     /// <summary>
     /// Clase Controlador para el Home
     /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Genera la vista sin para el Home 
        /// </summary>
        /// <returns>
        /// Retorna el View generado
        /// </returns>
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
