using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de Usuario (Del)
    /// </summary>
    public class UsuarioDal
    {
        /// <summary>
        /// Método para agregar una Usuario en la BD
        /// </summary>
        /// <param name="usuarioEnt">Objeto de la clase usuarioEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarUsuario(Entidad.UsuarioEnt usuarioEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                usuario usuario = new usuario
                {
                    id_usuario = usuarioEnt.id_usuario,
                    nom_usuario = usuarioEnt.nom_usuario,
                    con_usuario = usuarioEnt.con_usuario,
                    tipo_usuario = usuarioEnt.tipo_usuario,
                    id_empresa = usuarioEnt.id_empresa
                };
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar una usuario en la BD
        /// </summary>
        /// <param name="id_usuario">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_usuario</returns>
        public Entidad.UsuarioEnt BuscarUsuario(int id_usuario)
        {
            db_Entities db = new db_Entities();
            Entidad.UsuarioEnt usuarioEnt;
            usuario usuario = db.Usuario.FirstOrDefault(u => u.id_usuario == id_usuario);
            usuarioEnt = new Entidad.UsuarioEnt
            {
                id_usuario = usuario.id_usuario,
                nom_usuario = usuario.nom_usuario,
                con_usuario = usuario.con_usuario,
                tipo_usuario = usuario.tipo_usuario,
                id_empresa = usuario.id_empresa
            };
            return usuarioEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo usuario
        /// </summary>
        /// <param name="usuarioEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo usuario o un nulo en caso de exception</returns>
        public Entidad.UsuarioEnt ModificarUsuario(Entidad.UsuarioEnt usuarioEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                usuario usuario = db.Usuario.FirstOrDefault(u => u.id_usuario == usuarioEnt.id_usuario);

                usuario.id_usuario = usuarioEnt.id_usuario;
                usuario.nom_usuario = usuarioEnt.nom_usuario;
                usuario.con_usuario = usuarioEnt.con_usuario;
                usuario.tipo_usuario = usuarioEnt.tipo_usuario;
                usuario.id_empresa = usuarioEnt.id_empresa;

                db.SaveChanges();

                return BuscarUsuario(usuario.id_usuario);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esto es para listar los usuarios de la BD
        /// </summary>
        /// <returns>retorna los usuarios que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.UsuarioEnt> ListarUsuario()
        {
            db_Entities db = new db_Entities();
            List<Entidad.UsuarioEnt> ListaUsuario = new List<Entidad.UsuarioEnt>();
            Entidad.UsuarioEnt usuarioEnt = new Entidad.UsuarioEnt();
            try
            {
                foreach (var u in db.Usuario.ToList())
                {
                    usuarioEnt = new Entidad.UsuarioEnt
                    {
                        id_usuario = u.id_usuario,
                        nom_usuario = u.nom_usuario,
                        con_usuario = u.con_usuario,
                        tipo_usuario = u.tipo_usuario,
                        id_empresa = u.id_empresa
                    };

                    ListaUsuario.Add(usuarioEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return ListaUsuario;
        }
        /// <summary>
        /// Método para eliminar un usuario
        /// </summary>
        /// <param name="id_usuario">por medio del id se buscará y eliminará el usuario</param>
        /// <returns>si se elimina un usuario enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarUsuario(int id_usuario)
        {
            db_Entities db = new db_Entities();
            try
            {
                usuario usuario = db.Usuario.FirstOrDefault(u => u.id_usuario == id_usuario);

                db.Usuario.Remove(usuario);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
