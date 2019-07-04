using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTicket.Models;

namespace EasyTicket.Controllers
{
    /// <summary>
    /// Clase Controlador para Mantenedor de Servicio
    /// </summary>
    public class ServicioController : Controller
    {
        /// <summary>
        /// Genera la vista sin datos para el ingreso de un Servicio 
        /// </summary>
        /// <returns>
        /// Retorna el View generado con el modelo vacio
        /// </returns>
        // GET
        public ActionResult IngresarServicio()
        {
            return View(new ServicioModelo());
        }
        /// <summary>
        /// Guarda un Servicio nuevo en la Base de Datos con el modelo enviado desde la vista.
        /// </summary>
        /// <param name="servicio">Este argumento es del tipo servicioModelo y corresponde al codigo de los datos del servicio a ingresar</param>
        /// <returns>
        /// 1) En caso de Error retorna el View con los datos ingresados.
        /// 2) En caso de exito redirecciona hacia la lista de servicio.
        /// </returns>
        [HttpPost]
        public ActionResult IngresarServicio(ServicioModelo servicio)
        {
            Entidad.ServicioEnt servicioEnt = new Entidad.ServicioEnt()
            {
                id_servicio = servicio.id_servicio,
                nom_servicio = servicio.nom_servicio,
                desc_servicio = servicio.desc_servicio,
                id_especialidad = servicio.id_especialidad
            };
            Negocio.Crud.ServicioCrud gestor = new Negocio.Crud.ServicioCrud();
            if (gestor.AgregarServicio(servicioEnt))
            {
                return View(servicio);
            }
            else
            {
                return RedirectToAction("ListaServicios", "Servicio");
            }
        }
        /// <summary>
        /// Consulta todos los servicios de la Base de Datos y Genera la vista con estas.
        /// </summary>
        /// <returns>
        /// Retorna el View generado con un List de la clase ServicioModelo.
        /// </returns>
        // GET
        public ActionResult ListaServicio()
        {
            List<ServicioModelo> listaServicio = new List<ServicioModelo>();
            ServicioModelo servicio;
            Negocio.Crud.ServicioCrud gestor = new Negocio.Crud.ServicioCrud();
            List<Entidad.ServicioEnt> listaServicioEnt = gestor.ServicioLocal();
            foreach (Entidad.ServicioEnt serv in listaServicioEnt)
            {
                servicio = new ServicioModelo()
                {
                    id_servicio = serv.id_servicio,
                    nom_servicio = serv.nom_servicio,
                    desc_servicio = serv.desc_servicio,
                    id_especialidad = serv.id_especialidad
                };
                listaServicio.Add(servicio);
            }
            return View(listaServicio);
        }
        /// <summary>
        /// Busca el servicio seleccionado y guarda las modificaciones realizadas en la Base de Datos.
        /// </summary>
        /// <param name="CodigoServicio">Este argumento es del tipo int y corresponde al codigo del servicio seleccionado a modificar</param>
        /// <returns>
        /// Retorna la View generada con los datos del servicio seleccionado .
        /// </returns>
        // GET
        public ActionResult EditarServicio(int CodigoServicio)
        {
            Negocio.Crud.ServicioCrud gestor = new Negocio.Crud.ServicioCrud();
            Entidad.ServicioEnt servicioEnt = gestor.BuscarServicio(CodigoServicio);
            ServicioModelo modelo = new ServicioModelo()
            {
                id_servicio = servicioEnt.id_servicio,
                nom_servicio = servicioEnt.nom_servicio,
                desc_servicio = servicioEnt.desc_servicio,
                id_especialidad = servicioEnt.id_especialidad
            };
            return View(modelo);
        }
        /// <summary>
        /// Guarda en la Base de Datos los datos modifcados del servicio.
        /// </summary>
        /// <param name="modelo">Este argumento es del tipo ServicioModelo y corresponde al modelo del servicio a modificar</param>
        /// <returns>Redirecciona a la accion ListaComunas.</returns>
        [HttpPost]
        public ActionResult EditarServicio(ServicioModelo modelo)
        {
            Negocio.Crud.ServicioCrud gestor = new Negocio.Crud.ServicioCrud();
            Entidad.ServicioEnt servicioEnt = new Entidad.ServicioEnt()
            {
                id_servicio = modelo.id_servicio,
                nom_servicio = modelo.nom_servicio,
                desc_servicio = modelo.desc_servicio,
                id_especialidad = modelo.id_especialidad
            };
            gestor.ModificarServicio(servicioEnt);
            return RedirectToAction("ListaServicios", "Servicio");
        }
        /// <summary>
        /// Elimina el Servicio seleccionado
        /// </summary>
        /// <param name="CodigoServicio">Este argumento es del tipo int y corresponde al codigo de la comuna a eliminar</param>
        /// <returns>Redirecciona a la accion ListaComunas.</returns>
        public ActionResult EliminarServicio(int CodigoServicio)
        {
            Negocio.Crud.ServicioCrud gestor = new Negocio.Crud.ServicioCrud();
            Entidad.ServicioEnt servicioEnt = gestor.BuscarServicio(CodigoServicio);
            if (gestor.EliminarServicio(CodigoServicio))
            {
                return RedirectToAction("ListaServicios", "Servicio");
            }
            return RedirectToAction("ListaServicios", "Servicio");
        }
    }
}