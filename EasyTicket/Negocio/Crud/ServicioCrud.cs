using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de Servicio
    /// </summary>
    public class ServicioCrud
    {
        /// <summary>
        /// Método del CRUD para agregar un Servicio en la BD
        /// </summary>
        /// <param name="servicioEnt">Objeto de la clase ServicioEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarServicio(Entidad.ServicioEnt servicioEnt)
        {
            Repositorio.Dal.ServicioDal dal = new Repositorio.Dal.ServicioDal();
            return dal.AgregarServicio(servicioEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar un Servicio en la BD
        /// </summary>
        /// <param name="id_servicio">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_servicio</returns>
        public Entidad.ServicioEnt BuscarServicio(int id_servicio)
        {
            Repositorio.Dal.ServicioDal dal = new Repositorio.Dal.ServicioDal();
            return dal.BuscarServicio(id_servicio);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo servicio
        /// </summary>
        /// <param name="servicioEnt">Objeto de la clase ServicioEnt</param>
        /// <returns>retorna un obj de tipo ServicioEnt o un nulo en caso de exception</returns>
        public Entidad.ServicioEnt ModificarServicio(Entidad.ServicioEnt servicioEnt)
        {
            Repositorio.Dal.ServicioDal dal = new Repositorio.Dal.ServicioDal();
            return dal.ModificarServicio(servicioEnt);
        }
        /// <summary>
        /// Esto es para listar los servicio de la BD
        /// </summary>
        /// <returns>retorna los servicios que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.ServicioEnt> ListarServicio()
        {
            Repositorio.Dal.ServicioDal dal = new Repositorio.Dal.ServicioDal();
            return dal.ListarServicio();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara un servicio de la BD
        /// </summary>
        /// <param name="id_servicio">argumento del tipo int que corresponde al id del servicio</param>
        /// <returns>si se elimina un servicio enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarServicio(int id_servicio)
        { 
            Repositorio.Dal.ServicioDal dal = new Repositorio.Dal.ServicioDal();
            return dal.EliminarServicio(id_servicio);
        }
        public List<Entidad.ServicioEnt> ListarPorEspecialidad(int Id_Especialidad)
        {
            Repositorio.Dal.ServicioDal dal = new Repositorio.Dal.ServicioDal();
            return dal.ListarPorEspecialidad(Id_Especialidad);
        }
    }
}
