using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de Servicio (Del)
    /// </summary>
    public class ServicioDal
    {
        /// <summary>
        /// Método para agregar una Region en la BD
        /// </summary>
        /// <param name="servicioEnt">Objeto de la clase servicioEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarServicio(Entidad.ServicioEnt servicioEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                servicio servicio = new servicio
                {
                    id_servicio = servicioEnt.id_servicio,
                    nom_servicio = servicioEnt.nom_servicio,
                    desc_servicio = servicioEnt.desc_servicio,
                    id_especialidad = servicioEnt.id_especialidad
                };
                db.Servicio.Add(servicio);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar una servicio en la BD
        /// </summary>
        /// <param name="id_servicio">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_servicio</returns>
        public Entidad.ServicioEnt BuscarServicio(int id_servicio)
        {
            db_Entities db = new db_Entities();
            Entidad.ServicioEnt servicioEnt;
            servicio servicio = db.Servicio.FirstOrDefault(s => s.id_servicio == id_servicio);
            servicioEnt = new Entidad.ServicioEnt
            {
                id_servicio = servicio.id_servicio,
                nom_servicio = servicio.nom_servicio,
                desc_servicio = servicio.desc_servicio,
                id_especialidad = servicio.id_especialidad
            };
            return servicioEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo region
        /// </summary>
        /// <param name="servicioEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo servicio o un nulo en caso de exception</returns>
        public Entidad.ServicioEnt ModificarServicio(Entidad.ServicioEnt servicioEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                servicio servicio = db.Servicio.FirstOrDefault(s => s.id_servicio == servicioEnt.id_servicio);

                servicio.id_servicio = servicioEnt.id_servicio;
                servicio.nom_servicio = servicioEnt.nom_servicio;
                servicio.desc_servicio = servicioEnt.desc_servicio;
                servicio.id_especialidad = servicioEnt.id_especialidad;

                db.SaveChanges();

                return BuscarServicio(servicio.id_servicio);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esto es para listar los servicio de la BD
        /// </summary>
        /// <returns>retorna los servicios que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.ServicioEnt> ListarServicio()
        {
            db_Entities db = new db_Entities();
            List<Entidad.ServicioEnt> ListaServicio = new List<Entidad.ServicioEnt>();
            Entidad.ServicioEnt servicioEnt = new Entidad.ServicioEnt();
            try
            {
                foreach (var s in db.Servicio.ToList())
                {
                    servicioEnt = new Entidad.ServicioEnt
                    {
                        id_servicio = s.id_servicio,
                        nom_servicio = s.nom_servicio,
                        desc_servicio = s.desc_servicio,
                        id_especialidad = s.id_especialidad
                    };

                    ListaServicio.Add(servicioEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return ListaServicio;
        }
        /// <summary>
        /// Método para eliminar un servicio
        /// </summary>
        /// <param name="id_servicio">por medio del id se buscará y eliminará el servicio</param>
        /// <returns>si se elimina un servicio enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarServicio(int id_servicio)
        {
            db_Entities db = new db_Entities();
            try
            {
                servicio servicio = db.Servicio.FirstOrDefault(s => s.id_servicio == id_servicio);

                db.Servicio.Remove(servicio);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Entidad.ServicioEnt> ListarPorEspecialidad(int Id_Especialidad)
        {
            db_Entities db = new db_Entities();
            List<Entidad.ServicioEnt> listaServicios = new List<Entidad.ServicioEnt>();
            Entidad.ServicioEnt servicioEnt = new Entidad.ServicioEnt();
            try
            {
                foreach (var ser in db.Servicio.Where(s => s.id_especialidad == Id_Especialidad).ToList())
                {
                    servicioEnt = new Entidad.ServicioEnt()
                    {
                        id_servicio = ser.id_servicio,
                        nom_servicio = ser.nom_servicio,
                        desc_servicio = ser.desc_servicio,
                        id_especialidad = ser.id_especialidad
                    };

                    listaServicios.Add(servicioEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaServicios;
        }
    }
}
