using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class UsuarioDal
    {
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
