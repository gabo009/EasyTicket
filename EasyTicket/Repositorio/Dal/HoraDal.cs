using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de Hora (Del)
    /// </summary>
    public class HoraDal
    {
        /// <summary>
        /// Método para agregar una Hora en la BD
        /// </summary>
        /// <param name="horaEnt">Objeto de la clase HoraEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarHora(Entidad.HoraEnt horaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                hora hora = new hora
                {
                    ape_cliente = horaEnt.ape_cliente,
                    cel_cliente = horaEnt.cel_cliente,
                    correo_cliente = horaEnt.correo_cliente,
                    fecha = horaEnt.fecha,
                    hora_tomada = horaEnt.hora_tomada,
                    id_hora = horaEnt.id_hora,
                    id_local = horaEnt.id_local,
                    id_servicio = horaEnt.id_servicio,
                    nom_cliente = horaEnt.nom_cliente,
                    rut_cliente = horaEnt.rut_cliente
                };
                db.Hora.Add(hora);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar una Hora en la BD
        /// </summary>
        /// <param name="id_hora">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_hora</returns>
        public Entidad.HoraEnt BuscarHora(int id_hora)
        {
            db_Entities db = new db_Entities();
            Entidad.HoraEnt horaEnt;
            hora hora = db.Hora.FirstOrDefault(h => h.id_hora == id_hora);
            horaEnt = new Entidad.HoraEnt
            {
                ape_cliente = hora.ape_cliente,
                cel_cliente = hora.cel_cliente,
                correo_cliente = hora.correo_cliente,
                fecha = hora.fecha,
                hora_tomada = hora.hora_tomada,
                id_hora = hora.id_hora,
                id_local = hora.id_local,
                id_servicio = hora.id_servicio,
                nom_cliente = hora.nom_cliente,
                rut_cliente = hora.rut_cliente
            };
            return horaEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo Hora
        /// </summary>
        /// <param name="horaEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo hora o un nulo en caso de exception</returns>
        public Entidad.HoraEnt ModificarHora(Entidad.HoraEnt horaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                hora hora = db.Hora.FirstOrDefault(h => h.id_hora == horaEnt.id_hora);

                hora.ape_cliente = horaEnt.ape_cliente;
                hora.cel_cliente = horaEnt.cel_cliente;
                hora.correo_cliente = horaEnt.correo_cliente;
                hora.fecha = horaEnt.fecha;
                hora.hora_tomada = horaEnt.hora_tomada;
                hora.id_hora = horaEnt.id_hora;
                hora.id_local = horaEnt.id_local;
                hora.id_servicio = horaEnt.id_servicio;
                hora.nom_cliente = horaEnt.nom_cliente;
                hora.rut_cliente = horaEnt.rut_cliente;

                db.SaveChanges();

                return BuscarHora(hora.id_hora);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esto es para listar las Hora de la BD
        /// </summary>
        /// <returns>retorna las horas que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.HoraEnt> ListarHora()
        {
            db_Entities db = new db_Entities();
            List<Entidad.HoraEnt> listaHora = new List<Entidad.HoraEnt>();
            Entidad.HoraEnt horaEnt = new Entidad.HoraEnt();
            try
            {
                foreach (var h in db.Hora.ToList())
                {
                    horaEnt = new Entidad.HoraEnt
                    {
                        ape_cliente = h.ape_cliente,
                        cel_cliente = h.cel_cliente,
                        correo_cliente = h.correo_cliente,
                        fecha = h.fecha,
                        hora_tomada = h.hora_tomada,
                        id_hora = h.id_hora,
                        id_local = h.id_local,
                        id_servicio = h.id_servicio,
                        nom_cliente = h.nom_cliente,
                        rut_cliente = h.rut_cliente
                    };

                    listaHora.Add(horaEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaHora;
        }
        /// <summary>
        /// Método para eliminar una Hora
        /// </summary>
        /// <param name="id_hora">por medio del id se buscará y eliminará la hora</param>
        /// <returns>si se elimina una hora enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarHora(int id_hora)
        {
            db_Entities db = new db_Entities();
            try
            {
                hora hora = db.Hora.FirstOrDefault(h => h.id_hora == id_hora);

                db.Hora.Remove(hora);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Entidad.HoraEnt> ListarHoraPorDia(DateTime dia)
        {
            db_Entities db = new db_Entities();
            List<Entidad.HoraEnt> listaHora = new List<Entidad.HoraEnt>();
            Entidad.HoraEnt horaEnt = new Entidad.HoraEnt();
            try
            {
                foreach (var h in db.Hora.Where(h => h.fecha == dia).ToList())
                {
                    horaEnt = new Entidad.HoraEnt
                    {
                        ape_cliente = h.ape_cliente,
                        cel_cliente = h.cel_cliente,
                        correo_cliente = h.correo_cliente,
                        fecha = h.fecha,
                        hora_tomada = h.hora_tomada,
                        id_hora = h.id_hora,
                        id_local = h.id_local,
                        id_servicio = h.id_servicio,
                        nom_cliente = h.nom_cliente,
                        rut_cliente = h.rut_cliente
                    };

                    listaHora.Add(horaEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaHora;
        }
    }
}
