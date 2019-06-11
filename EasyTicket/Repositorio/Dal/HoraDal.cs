using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class HoraDal
    {
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
                   fecha_hora = horaEnt.fecha_hora,
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
                fecha_hora = hora.fecha_hora,
                id_hora = hora.id_hora,
                id_local = hora.id_local,
                id_servicio = hora.id_servicio,
                nom_cliente = hora.nom_cliente,
                rut_cliente = hora.rut_cliente
            };
            return horaEnt;
        }
        public Entidad.HoraEnt ModificarHora(Entidad.HoraEnt horaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                hora hora = db.Hora.FirstOrDefault(h => h.id_hora == horaEnt.id_hora);

                hora.ape_cliente = horaEnt.ape_cliente;
                hora.cel_cliente = horaEnt.cel_cliente;
                hora.correo_cliente = horaEnt.correo_cliente;
                hora.fecha_hora = horaEnt.fecha_hora;
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
                        fecha_hora = h.fecha_hora,
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
    }
}
