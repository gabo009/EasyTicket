using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class ComunaDal
    {
        public bool AgregarComuna(Entidad.ComunaEnt comunaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                comuna comuna = new comuna
                {
                    id_comuna = comunaEnt.id_comuna,
                    id_region = comunaEnt.id_region,
                    NOMBRE_COMUNA = comunaEnt.NOMBRE_COMUNA
                };
                db.Comuna.Add(comuna);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Entidad.ComunaEnt BuscarComuna(int idComuna)
        {
            db_Entities db = new db_Entities();
            Entidad.ComunaEnt comunaEnt;
            comuna comunaRes = db.Comuna.FirstOrDefault(c => c.id_comuna == idComuna);
            comunaEnt = new Entidad.ComunaEnt
            {
                id_comuna = comunaRes.id_comuna,
                id_region = comunaRes.id_region,
                NOMBRE_COMUNA = comunaRes.NOMBRE_COMUNA,
            };
            return comunaEnt;

        }
        public Entidad.ComunaEnt ModificarComuna(Entidad.ComunaEnt comunaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                comuna comunaRes = db.Comuna.FirstOrDefault(c => c.id_comuna == comunaEnt.id_comuna);

                comunaRes.id_comuna = comunaEnt.id_comuna;
                comunaRes.id_region = comunaEnt.id_region;
                comunaRes.NOMBRE_COMUNA = comunaEnt.NOMBRE_COMUNA;
                
                db.SaveChanges();

                return BuscarComuna(comunaRes.id_comuna);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Entidad.ComunaEnt> ListarComuna()
        {
            db_Entities db = new db_Entities();
            List<Entidad.ComunaEnt> listaComunas = new List<Entidad.ComunaEnt>();
            Entidad.ComunaEnt comunaEnt = new Entidad.ComunaEnt();
            try
            {
                foreach (var c in db.Comuna.ToList())
                {
                    comunaEnt = new Entidad.ComunaEnt
                    {
                       id_comuna = c.id_comuna,
                       id_region = c.id_region,
                       NOMBRE_COMUNA = c.NOMBRE_COMUNA
                    };

                    listaComunas.Add(comunaEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaComunas;
        }
        public bool EliminarComuna(int id_comuna)
        {
            db_Entities db = new db_Entities();
            try
            {
                comuna comunaRes = db.Comuna.FirstOrDefault(c => c.id_comuna == id_comuna);

                db.Comuna.Remove(comunaRes);
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
