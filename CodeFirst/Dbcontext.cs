using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class DbCodeFirstEntity:DbContext
    {
        public DbCodeFirstEntity():base("name=CodeFirstDbCodeFirstEntity")
        {
            //Database.SetInitializer<DbCodeFirstEntity>(new CreateDatabaseIfNotExists<DbCodeFirstEntity>());
        }


        public virtual DbSet<Passport> _passport { get; set; }
        public virtual DbSet<PassportStamp> _passportstamp { get; set; }
    }
}
