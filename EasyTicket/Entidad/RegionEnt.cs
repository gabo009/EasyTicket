using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Region
    /// </summary>
    public class RegionEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Region
        /// </summary>
        public int id_region { get; set; }
        /// <summary>
        /// Nombre de la Entida de la tabla Region
        /// </summary>
        public string nombre_region { get; set; }
    }
}
