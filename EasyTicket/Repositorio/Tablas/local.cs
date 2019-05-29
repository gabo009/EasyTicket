using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("local")]
    public class local
    {
        [Column("id_local")]
        public int id_local { get; set; }
        [Column("dir_local")]
        public string dir_local { get; set; }
        [Column("id_empresa")]
        public int id_empresa { get; set; }
        [Column("id_comuna")]
        public int id_comuna { get; set; }

    }
}
