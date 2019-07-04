using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    /// <summary>
    /// Entidad para el manejo de datos entre la aplicacion y la Base de Datos de la Tabla Usuario
    /// </summary>
    public class UsuarioEnt
    {
        /// <summary>
        /// Id de la Entidad de la tabla Usuario
        /// </summary>
        public int id_usuario { get; set; }
        /// <summary>
        /// Nombre de la Entida de la tabla Usuario
        /// </summary>
        public string nom_usuario { get; set; }
        /// <summary>
        /// Contraseña del Usuario
        /// </summary>
        public string con_usuario { get; set; }
        /// <summary>
        /// Perfil del Usuario
        /// </summary>
        public string tipo_usuario { get; set; }
        /// <summary>
        /// Id de la empresa a la que pertenece el Ususario
        /// </summary>
        public int id_empresa { get; set; }
    }
}
