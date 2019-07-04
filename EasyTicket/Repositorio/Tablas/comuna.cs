using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("comuna")]
    public class comuna
    {
        [Key]
        [Column("id_comuna")]
        public int id_comuna { get; set; }
        [Column("nombre_comuna")]
        public string nombre_comuna { get; set; }
        [Column("id_region")]
        public int id_region { get; set; }

    }
}
