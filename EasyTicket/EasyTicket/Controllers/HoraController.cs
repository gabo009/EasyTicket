using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTicket.Models;
using System.Web.Script.Serialization;
using System.Globalization;

namespace EasyTicket.Controllers
{
    public class HoraController : Controller
    {
        // GET: Hora
        public ActionResult BuscarLocal()
        {
            Negocio.Crud.ComunaCrud gestorComuna = new Negocio.Crud.ComunaCrud();
            Negocio.Crud.LocalCrud gestorLocal = new Negocio.Crud.LocalCrud();
            Negocio.Crud.LocalServCrud gestorLocalServ = new Negocio.Crud.LocalServCrud();
            Negocio.Crud.RegionCrud gestorRegiones = new Negocio.Crud.RegionCrud();
            Negocio.Crud.ServicioCrud gestorServicios = new Negocio.Crud.ServicioCrud();
            Negocio.Crud.EspecialidadCrud gestorEspecialidad = new Negocio.Crud.EspecialidadCrud();
            FiltroModelo filtro = new FiltroModelo()
            {
                locales = gestorLocal.ListarLocal(),
                localservicios = gestorLocalServ.ListarLocalServ(),
                regiones = gestorRegiones.ListarRegion(),
                servicios = gestorServicios.ListarServicio(),
                especialidades = gestorEspecialidad.ListarEspecialidad(),
                comunas = gestorComuna.ListarComuna()
            };
            return View(filtro);
        }
        [HttpPost]
        public ActionResult PasarHoraHora(FormCollection frmCollection)
        {
            int id_local = int.Parse(frmCollection.GetValue("localList").AttemptedValue);
            int id_servicio = int.Parse(frmCollection.GetValue("servicios").AttemptedValue);

            return RedirectToAction("IngresarHora","Hora", new { id_local, id_servicio });
        }
        [HttpGet]
        public ActionResult IngresarHora(int id_local, int id_servicio)
        {
            Negocio.Crud.HoraCrud gestor = new Negocio.Crud.HoraCrud();
            DateTime today = DateTime.Today;
            HoraModelo hora = new HoraModelo()
            {
                fecha = today.ToString("yyyy-MM-dd"),
                id_local = id_local,
                id_servicio = id_servicio,
                horasTomadas = gestor.ListarHoraPorDia(today)
            };
            return View(hora);
        }
        [HttpPost]
        public ActionResult IngresarHora(HoraModelo hora)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            Negocio.Crud.HoraCrud gestor = new Negocio.Crud.HoraCrud();
            Entidad.HoraEnt horaEnt = new Entidad.HoraEnt()
            {
                id_hora = hora.id_hora,
                ape_cliente = hora.ape_cliente,
                cel_cliente = hora.cel_cliente,
                correo_cliente = hora.correo_cliente,
                fecha = DateTime.ParseExact(hora.fecha, "yyyy-MM-dd", culture),
                hora_tomada = hora.hora_tomada,
                nom_cliente = hora.nom_cliente,
                rut_cliente = hora.nom_cliente,
                id_local = hora.id_local,
                id_servicio = hora.id_servicio
            };
            gestor.AgregarHora(horaEnt);
            return RedirectToAction("BuscarLocal");
        }


        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult CargarComunas(int Id_Region)
        {
            Negocio.Crud.ComunaCrud gestor = new Negocio.Crud.ComunaCrud();
            List<Entidad.ComunaEnt> lista;
            if (Id_Region == 0)
            {
                lista = gestor.ListarComuna();
            }
            else
            {
                lista = gestor.ListarPorRegion(Id_Region);
            }
            var ComData = lista.Select(m => new SelectListItem()
            {
                Text = m.nombre_comuna,
                Value = m.id_comuna.ToString()
            });
            return Json(ComData, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult CargarServicios(int Id_Especialidad)
        {
            Negocio.Crud.ServicioCrud gestor = new Negocio.Crud.ServicioCrud();
            List<Entidad.ServicioEnt> lista;
            if (Id_Especialidad == 0)
            {
                lista = gestor.ListarServicio();
            }
            else
            {
                lista = gestor.ListarPorEspecialidad(Id_Especialidad);
            }
            var ComData = lista.Select(m => new SelectListItem()
            {
                Text = m.nom_servicio,
                Value = m.id_servicio.ToString(),
            });
            return Json(ComData, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult CargarLocales(int id_servicio, int id_comuna)
        {
            Negocio.Crud.LocalCrud gestor = new Negocio.Crud.LocalCrud();
            List<Entidad.LocalEnt> lista;
            if (id_servicio == 0 && id_comuna == 0)
            {
                lista = gestor.ListarLocal();
            }
            else if (id_servicio == 0)
            {
                lista = gestor.ListarPorCom(id_comuna);
            }
            else if (id_comuna == 0)
            {
                lista = gestor.ListarPorServ(id_servicio);
            }
            else
            {
                lista = gestor.ListarPorServCom(id_servicio, id_comuna);
            }


            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult HorasDisponibles(String fecha)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            Negocio.Crud.HoraCrud gestor = new Negocio.Crud.HoraCrud();
            DateTime dia = DateTime.ParseExact(fecha, "yyyy-MM-dd", culture);
            List<Entidad.HoraEnt> horastomadas = gestor.ListarHoraPorDia(dia);

            return Json(horastomadas, JsonRequestBehavior.AllowGet);
        }
    }
}