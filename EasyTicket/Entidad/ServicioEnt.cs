using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ServicioEnt
    {
        public int id_servicio { get; set; }
        public string nom_servicio { get; set; }
        public string desc_servicio { get; set; }
        public int id_especialidad { get; set; }
    }
}
