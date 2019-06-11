using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class HoraEnt
    {
        public int id_hora { get; set; }
        public DateTime fecha_hora { get; set; }
        public string rut_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string ape_cliente { get; set; }
        public string correo_cliente { get; set; }
        public int cel_cliente { get; set; }
        public int id_local { get; set; }
        public int id_servicio { get; set; }
    }
}
