using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Sexo> Sexos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SaludGeneral"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            modelBuilder.Entity<Sexo>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo);
        }
    }
}
