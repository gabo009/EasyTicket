using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("servicio")]
    public class servicio
    {
        [Key]
        [Column("id_servicio")]
        public int id_servicio { get; set; }
        [Column("nom_servicio")]
        public string nom_servicio { get; set; }
        [Column("desc_servicio")]
        public string desc_servicio { get; set; }
        [Column("id_especialidad")]
        public int id_especialidad { get; set; }
    }
}
