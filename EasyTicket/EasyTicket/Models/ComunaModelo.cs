using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTicket.Models
{
    /// <summary>
    /// Modelo para el manejo de datos de la Comuna
    /// </summary>
    public class ComunaModelo
    {
        /// <summary>
        /// Id de la Comuna
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public int id_comuna { get; set; }
        /// <summary>
        /// Nombre de la Comuna
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar Nombre de la Comuna.")]
        public string nombre_comuna { get; set; }
        /// <summary>
        /// Id de la Region a la que pertenece la comuna
        /// </summary>
        [Required(ErrorMessage = "Debe seleccionar la Region a la que pertenece la Comuna.")]
        public int id_region { get; set; }
    }
}