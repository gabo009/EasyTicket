using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTicket.Models
{
    /// <summary>
    /// Modelo para el manejo de datos de la Empresa
    /// </summary>
    public class EmpresaModelo
    {
        /// <summary>
        /// Id de la Empresa
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar el Id. de la Empresa.")]
        public int id_empresa { get; set; }
        /// <summary>
        /// Nombre de la Empresa
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar Nombre de la Empresa.")]
        public string nom_empresa { get; set; }
        /// <summary>
        /// Rut de la Empresa
        /// </summary>
        [Required(ErrorMessage = "Debe ingresar el Rut de la Empresa.")]
        public string rut_empresa { get; set; }
    }
}