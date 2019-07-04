using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTicket.Models;

namespace EasyTicket.Controllers.Mantenedores
{
    /// <summary>
    /// Clase Controlador para Mantenedor de Comuna
    /// </summary>
    public class ComunaController : Controller
    {
        /// <summary>
        /// Genera la vista sin datos para el ingreso de una comuna 
        /// </summary>
        /// <returns>
        /// Retorna el View generado con el modelo vacio
        /// </returns>
        // GET
        public ActionResult IngresarComuna()
        {
            return View(new ComunaModelo());
        }
        /// <summary>
        /// Guarda una Comuna nueva en la Base de Datos con el modelo enviado desde la vista.
        /// </summary>
        /// <param name="comuna">Este argumento es del tipo ComunaModelo y corresponde al codigo de los datos de la comuna a ingresar</param>
        /// <returns>
        /// 1) En caso de Error retorna el View con los datos ingresados.
        /// 2) En caso de exito redirecciona hacia la lista de comuna.
        /// </returns>
        [HttpPost]
        public ActionResult IngresarComuna(ComunaModelo comuna)
        {
            Entidad.ComunaEnt comunaEnt = new Entidad.ComunaEnt()
            {
                id_comuna = comuna.id_comuna,
                id_region = comuna.id_region,
                nombre_comuna = comuna.nombre_comuna
            };
            Negocio.Crud.ComunaCrud gestor = new Negocio.Crud.ComunaCrud();
            if (gestor.AgregarComuna(comunaEnt))
            {
                return View(comuna);
            }
            else
            {
                return RedirectToAction("ListaComunas", "Comuna");
            }
        }
        /// <summary>
        /// Consulta todas Comunas de la Base de Datos y Genera la vista con estas.
        /// </summary>
        /// <returns>
        /// Retorna el View generado con un List de la clase ComunaModelo.
        /// </returns>
        // GET
        public ActionResult ListaComunas()
        {
            List<ComunaModelo> listaComuna = new List<ComunaModelo>();
            ComunaModelo comuna;
            Negocio.Crud.ComunaCrud gestor = new Negocio.Crud.ComunaCrud();
            List<Entidad.ComunaEnt> listaComunaEnt = gestor.ListarComuna();
            foreach (Entidad.ComunaEnt com in listaComunaEnt)
            {
                comuna = new ComunaModelo()
                {
                    id_comuna = com.id_comuna,
                    id_region = com.id_region,
                    nombre_comuna = com.nombre_comuna
                };
                listaComuna.Add(comuna);
            }
            return View(listaComuna);
        }
        /// <summary>
        /// Busca la comuna seleccionada y guarda las modificaciones realizadas en la Base de Datos.
        /// </summary>
        /// <param name="CodigoComuna">Este argumento es del tipo int y corresponde al codigo de la comuna a modificar</param>
        /// <returns>
        /// Retorna la View generada con los datos de la comuna seleccionada.
        /// </returns>
        // GET
        public ActionResult EditarComuna(int CodigoComuna)
        {
            Negocio.Crud.ComunaCrud gestor = new Negocio.Crud.ComunaCrud();
            Entidad.ComunaEnt comunaEnt = gestor.BuscarComuna(CodigoComuna);
            ComunaModelo modelo = new ComunaModelo()
            {
                id_comuna = comunaEnt.id_comuna,
                id_region = comunaEnt.id_region,
                nombre_comuna = comunaEnt.nombre_comuna
            };
            return View(modelo);
        }
        /// <summary>
        /// Guarda en la Base de Datos los datos modifcados de la comuna.
        /// </summary>
        /// <param name="modelo">Este argumento es del tipo ComunaModelo y corresponde al modelo de la comuna a modificar</param>
        /// <returns>Redirecciona a la accion ListaComunas.</returns>
        [HttpPost]
        public ActionResult EditarComuna(ComunaModelo modelo)
        {
            Negocio.Crud.ComunaCrud gestor = new Negocio.Crud.ComunaCrud();
            Entidad.ComunaEnt comunaEnt = new Entidad.ComunaEnt()
            {
                id_comuna = modelo.id_comuna,
                id_region = modelo.id_region,
                nombre_comuna = modelo.nombre_comuna
            };
            gestor.ModificarComuna(comunaEnt);
            return RedirectToAction("ListaComunas", "Comuna");
        }
        /// <summary>
        /// Elimina la comuna seleccionda
        /// </summary>
        /// <param name="CodigoComuna">Este argumento es del tipo int y corresponde al codigo de la comuna a eliminar</param>
        /// <returns>Redirecciona a la accion ListaComunas.</returns>
        public ActionResult EliminarComuna(int CodigoComuna)
        {
            Negocio.Crud.ComunaCrud gestor = new Negocio.Crud.ComunaCrud();
            Entidad.ComunaEnt comunaEnt = gestor.BuscarComuna(CodigoComuna);
            if (gestor.EliminarComuna(CodigoComuna))
            {
                return RedirectToAction("ListaComunas", "Comuna");
            }
            return RedirectToAction("ListaComunas", "Comuna");
        }
    }
}
