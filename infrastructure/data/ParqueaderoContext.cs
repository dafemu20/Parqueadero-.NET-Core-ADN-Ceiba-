using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Parqueadero.data
{
    public class ParqueaderoContext: DbContext
    {
        public ParqueaderoContext(DbContextOptions<ParqueaderoContext> options)
            : base(options)
        {}

        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo{ get; set; }
        public DbSet<PicoPlaca> PicoPlaca { get; set; }
        public DbSet<Tiquete> Tiquete { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>()
                .HasKey(v => new { v.VehiculoId, v.VehiculoPlaca});
        }
    }
}
