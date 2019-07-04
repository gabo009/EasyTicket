using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de Region (Del)
    /// </summary>
    public class RegionDal
    {
        /// <summary>
        /// Método para agregar una Region en la BD
        /// </summary>
        /// <param name="regionEnt">Objeto de la clase RegionEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarRegion(Entidad.RegionEnt regionEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                region region = new region
                {
                    id_region = regionEnt.id_region,
                    nombre_region = regionEnt.nombre_region
                };
                db.Region.Add(region);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar una region en la BD
        /// </summary>
        /// <param name="id_region">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_region</returns>
        public Entidad.RegionEnt BuscarRegion(int id_region)
        {
            db_Entities db = new db_Entities();
            Entidad.RegionEnt regionEnt;
            region region = db.Region.FirstOrDefault(r => r.id_region == id_region);
            regionEnt = new Entidad.RegionEnt
            {
                id_region = region.id_region,
                nombre_region = region.nombre_region
            };
            return regionEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo region
        /// </summary>
        /// <param name="regionEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo region o un nulo en caso de exception</returns>
        public Entidad.RegionEnt ModificarRegion(Entidad.RegionEnt regionEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                region region = db.Region.FirstOrDefault(r => r.id_region == regionEnt.id_region);

                region.id_region = regionEnt.id_region;
                region.nombre_region = regionEnt.nombre_region;

                db.SaveChanges();

                return BuscarRegion(region.id_region);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esto es para listar las region de la BD
        /// </summary>
        /// <returns>retorna las regiones que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.RegionEnt> ListarRegion()
        {
            db_Entities db = new db_Entities();
            List<Entidad.RegionEnt> ListaRegion = new List<Entidad.RegionEnt>();
            Entidad.RegionEnt regionEnt = new Entidad.RegionEnt();
            try
            {
                foreach (var r in db.Region.ToList())
                {
                    regionEnt = new Entidad.RegionEnt
                    {
                        id_region = r.id_region,
                        nombre_region = r.nombre_region
                    };

                    ListaRegion.Add(regionEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return ListaRegion;
        }
        /// <summary>
        /// Método para eliminar una region
        /// </summary>
        /// <param name="id_region">por medio del id se buscará y eliminará la region</param>
        /// <returns>si se elimina una hora enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarRegion(int id_region)
        {
            db_Entities db = new db_Entities();
            try
            {
                region region = db.Region.FirstOrDefault(r => r.id_region == id_region);

                db.Region.Remove(region);
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
