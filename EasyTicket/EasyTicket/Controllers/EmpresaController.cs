using EasyTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTicket.Controllers
{
    /// <summary>
    /// Clase Controlador para Mantenedor de Empresa
    /// </summary>
    public class EmpresaController : Controller
    {
        /// <summary>
        /// Genera la vista sin datos para el ingreso de una Empresa 
        /// </summary>
        /// <returns>
        /// Retorna el View generado con el modelo vacio
        /// </returns>
        // GET
        public ActionResult IngresarEmpresa()
        {
            return View(new EmpresaModelo());
        }
        /// <summary>
        /// Guarda una Empresa nueva en la Base de Datos con el modelo enviado desde la vista.
        /// </summary>
        /// <param name="empresa">Este argumento es del tipo EmpresaModelo y corresponde al codigo de los datos de la empresa a ingresar</param>
        /// <returns>
        /// 1) En caso de Error retorna el View con los datos ingresados.
        /// 2) En caso de exito redirecciona hacia la lista de empresa.
        /// </returns>
        [HttpPost]
        public ActionResult IngresarEmpresa(EmpresaModelo empresa)
        {
            Entidad.EmpresaEnt empresaEnt = new Entidad.EmpresaEnt()
            {
                id_empresa = empresa.id_empresa,
                nom_empresa = empresa.nom_empresa,
                rut_empresa = empresa.rut_empresa
            };
            Negocio.Crud.EmpresaCrud gestor = new Negocio.Crud.EmpresaCrud();
            if (gestor.AgregarEmpresa(empresaEnt))
            {
                return View(empresa);
            }
            else
            {
                return RedirectToAction("ListaEmpresas", "Empresa");
            }
        }
        /// <summary>
        /// Consulta todas Empresas de la Base de Datos y Genera la vista con estas.
        /// </summary>
        /// <returns>
        /// Retorna el View generado con un List de la clase EmpresaModelo.
        /// </returns>
        // GET
        public ActionResult ListaEmpresas()
        {
            List<EmpresaModelo> listaEmpresa = new List<EmpresaModelo>();
            EmpresaModelo empresa;
            Negocio.Crud.EmpresaCrud gestor = new Negocio.Crud.EmpresaCrud();
            List<Entidad.EmpresaEnt> listaEmpresaEnt = gestor.ListarEmpresa();
            foreach (Entidad.EmpresaEnt emp in listaEmpresaEnt)
            {
                empresa = new EmpresaModelo()
                {
                    id_empresa = emp.id_empresa,
                    nom_empresa = emp.nom_empresa,
                    rut_empresa = emp.rut_empresa
                };
                listaEmpresa.Add(empresa);
            }
            return View(listaEmpresa);
        }
        /// <summary>
        /// Busca la empresa seleccionada y guarda las modificaciones realizadas en la Base de Datos.
        /// </summary>
        /// <param name="CodigoEmpresa">Este argumento es del tipo int y corresponde al codigo de la empresa a modificar</param>
        /// <returns>
        /// Retorna la View generada con los datos de la emresa seleccionada.
        /// </returns>
        // GET
        public ActionResult EditarEmpresa(int CodigoEmpresa)
        {
            Negocio.Crud.EmpresaCrud gestor = new Negocio.Crud.EmpresaCrud();
            Entidad.EmpresaEnt empresaEnt = gestor.BuscarEmpresa(CodigoEmpresa);
            EmpresaModelo modelo = new EmpresaModelo()
            {
                id_empresa = empresaEnt.id_empresa,
                nom_empresa = empresaEnt.nom_empresa,
                rut_empresa = empresaEnt.rut_empresa
            };
            return View(modelo);
        }
        /// <summary>
        /// Guarda en la Base de Datos los datos modifcados de la empresa.
        /// </summary>
        /// <param name="modelo">Este argumento es del tipo EmpresaModelo y corresponde al modelo de la empresa a modificar</param>
        /// <returns>Redirecciona a la accion ListaEmpresas.</returns>
        [HttpPost]
        public ActionResult EditarEmpresa(EmpresaModelo modelo)
        {
            Negocio.Crud.EmpresaCrud gestor = new Negocio.Crud.EmpresaCrud();
            Entidad.EmpresaEnt empresaEnt = new Entidad.EmpresaEnt()
            {
                id_empresa = modelo.id_empresa,
                nom_empresa = modelo.nom_empresa,
                rut_empresa = modelo.rut_empresa
            };
            gestor.ModificarEmpresa(empresaEnt);
            return RedirectToAction("ListaEmpresas", "Empresa");
        }
        /// <summary>
        /// Elimina la empresa seleccionda
        /// </summary>
        /// <param name="CodigoEmpresa">Este argumento es del tipo int y corresponde al codigo de la empresa a eliminar</param>
        /// <returns>Redirecciona a la accion ListaEmpresas.</returns>
        public ActionResult EliminarComuna(int CodigoEmpresa)
        {
            Negocio.Crud.EmpresaCrud gestor = new Negocio.Crud.EmpresaCrud();
            Entidad.EmpresaEnt empresaEnt = gestor.BuscarEmpresa(CodigoEmpresa);
            if (gestor.EliminarEmpresa(CodigoEmpresa))
            {
                return RedirectToAction("ListaComunas", "Comuna");
            }
            return RedirectToAction("ListaComunas", "Comuna");
        }
    }
}