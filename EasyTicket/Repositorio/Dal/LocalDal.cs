using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de local (Del)
    /// </summary>
    public class LocalDal
    {
        /// <summary>
        /// Método para agregar una Local en la BD
        /// </summary>
        /// <param name="localEnt">Objeto de la clase LocalEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarLocal(Entidad.LocalEnt localEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                local local = new local
                {
                    id_local = localEnt.id_local,
                    dir_local = localEnt.dir_local,
                    id_comuna = localEnt.id_comuna,
                    id_empresa = localEnt.id_empresa
                };
                db.Local.Add(local);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar un Local en la BD
        /// </summary>
        /// <param name="id_local">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_local</returns>
        public Entidad.LocalEnt BuscarLocal(int id_local)
        {
            db_Entities db = new db_Entities();
            Entidad.LocalEnt localEnt;
            local local = db.Local.FirstOrDefault(l => l.id_local == id_local);
            localEnt = new Entidad.LocalEnt
            {
                id_local = local.id_local,
                dir_local = local.dir_local,
                id_comuna = local.id_comuna,
                id_empresa = local.id_empresa
            };
            return localEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo local
        /// </summary>
        /// <param name="localEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo local o un nulo en caso de exception</returns>
        public Entidad.LocalEnt ModificarLocal(Entidad.LocalEnt localEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                local local = db.Local.FirstOrDefault(l => l.id_local == localEnt.id_local);

                local.id_local = localEnt.id_local;
                local.dir_local = localEnt.dir_local;
                local.id_comuna = localEnt.id_comuna;
                local.id_empresa = localEnt.id_empresa;

                db.SaveChanges();

                return BuscarLocal(local.id_local);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Esto es para listar los local de la BD
        /// </summary>
        /// <returns>retorna los local que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.LocalEnt> ListarLocal()
        {
            db_Entities db = new db_Entities();
            List<Entidad.LocalEnt> listaLocal = new List<Entidad.LocalEnt>();
            Entidad.LocalEnt localEnt = new Entidad.LocalEnt();
            try
            {
                foreach (var l in db.Local.ToList())
                {
                    localEnt = new Entidad.LocalEnt
                    {
                        id_local = l.id_local,
                        dir_local = l.dir_local,
                        id_comuna = l.id_comuna,
                        id_empresa = l.id_empresa
                    };

                    listaLocal.Add(localEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaLocal;
        }
        /// <summary>
        /// Método para eliminar un local
        /// </summary>
        /// <param name="id_local">por medio del id se buscará y eliminará el local</param>
        /// <returns>si se elimina un local enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarLocal(int id_local)
        {
            db_Entities db = new db_Entities();
            try
            {
                local local = db.Local.FirstOrDefault(l => l.id_local == id_local);

                db.Local.Remove(local);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Entidad.LocalEnt> ListarPorCom(int id_comuna)
        {
            db_Entities db = new db_Entities();
            List<Entidad.LocalEnt> listaLocales = new List<Entidad.LocalEnt>();
            Entidad.LocalEnt localEnt = new Entidad.LocalEnt();
            try
            {
                foreach (var loc in db.Local.Where(c => c.id_comuna == id_comuna).ToList())
                {
                    localEnt = new Entidad.LocalEnt
                    {
                        id_local = loc.id_local,
                        dir_local = loc.dir_local,
                        id_comuna = loc.id_comuna,
                        id_empresa = loc.id_empresa
                    };

                    listaLocales.Add(localEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaLocales;
        }
    }
}
