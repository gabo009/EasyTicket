using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTicket.Models
{
    public class HoraModelo
    {
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public int id_hora { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public String fecha { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public int hora_tomada { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public string rut_cliente { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public string nom_cliente { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public string ape_cliente { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public string correo_cliente { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public int cel_cliente { get; set; }
        [Range(1, 500, ErrorMessage = "Please enter correct value")]
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public int id_local { get; set; }
        [Range(1, 500, ErrorMessage = "Please enter correct value")]
        [Required(ErrorMessage = "Debe ingresar el Id. de la Comuna.")]
        public int id_servicio { get; set; }

        public List<Entidad.HoraEnt> horasTomadas { get; set; }
    }
}