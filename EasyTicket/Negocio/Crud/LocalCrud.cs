using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    public class LocalCrud
    {
        public bool AgregarLocal(Entidad.LocalEnt localEnt)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.AgregarLocal(localEnt);
        }
        public Entidad.LocalEnt BuscarLocal(int id_local)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.BuscarLocal(id_local);
        }
        public Entidad.LocalEnt ModificarLocal(Entidad.LocalEnt localEnt)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.ModificarLocal(localEnt);
        }
        public List<Entidad.LocalEnt> ListarLocal()
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.ListarLocal();
        }
        public bool EliminarLocal(int id_local)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.EliminarLocal(id_local);
        }
    }
}
