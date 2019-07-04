using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Hora
    /// </summary>
    public class HoraEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Hora
        /// </summary>
        public int id_hora { get; set; }
        /// <summary>
        /// Fecha y Hora que fue tomada
        /// </summary>
        public DateTime fecha { get; set; }
        public int hora_tomada { get; set; }
        /// <summary>
        /// Rut del cliente que tomo la Hora
        /// </summary>
        public string rut_cliente { get; set; }
        /// <summary>
        /// Nombre del Ciente que tomo la Hora
        /// </summary>
        public string nom_cliente { get; set; }
        /// <summary>
        /// Apellido del Cliente que tomo la Hora
        /// </summary>
        public string ape_cliente { get; set; }
        /// <summary>
        /// Correo electronico del Cliente que tomo la Hora
        /// </summary>
        public string correo_cliente { get; set; }
        /// <summary>
        /// Celular del Cliente que tomo la Hora
        /// </summary>
        public int cel_cliente { get; set; }
        /// <summary>
        /// Id del local en el que se tomo la Hora
        /// </summary>
        public int id_local { get; set; }
        /// <summary>
        /// Id del Servicio en el que se tomo la Hora
        /// </summary>
        public int id_servicio { get; set; }
    }
}
