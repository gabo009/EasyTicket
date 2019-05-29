using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("local_serv")]
    public class local_serv
    {
        [Column("id_local")]
        public int id_local { get; set; }
        [Column("id_servicio")]
        public int id_servicio { get; set; }

    }
}
