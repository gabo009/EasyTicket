using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de hora
    /// </summary>
    public class HoraCrud
    {
        /// <summary>
        /// Método del CRUD para agregar una hora en la BD
        /// </summary>
        /// <param name="horaEnt">Objeto de la clase HoraEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarHora(Entidad.HoraEnt horaEnt)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.AgregarHora(horaEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar una hora en la BD
        /// </summary>
        /// <param name="id_hora">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_hora</returns>
        public Entidad.HoraEnt BuscarHora(int id_hora)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.BuscarHora(id_hora);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo hora
        /// </summary>
        /// <param name="horaEnt">Objeto de la clase HoraEnt</param>
        /// <returns>retorna un obj de tipo HoraEnt o un nulo en caso de exception</returns>
        public Entidad.HoraEnt ModificarHora(Entidad.HoraEnt horaEnt)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.ModificarHora(horaEnt);
        }
        /// <summary>
        /// Esto es para listar las horas de la BD
        /// </summary>
        /// <returns>retorna las horas que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.HoraEnt> ListarHora()
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.ListarHora();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara una hora de la BD
        /// </summary>
        /// <param name="id_hora">argumento del tipo int que corresponde al id de la hora</param>
        /// <returns>si se elimina una hora enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarHora(int id_hora)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.EliminarHora(id_hora);
        }
        public List<Entidad.HoraEnt> ListarHoraPorDia(DateTime dia)
        {
            Repositorio.Dal.HoraDal dal = new Repositorio.Dal.HoraDal();
            return dal.ListarHoraPorDia(dia);
        }
    }
}
