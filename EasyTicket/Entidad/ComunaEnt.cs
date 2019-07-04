using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Comuna
    /// </summary>
    public class ComunaEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Comuna
        /// </summary>
        public int id_comuna { get; set; }
        /// <summary>
        /// Nombre de la Entida de la tabla Comuna
        /// </summary>
        public string nombre_comuna { get; set; }
        /// <summary>
        /// Id de la Region a la que pertence la Comuna
        /// </summary>
        public int id_region { get; set; }
    }
}
