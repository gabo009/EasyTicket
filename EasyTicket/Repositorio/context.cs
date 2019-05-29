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

        public DbSet<Clase1> Clase1 { get; set; }
    }
}
