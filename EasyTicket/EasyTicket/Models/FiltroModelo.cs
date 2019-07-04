using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTicket.Models
{
    public class FiltroModelo
    {
   
        public List<Entidad.LocalEnt> locales { get; set; }

        public List<Entidad.RegionEnt> regiones { get; set; }

        public List<Entidad.ServicioEnt> servicios { get; set; }

        public List<Entidad.LocalServEnt> localservicios { get; set; }

        public List<Entidad.EspecialidadEnt> especialidades { get; set; }

        public List<Entidad.ComunaEnt> comunas { get; set; }
    }
}