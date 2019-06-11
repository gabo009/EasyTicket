using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    public class EspecialidadCrud
    {
        public bool AgregarEspecialidad(Entidad.EspecialidadEnt especialidadEnt)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.AgregarEspecialidad(especialidadEnt);
        }
        public Entidad.EspecialidadEnt BuscarEspecialidad(int id_especialidad)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.BuscarEspecialidad(id_especialidad);
        }
        public Entidad.EspecialidadEnt ModificarEspecialidad(Entidad.EspecialidadEnt especialidadEnt)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.ModificarEspecialidad(especialidadEnt);
        }
        public List<Entidad.EspecialidadEnt> ListarEspecialidad()
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.ListarEspecialidad();
        }
        public bool EliminarEspecialidad(int id_especialidad)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.EliminarEspecialidad(id_especialidad);
        }
    }
}
