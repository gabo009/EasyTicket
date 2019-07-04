using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de Usuario
    /// </summary>
    public class UsuarioCrud
    {
        /// <summary>
        /// Método del CRUD para agregar un Usuario en la BD
        /// </summary>
        /// <param name="usuarioEnt">Objeto de la clase UsuarioEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarUsuario(Entidad.UsuarioEnt usuarioEnt)
        {
            Repositorio.Dal.UsuarioDal dal = new Repositorio.Dal.UsuarioDal();
            return dal.AgregarUsuario(usuarioEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar un Usuario en la BD
        /// </summary>
        /// <param name="id_usuario">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_usuario</returns>
        public Entidad.UsuarioEnt BuscarUsuario(int id_usuario)
        {
            Repositorio.Dal.UsuarioDal dal = new Repositorio.Dal.UsuarioDal();
            return dal.BuscarUsuario(id_usuario);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo usuario
        /// </summary>
        /// <param name="usuarioEnt">Objeto de la clase UsuarioEnt</param>
        /// <returns>retorna un obj de tipo UsuarioEnt o un nulo en caso de exception</returns>
        public Entidad.UsuarioEnt ModificarUsuario(Entidad.UsuarioEnt usuarioEnt)
        {
            Repositorio.Dal.UsuarioDal dal = new Repositorio.Dal.UsuarioDal();
            return dal.ModificarUsuario(usuarioEnt);
        }
        /// <summary>
        /// Esto es para listar los usuarios de la BD
        /// </summary>
        /// <returns>retorna los usuarios que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.UsuarioEnt> ListarUsuario()
        {
            Repositorio.Dal.UsuarioDal dal = new Repositorio.Dal.UsuarioDal();
            return dal.ListarUsuario();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara un usuario de la BD
        /// </summary>
        /// <param name="id_usuario">argumento del tipo int que corresponde al id del usuario</param>
        /// <returns>si se elimina un usuario enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarUsuario(int id_usuario)
        {
            Repositorio.Dal.UsuarioDal dal = new Repositorio.Dal.UsuarioDal();
            return dal.EliminarUsuario(id_usuario);
        }
    }
}
