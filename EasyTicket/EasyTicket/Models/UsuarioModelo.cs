using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTicket.Models
{
    /// <summary>
    /// Modelo para el manejo de datos del Usuario
    /// </summary>
    public class UsuarioModelo
    {
        /// <summary>
        /// Id del Usuario
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar el Id. del Usuario.")]
        public int id_usuario { get; set; }
        /// <summary>
        /// Nombre del Usuario
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar Nombre del Usuario.")]
        public string nom_usuario { get; set; }
        /// <summary>
        /// Contraseña del Usuario
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar una Contraseña")]
        public string con_usuario { get; set; }
        /// <summary>
        /// Tipo del Usuario
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar Tipo del Usuario.")]
        public string tipo_usuario { get; set; }
        /// <summary>
        /// ID de la Empresa
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar el ID de la empresa.")]
        public int id_empresa { get; set; }
    }
}