using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class ServicioDal
    {
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
    }
}
