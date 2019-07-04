using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Local
    /// </summary>
    public class LocalEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Local
        /// </summary>
        public int id_local { get; set; }
        /// <summary>
        /// Direccion de la Entida de la tabla Local
        /// </summary>
        public string dir_local { get; set; }
        /// <summary>
        /// Id de la Empresa a la que pertenece el Local
        /// </summary>
        public int id_empresa { get; set; }
        /// <summary>
        /// Id de la Comuna en la que esta el Local
        /// </summary>
        public int id_comuna { get; set; }
    }
}
