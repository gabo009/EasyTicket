using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("especialidad")]
    public class especialidad
    {
        [Column("id_especialidad")]
        public int id_especialidad { get; set; }
        [Column("nom_especialidad")]
        public string nom_especialidad { get; set; }

    }
}
