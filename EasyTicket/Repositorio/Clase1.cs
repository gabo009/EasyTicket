using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("clase1")]
    public class Clase1
    {
        [Key]
        [Column("Codigo")]
        public int Codigo { get; set; }
        [Column("Numero")]
        public int Numero { get; set; }

    }
}
