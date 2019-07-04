using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    public class LocalServCrud
    {

        public bool AgregarServLocal(Entidad.LocalServEnt localservEnt)
        {
            Repositorio.Dal.LocalServDal dal = new Repositorio.Dal.LocalServDal();
            return dal.AgregarLocalServ(localservEnt);
        }


        public List<Entidad.LocalServEnt> ListarLocalServ()
        {
            Repositorio.Dal.LocalServDal dal = new Repositorio.Dal.LocalServDal();
            return dal.ListarLocalServ();
        }
       
        public bool EliminarLocal(int id_local, int id_servicio)
        {
            Repositorio.Dal.LocalServDal dal = new Repositorio.Dal.LocalServDal();
            return dal.EliminarLocal_Serv(id_local, id_servicio);
        }
    }
}
