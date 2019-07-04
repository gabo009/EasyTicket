using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de localServ (Del)
    /// </summary>
    public class LocalServDal
    {
        /// <summary>
        /// Método para agregar una LocalServ en la BD
        /// </summary>
        /// <param name="localservEnt">Objeto de la clase LocalServEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarLocalServ(Entidad.LocalServEnt localservEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                local_serv localserv = new local_serv
                {
                    id_local = localservEnt.id_local,
                    id_servicio = localservEnt.id_servicio
                };
                db.Local_serv.Add(localserv);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para eliminar un localServ
        /// </summary>
        /// <param name="id_local">por medio del id se buscará y eliminará el local</param>
        /// <param name="id_servicio">por medio del id se buscará y eliminará el local</param>
        /// <returns>si se elimina un localServ enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarLocal_Serv(int id_local, int id_servicio)
        {
            db_Entities db = new db_Entities();
            try
            {
                local_serv localserv = db.Local_serv.FirstOrDefault(l => (l.id_local == id_local) && (l.id_servicio == id_servicio));

                db.Local_serv.Remove(localserv);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Entidad.LocalServEnt> ListarLocalServ()
        {
            db_Entities db = new db_Entities();
            List<Entidad.LocalServEnt> listaLocalServ = new List<Entidad.LocalServEnt>();
            Entidad.LocalServEnt localServEnt = new Entidad.LocalServEnt();
            try
            {
                foreach (var l in db.Local_serv.ToList())
                {
                    localServEnt = new Entidad.LocalServEnt
                    {
                        id_local = l.id_local,
                        id_servicio = l.id_servicio
                    };

                    listaLocalServ.Add(localServEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaLocalServ;
        }
        public List<Entidad.LocalServEnt> ListarLocales(int id_servicio)
        {
            db_Entities db = new db_Entities();
            List<Entidad.LocalServEnt> listaLocalServ = new List<Entidad.LocalServEnt>();
            Entidad.LocalServEnt localServEnt = new Entidad.LocalServEnt();
            try
            {
                foreach (var locs in db.Local_serv.Where(c => c.id_servicio == id_servicio).ToList())
                {
                    localServEnt = new Entidad.LocalServEnt
                    {
                        id_local = locs.id_local,
                        id_servicio = locs.id_servicio
                    };

                    listaLocalServ.Add(localServEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaLocalServ;
        }
    }
}
