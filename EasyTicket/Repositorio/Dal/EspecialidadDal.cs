using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de Especialidad (Del)
    /// </summary>
    public class EspecialidadDal
    {
        /// <summary>
        /// Método para agregar una Especialidad en la BD
        /// </summary>
        /// <param name="especialidadEnt">Objeto de la clase EspecialidadEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarEspecialidad(Entidad.EspecialidadEnt especialidadEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                especialidad especialidad = new especialidad
                {
                    id_especialidad = especialidadEnt.id_especialidad,
                    nom_especialidad = especialidadEnt.nom_especialidad
                };
                db.Especialidad.Add(especialidad);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar una Especialidad en la BD
        /// </summary>
        /// <param name="id_especialidad">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_especialidad</returns>
        public Entidad.EspecialidadEnt BuscarEspecialidad(int id_especialidad)
        {
            db_Entities db = new db_Entities();
            Entidad.EspecialidadEnt especialidadEnt;
            especialidad especialidad = db.Especialidad.FirstOrDefault(e => e.id_especialidad == id_especialidad);
            especialidadEnt = new Entidad.EspecialidadEnt
            {
                id_especialidad = especialidad.id_especialidad,
                nom_especialidad = especialidad.nom_especialidad
            };
            return especialidadEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo Especialidad
        /// </summary>
        /// <param name="especialidadEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo especialidad o un nulo en caso de exception</returns>
        public Entidad.EspecialidadEnt ModificarEspecialidad(Entidad.EspecialidadEnt especialidadEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                especialidad especialidad = db.Especialidad.FirstOrDefault(e => e.id_especialidad == especialidadEnt.id_especialidad);

                especialidad.id_especialidad = especialidadEnt.id_especialidad;
                especialidad.nom_especialidad = especialidadEnt.nom_especialidad;

                db.SaveChanges();

                return BuscarEspecialidad(especialidad.id_especialidad);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esto es para listar las especialidad de la BD
        /// </summary>
        /// <returns>retorna las especialidad que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.EspecialidadEnt> ListarEspecialidad()
        {
            db_Entities db = new db_Entities();
            List<Entidad.EspecialidadEnt> listaEspecialidad = new List<Entidad.EspecialidadEnt>();
            Entidad.EspecialidadEnt especialidadEnt = new Entidad.EspecialidadEnt();
            try
            {
                foreach (var e in db.Especialidad.ToList())
                {
                    especialidadEnt = new Entidad.EspecialidadEnt
                    {
                        id_especialidad = e.id_especialidad,
                        nom_especialidad = e.nom_especialidad
                    };

                    listaEspecialidad.Add(especialidadEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaEspecialidad;
        }
        /// <summary>
        /// Método para eliminar una especialidad
        /// </summary>
        /// <param name="id_especialidad">por medio del id se buscará y eliminará la especialidad</param>
        /// <returns>si se elimina una especialidad enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarEspecialidad(int id_especialidad)
        {
            db_Entities db = new db_Entities();
            try
            {
                especialidad especialidad = db.Especialidad.FirstOrDefault(e => e.id_especialidad == id_especialidad);

                db.Especialidad.Remove(especialidad);
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
