using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de Comuna
    /// </summary>
    public class ComunaCrud
    {
        /// <summary>
        /// Metodo del CRUD para agregar comuna a la BD
        /// </summary>
        /// <param name="comunaEnt">objeto de la clase ComunaEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception</returns>
        public bool AgregarComuna(Entidad.ComunaEnt comunaEnt)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.AgregarComuna(comunaEnt);
        }
        /// <summary>
        /// Metodo deL CRUD para buscar una comuna 
        /// </summary>
        /// <param name="idComuna">un atributo de la clase ComunaEnt, un int</param>
        /// <returns>retorna el objeto de la clase comuna Ent</returns>
        public Entidad.ComunaEnt BuscarComuna(int idComuna)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.BuscarComuna(idComuna);
        }
        /// <summary>
        /// Metodo del CRUD para Modificar un objeto de la clase ComunaEnt
        /// </summary>
        /// <param name="comunaEnt">objeto llamado de la clase ComunaEnt</param>
        /// <returns>retorna el id de la comuna ingresada</returns>
        public Entidad.ComunaEnt ModificarComuna(Entidad.ComunaEnt comunaEnt)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.ModificarComuna(comunaEnt);
        }
        /// <summary>
        /// Metodo del CRUD para listar las Comunas
        /// </summary>
        /// <returns>retorna los nombres las comunas de la clase ComunaEnt en una lista guardadas en la BD</returns>
        public List<Entidad.ComunaEnt> ListarComuna()
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.ListarComuna();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara una comuna de la BD
        /// </summary>
        /// <param name="id_comuna">argumento del tipo int que corresponde al id de la comuna</param>
        /// <returns>si se elimina una comuna enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarComuna(int id_comuna)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.EliminarComuna(id_comuna);
        }
        public List<Entidad.ComunaEnt> ListarPorRegion(int Id_Region)
        {
            Repositorio.Dal.ComunaDal dal = new Repositorio.Dal.ComunaDal();
            return dal.ListarPorRegion(Id_Region);
        }
    }
}
