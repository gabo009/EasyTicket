using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de Region
    /// </summary>
    public class RegionCrud
    {
        /// <summary>
        /// Método del CRUD para agregar una Region en la BD
        /// </summary>
        /// <param name="regionEnt">Objeto de la clase RegionEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarRegion(Entidad.RegionEnt regionEnt)
        {
            Repositorio.Dal.RegionDal dal = new Repositorio.Dal.RegionDal();
            return dal.AgregarRegion(regionEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar una Region en la BD
        /// </summary>
        /// <param name="id_region">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_region</returns>
        public Entidad.RegionEnt BuscarRegion(int id_region)
        {
            Repositorio.Dal.RegionDal dal = new Repositorio.Dal.RegionDal();
            return dal.BuscarRegion(id_region);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo region
        /// </summary>
        /// <param name="regionEnt">Objeto de la clase RegionEnt</param>
        /// <returns>retorna un obj de tipo RegionEnt o un nulo en caso de exception</returns>
        public Entidad.RegionEnt ModificarRegion(Entidad.RegionEnt regionEnt)
        {
            Repositorio.Dal.RegionDal dal = new Repositorio.Dal.RegionDal();
            return dal.ModificarRegion(regionEnt);
        }
        /// <summary>
        /// Esto es para listar las region de la BD
        /// </summary>
        /// <returns>retorna las regiones que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.RegionEnt> ListarRegion()
        {
            Repositorio.Dal.RegionDal dal = new Repositorio.Dal.RegionDal();
            return dal.ListarRegion();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara una region de la BD
        /// </summary>
        /// <param name="id_region">argumento del tipo int que corresponde al id de la Region</param>
        /// <returns>si se elimina una region enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarRegion(int id_region)
        {
            Repositorio.Dal.RegionDal dal = new Repositorio.Dal.RegionDal();
            return dal.EliminarRegion(id_region);
        }
    }
}
