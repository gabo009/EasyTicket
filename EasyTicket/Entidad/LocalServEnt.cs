using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Local_Servicio
    /// </summary>
    public class LocalServEnt
    {
        /// <summary>
        /// Id del Local que ofrese los Servicios
        /// </summary>
        public int id_local { get; set; }
        /// <summary>
        /// Id del Servicio ofrecido en el Local
        /// </summary>
        public int id_servicio { get; set; }
    }
}
