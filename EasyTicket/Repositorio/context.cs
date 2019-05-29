using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "MyContext") { }

        public DbSet<comuna> Comuna { get; set; }
        public DbSet<empresa> Empresa { get; set; }
        public DbSet<especialidad> Especialidad { get; set; }
        public DbSet<hora> Hora { get; set; }
        public DbSet<local> Local { get; set; }
        public DbSet<local_serv> Local_serv { get; set; }
        public DbSet<region> Region { get; set; }
        public DbSet<servicio> Servicio { get; set; }
        public DbSet<usuario> Usuario { get; set; }
    }
}
