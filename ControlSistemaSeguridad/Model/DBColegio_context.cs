using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ControlSistemaSeguridad.Model
{
    public class DBColegio_context : DbContext
    {
        public DbSet<Puesto> Puestos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Puesto>()
                .ToTable("Puestos")
                .HasKey(p => new { p.PuestoId })
                .Property(d => d.Descripcion)
                .IsRequired()
                .HasMaxLength(256)
                ;

        }
    }
}
