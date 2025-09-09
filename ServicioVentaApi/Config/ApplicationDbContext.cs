using Microsoft.EntityFrameworkCore;
using ServicioVentaApi.Models.Hamburguesa;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ServicioVentaApi.Config
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Hamburguesa> Hamburguesas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración opcional
            modelBuilder.Entity<Hamburguesa>()
                .Property(h => h.Nombre)
                .HasMaxLength(100);

            modelBuilder.Entity<Hamburguesa>()
                .Property(h => h.Ingredientes)
                .HasMaxLength(500);
        }
    }
}
