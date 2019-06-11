using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class UsuarioEnt
    {
        public int id_usuario { get; set; }
        public string nom_usuario { get; set; }
        public string con_usuario { get; set; }
        public string tipo_usuario { get; set; }
        public int id_empresa { get; set; }
    }
}
