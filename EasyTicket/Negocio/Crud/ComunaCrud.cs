using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    public class ComunaCrud
    {
        public bool AgregarComuna(Entidad.ComunaEnt comunaEnt)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.AgregarComuna(comunaEnt);
        }
        public Entidad.ComunaEnt BuscarComuna(int idComuna)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.BuscarComuna(idComuna);
        }
        public Entidad.ComunaEnt ModificarComuna(Entidad.ComunaEnt comunaEnt)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.ModificarComuna(comunaEnt);
        }
        public List<Entidad.ComunaEnt> ListarComuna()
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.ListarComuna();
        }
        public bool EliminarComuna(int id_comuna)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.EliminarComuna(id_comuna);
        }
    }
}
