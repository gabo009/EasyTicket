using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class LocalDal
    {
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
    }
}
