using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("empresa")]
    public class empresa
    {
        [Column("id_empresa")]
        public int id_empresa { get; set; }
        [Column("nom_empresa")]
        public string nom_empresa { get; set; }
        [Column("rut_empresa")]
        public string rut_empresa { get; set; }

    }
}
