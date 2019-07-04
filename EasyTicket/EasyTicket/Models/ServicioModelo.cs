using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTicket.Models
{
    /// <summary>
    /// Modelo para el manejo de datos del Servicio
    /// </summary>
    public class ServicioModelo
    {
        /// <summary>
        /// Id del Servicio
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar el Id. del Servicio.")]
        public int id_servicio { get; set; }
        /// <summary>
        /// Nombre del Servicio
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar Nombre del Servicio.")]
        public string nom_servicio { get; set; }
        /// <summary>
        /// desc del Servicio
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar desc del Servicio")]
        public string desc_servicio { get; set; }
        /// <summary>
        /// ID de la especialidad
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar id de especialidad.")]
        public int id_especialidad { get; set; }
    }
}