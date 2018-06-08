using IPSUniversitaria.Elementos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IPSUniversitaria.Datos
{
   public class Context: DbContext
    {
       public Context()
            : base("name=IPSUniversitaria") 
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<LMedicamento> XMedicamentos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<FormaFarmaceutica> FormasFarmaceuticas { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.TiposDocumento)
                .HasForeignKey(p => p.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciudad>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.Ciudades)
                .HasForeignKey(p => p.IdCiudad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormaFarmaceutica>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.FormasFarmaceuticas)
                .HasForeignKey(p => p.IdFormaFarmaceutica)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LMedicamento>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.XMedicamentos)
                .HasForeignKey(p => p.IdMedicamento)
                .WillCascadeOnDelete(false);

        }
    }
}
