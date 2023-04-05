using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebPrueba.Models;

namespace WebPrueba.DbContext
{
    public class Context : System.Data.Entity.DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }

        public Context() : base("AuthMVC")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}