using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    public class HoraCrud
    {
        public bool AgregarHora(Entidad.HoraEnt horaEnt)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.AgregarHora(horaEnt);
        }
        public Entidad.HoraEnt BuscarHora(int id_hora)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.BuscarHora(id_hora);
        }
        public Entidad.HoraEnt ModificarHora(Entidad.HoraEnt horaEnt)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.ModificarHora(horaEnt);
        }
        public List<Entidad.HoraEnt> ListarHora()
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.ListarHora();
        }
        public bool EliminarHora(int id_hora)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.EliminarHora(id_hora);
        }
    }
}
