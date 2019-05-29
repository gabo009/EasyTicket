using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("hora")]
    public class hora
    {
        [Column("id_hora")]
        public int id_hora { get; set; }
        [Column("fecha_hora")]
        public DateTime fecha_hora { get; set; }
        [Column("rut_cliente")]
        public string rut_cliente { get; set; }
        [Column("nom_cliente")]
        public string nom_cliente { get; set; }
        [Column("ape_cliente")]
        public string ape_cliente { get; set; }
        [Column("correo_cliente")]
        public string correo_cliente { get; set; }
        [Column("cel_cliente")]
        public int cel_cliente { get; set; }
        [Column("id_local")]
        public int id_local { get; set; }
        [Column("id_servicio")]
        public int id_servicio { get; set; }
    }
}
