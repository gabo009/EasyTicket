using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTicket.Models;

namespace EasyTicket.Controllers
{
    /// <summary>
    /// Clase Controlador para Mantenedor de Usuarios
    /// </summary>
    public class UsuarioController : Controller
    {
        /// <summary>
        /// Genera la vista sin datos para el ingreso de un Usuario 
        /// </summary>
        /// <returns>
        /// Retorna el View generado con el modelo vacio
        /// </returns>
        // GET
        public ActionResult IngresarUsuario()
        {
            return View(new UsuarioModelo());
        }
        /// <summary>
        /// Guarda un Usuario nuevo en la Base de Datos con el modelo enviado desde la vista.
        /// </summary>
        /// <param name="usuario">Este argumento es del tipo usuarioModelo y corresponde al codigo de los datos del usuario a ingresar</param>
        /// <returns>
        /// 1) En caso de Error retorna el View con los datos ingresados.
        /// 2) En caso de exito redirecciona hacia la lista de usuario.
        /// </returns>
        [HttpPost]
        public ActionResult IngresarUsuario(UsuarioModelo usuario)
        {
            Entidad.UsuarioEnt usuarioEnt = new Entidad.UsuarioEnt()
            {
                id_usuario = usuario.id_usuario,
                nom_usuario = usuario.nom_usuario,
                con_usuario = usuario.con_usuario,
                tipo_usuario = usuario.tipo_usuario,
                id_empresa = usuario.id_empresa
            };
            Negocio.Crud.UsuarioCrud gestor = new Negocio.Crud.UsuarioCrud();
            if (gestor.AgregarUsuario(usuarioEnt))
            {
                return View(usuario);
            }
            else
            {
                return RedirectToAction("ListaUsuarios", "Usuario");
            }
        }
        /// <summary>
        /// Consulta todos los usuarios de la Base de Datos y Genera la vista con estas.
        /// </summary>
        /// <returns>
        /// Retorna el View generado con un List de la clase UsuarioModelo.
        /// </returns>
        // GET
        public ActionResult ListaUsuario()
        {
            List<UsuarioModelo> listaUsuario = new List<UsuarioModelo>();
            UsuarioModelo usuario;
            Negocio.Crud.UsuarioCrud gestor = new Negocio.Crud.UsuarioCrud();
            List<Entidad.UsuarioEnt> listaUsuarioEnt = gestor.UsuarioLocal();
            foreach (Entidad.UsuarioEnt usu in listaUsuarioEnt)
            {
                usuario = new UsuarioModelo()
                {
                    id_usuario = usu.id_usuario,
                    nom_usuario = usu.nom_usuario,
                    con_usuario = usu.con_usuario,
                    tipo_usuario = usu.tipo_usuario,
                    id_empresa = usu.id_empresa
                };
                listaUsuario.Add(usuario);
            }
            return View(listaUsuario);
        }
        /// <summary>
        /// Busca el usuario seleccionado y guarda las modificaciones realizadas en la Base de Datos.
        /// </summary>
        /// <param name="CodigoUsuario">Este argumento es del tipo int y corresponde al codigo del usuario seleccionado a modificar</param>
        /// <returns>
        /// Retorna la View generada con los datos del usuario seleccionado .
        /// </returns>
        // GET
        public ActionResult EditarUsuario(int CodigoUsuario)
        {
            Negocio.Crud.UsuarioCrud gestor = new Negocio.Crud.UsuarioCrud();
            Entidad.UsuarioEnt usuarioEnt = gestor.BuscarUsuario(CodigoUsuario);
            UsuarioModelo modelo = new UsuarioModelo()
            {
                id_usuario = usuarioEnt.id_usuario,
                nom_usuario = usuarioEnt.nom_usuario,
                con_usuario = usuarioEnt.con_usuario,
                tipo_usuario = usuarioEnt.tipo_usuario,
                id_empresa = usuarioEnt.id_empresa
            };
            return View(modelo);
        }
        /// <summary>
        /// Guarda en la Base de Datos los datos modifcados del usuario.
        /// </summary>
        /// <param name="modelo">Este argumento es del tipo UsuarioModelo y corresponde al modelo del usuario a modificar</param>
        /// <returns>Redirecciona a la accion ListaComunas.</returns>
        [HttpPost]
        public ActionResult EditarUsuario(UsuarioModelo modelo)
        {
            Negocio.Crud.UsuarioCrud gestor = new Negocio.Crud.UsuarioCrud();
            Entidad.UsuarioEnt usuarioEnt = new Entidad.UsuarioEnt()
            {
                id_usuario = modelo.id_usuario,
                nom_usuario = modelo.nom_usuario,
                con_usuario = modelo.con_usuario,
                tipo_usuario = modelo.tipo_usuario,
                id_empresa = modelo.id_empresa
            };
            gestor.ModificarUsuario(usuarioEnt);
            return RedirectToAction("ListaUsuarios", "Usuario");
        }
        /// <summary>
        /// Elimina el Usuario seleccionado
        /// </summary>
        /// <param name="CodigoUsuario">Este argumento es del tipo int y corresponde al codigo de la comuna a eliminar</param>
        /// <returns>Redirecciona a la accion ListaComunas.</returns>
        public ActionResult EliminarUsuario(int CodigoUsuario)
        {
            Negocio.Crud.UsuarioCrud gestor = new Negocio.Crud.UsuarioCrud();
            Entidad.UsuarioEnt usuarioEnt = gestor.BuscarUsuario(CodigoUsuario);
            if (gestor.EliminarUsuario(CodigoUsuario))
            {
                return RedirectToAction("ListaUsuarios", "Usuario");
            }
            return RedirectToAction("ListaUsuarios", "Usuario");
        }
    }
}