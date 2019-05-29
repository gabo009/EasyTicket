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
        [Column("id_comuna")]
        public int id_comuna { get; set; }
        [Column("NOMBRE_COMUNA")]
        public string NOMBRE_COMUNA { get; set; }
        [Column("id_region")]
        public string id_region { get; set; }

    }
}
