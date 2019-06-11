using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class LocalServDal
    {
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
        
        public bool EliminarLocal_Serv (int id_local, int id_servicio)
        {
            db_Entities db = new db_Entities();
            try
            {
                local_serv localserv = db.Local_serv.FirstOrDefault(l => (l.id_local == id_local)&&(l.id_servicio == id_servicio));

                db.Local_serv.Remove(localserv);
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
