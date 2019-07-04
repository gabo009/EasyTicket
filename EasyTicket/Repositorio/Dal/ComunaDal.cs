using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso a la base de datos de Comuna
    /// </summary>
    public class ComunaDal
    {/// <summary>
     /// Metodo de Dal para agregar comuna a la BD
     /// </summary>
     /// <param name="comunaEnt">objeto de la clase ComunaEnt</param>
     /// <returns>retorna un verdadero o un falso en caso de exception</returns>
        public bool AgregarComuna(Entidad.ComunaEnt comunaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                comuna comuna = new comuna
                {
                    id_comuna = comunaEnt.id_comuna,
                    id_region = comunaEnt.id_region,
                    nombre_comuna = comunaEnt.nombre_comuna
                };
                db.Comuna.Add(comuna);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }/// <summary>
         /// Metodo de Dal para buscar una comuna 
         /// </summary>
         /// <param name="idComuna">un atributo de la clase ComunaEnt, un int</param>
         /// <returns>retorna el objeto de la clase comuna Ent</returns>
        public Entidad.ComunaEnt BuscarComuna(int idComuna)
        {
            db_Entities db = new db_Entities();
            Entidad.ComunaEnt comunaEnt;
            comuna comunaRes = db.Comuna.FirstOrDefault(c => c.id_comuna == idComuna);
            comunaEnt = new Entidad.ComunaEnt
            {
                id_comuna = comunaRes.id_comuna,
                id_region = comunaRes.id_region,
                nombre_comuna = comunaRes.nombre_comuna,
            };
            return comunaEnt;

        }
        /// <summary>
        /// Metodo para Modificar un objeto de la clase ComunaEnt
        /// </summary>
        /// <param name="comunaEnt">objeto llamado de la clase ComunaEnt</param>
        /// <returns>retorna el id de la comuna ingresada</returns>
        public Entidad.ComunaEnt ModificarComuna(Entidad.ComunaEnt comunaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                comuna comunaRes = db.Comuna.FirstOrDefault(c => c.id_comuna == comunaEnt.id_comuna);

                comunaRes.id_comuna = comunaEnt.id_comuna;
                comunaRes.id_region = comunaEnt.id_region;
                comunaRes.nombre_comuna = comunaEnt.nombre_comuna;

                db.SaveChanges();

                return BuscarComuna(comunaRes.id_comuna);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Metodo para listar los objetos 
        /// </summary>
        /// <returns>retorna los nombres las comunas de la clase ComunaEnt en una lista guardadas en la BD</returns>
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
                        nombre_comuna = c.nombre_comuna
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
        /// <summary>
        /// Método para eliminar una comuna de la BD
        /// </summary>
        /// <param name="id_comuna">por medio del id se buscará y eliminará la comuna</param>
        /// <returns>si se elimina una comuna enviara un verdadero, si no mandará un falso</returns>
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
        public List<Entidad.ComunaEnt> ListarPorRegion(int Id_Region)
        {
            db_Entities db = new db_Entities();
            List<Entidad.ComunaEnt> listaComunas = new List<Entidad.ComunaEnt>();
            Entidad.ComunaEnt comunaEnt = new Entidad.ComunaEnt();
            try
            {
                foreach (var com in db.Comuna.Where(c => c.id_region == Id_Region).ToList())
                {
                    comunaEnt = new Entidad.ComunaEnt
                    {
                        id_comuna = com.id_comuna,
                        id_region = com.id_region,
                        nombre_comuna = com.nombre_comuna
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
    }
}