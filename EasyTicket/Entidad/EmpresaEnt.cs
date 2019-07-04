using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Empresa
    /// </summary>
    public class EmpresaEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Empresa
        /// </summary>
        public int id_empresa { get; set; }
        /// <summary>
        /// Nombre de la Entida de la tabla Empresa
        /// </summary>
        public string nom_empresa { get; set; }
        /// <summary>
        /// Rut de la Entidad de la tabla Empresa
        /// </summary>
        public string rut_empresa { get; set; }
    }
}
