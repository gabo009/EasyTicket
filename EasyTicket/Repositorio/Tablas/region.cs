using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("region")]
    public class region
    {
        [Key]
        [Column("id_region")]
        public int id_region { get; set; }
        [Column("nombre_region")]
        public string nombre_region { get; set; }

    }
}
