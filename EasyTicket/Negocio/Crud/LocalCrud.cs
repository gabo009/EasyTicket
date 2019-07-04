using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de local
    /// </summary>
    public class LocalCrud
    {
        /// <summary>
        /// Método del CRUD para agregar un local en la BD
        /// </summary>
        /// <param name="localEnt">Objeto de la clase LocalEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarLocal(Entidad.LocalEnt localEnt)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.AgregarLocal(localEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar un local en la BD
        /// </summary>
        /// <param name="id_local">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_local</returns>
        public Entidad.LocalEnt BuscarLocal(int id_local)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.BuscarLocal(id_local);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo local
        /// </summary>
        /// <param name="localEnt">Objeto de la clase HoraEnt</param>
        /// <returns>retorna un obj de tipo LocalEnt o un nulo en caso de exception</returns>
        public Entidad.LocalEnt ModificarLocal(Entidad.LocalEnt localEnt)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.ModificarLocal(localEnt);
        }
        /// <summary>
        /// Esto es para listar las locales de la BD
        /// </summary>
        /// <returns>retorna los locales que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.LocalEnt> ListarLocal()
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.ListarLocal();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara un local de la BD
        /// </summary>
        /// <param name="id_local">argumento del tipo int que corresponde al id del local</param>
        /// <returns>si se elimina un local enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarLocal(int id_local)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.EliminarLocal(id_local);
        }
        public List<Entidad.LocalEnt> ListarPorCom(int id_comuna)
        {
            Repositorio.Dal.LocalDal dal = new Repositorio.Dal.LocalDal();
            return dal.ListarPorCom(id_comuna);
        }
        public List<Entidad.LocalEnt> ListarPorServ(int id_servicio)
        {
            List<Entidad.LocalEnt> listaLocalEnt = new List<Entidad.LocalEnt>();
            Repositorio.Dal.LocalDal dalLocal = new Repositorio.Dal.LocalDal();
            Repositorio.Dal.LocalServDal dalLocalServ = new Repositorio.Dal.LocalServDal();
            foreach (var item in dalLocalServ.ListarLocales(id_servicio))
            {
                listaLocalEnt.Add(dalLocal.BuscarLocal(item.id_local));
            }
            return listaLocalEnt;
        }
        public List<Entidad.LocalEnt> ListarPorServCom(int id_servicio, int id_comuna)
        {
            List<Entidad.LocalEnt> resultado = new List<Entidad.LocalEnt>();
            Repositorio.Dal.LocalDal dalLocal = new Repositorio.Dal.LocalDal();
            List<Entidad.LocalEnt> listaLocalCom = dalLocal.ListarPorCom(id_comuna);
            List<Entidad.LocalEnt> listaLocalServ = this.ListarPorServ(id_servicio);
            foreach (var serv in listaLocalServ)
            {
                foreach (var com in listaLocalCom)
                {
                    if (com.id_local == serv.id_local)
                    {
                        resultado.Add(com);
                    }
                }
            }
            return resultado;
        }
    }
}
