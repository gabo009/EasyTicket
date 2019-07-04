using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Servicio
    /// </summary>
    public class ServicioEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Servicio
        /// </summary>
        public int id_servicio { get; set; }
        /// <summary>
        /// Nombre de la Entida de la tabla Servicio
        /// </summary>
        public string nom_servicio { get; set; }
        /// <summary>
        /// Descripcion del Servicio
        /// </summary>
        public string desc_servicio { get; set; }
        /// <summary>
        /// Id de la especialidad a la que corresponde el Servicio
        /// </summary>
        public int id_especialidad { get; set; }
    }
}
