using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Table("usuario")]
    public class usuario
    {
        [Column("id_usuario")]
        public int id_usuario { get; set; }
        [Column("nom_usuario")]
        public string nom_usuario { get; set; }
        [Column("con_usuario")]
        public string con_usuario { get; set; }
        [Column("tipo_usuario")]
        public string tipo_usuario { get; set; }
        [Column("id_empresa")]
        public int id_empresa { get; set; }

    }
}
