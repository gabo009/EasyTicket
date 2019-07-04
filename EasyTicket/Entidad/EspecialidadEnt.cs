using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Especialidad
    /// </summary>
    public class EspecialidadEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Especialidad
        /// </summary>
        public int id_especialidad { get; set; }
        /// <summary>
        /// Nombre de la Entida de la tabla Especialidad
        /// </summary>
        public string nom_especialidad { get; set; }
    }
}
