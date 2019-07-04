using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de especialidad
    /// </summary>
    public class EspecialidadCrud
    {
        /// <summary>
        /// Método del CRUD para agregar una especialidad en la BD
        /// </summary>
        /// <param name="especialidadEnt">Objeto de la clase EspecialidadEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarEspecialidad(Entidad.EspecialidadEnt especialidadEnt)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.AgregarEspecialidad(especialidadEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar una especialidad en la BD
        /// </summary>
        /// <param name="id_especialidad">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_especialidad</returns>
        public Entidad.EspecialidadEnt BuscarEspecialidad(int id_especialidad)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.BuscarEspecialidad(id_especialidad);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo especialidad
        /// </summary>
        /// <param name="especialidadEnt">Objeto de la clase EspecialidadEnt</param>
        /// <returns>retorna un obj de tipo EspecialidadEnt o un nulo en caso de exception</returns>
        public Entidad.EspecialidadEnt ModificarEspecialidad(Entidad.EspecialidadEnt especialidadEnt)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.ModificarEspecialidad(especialidadEnt);
        }
        /// <summary>
        /// Esto es para listar las especialidad de la BD
        /// </summary>
        /// <returns>retorna las especialidades que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.EspecialidadEnt> ListarEspecialidad()
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.ListarEspecialidad();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara una especialidad de la BD
        /// </summary>
        /// <param name="id_especialidad">argumento del tipo int que corresponde al id de la especialidad</param>
        /// <returns>si se elimina una especialidad enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarEspecialidad(int id_especialidad)
        {
            Repositorio.Dal.EspecialidadDal dal = new Repositorio.Dal.EspecialidadDal();
            return dal.EliminarEspecialidad(id_especialidad);
        }
    }
}
