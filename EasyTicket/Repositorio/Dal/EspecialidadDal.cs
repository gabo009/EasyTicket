using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class EspecialidadDal
    {
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
