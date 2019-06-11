using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class RegionDal
    {
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
