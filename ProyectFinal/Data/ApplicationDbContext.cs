using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Share.Models;
using Shared1.Models;

namespace ProyectFinal.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Sentencias> Sentencias { get; set; }
        public DbSet<TiposDemandas> TiposDemandas { get; set; }
        //public DbSet<Niños> Niños { get; set; }
        public DbSet<TipoResoluciones> TipoResoluciones { get; set; }
        public DbSet<Expedientes> Expedientes { get; set; }
        public DbSet<DemandasDetalle> DemandaDetalles { get; set; }
        public DbSet<EstadosDemandas> EstadosDemandas { get; set; }
        public DbSet<EmpleadoSentencia> EmpleadoSentencia { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Demandas> Demandas { get; set; }
        public DbSet<Audiencias> Audiencias { get; set; }
        public DbSet<Alguaciles> Alguaciles { get; set; }
        public DbSet<UsuarioDetalle> UsuarioDetalles { get; set; }
        public DbSet<NinoDetalle> NinoDetalles { get; set; }
        //public DbSet<UsuarioExpedienteDetalle> UsuarioExpedienteDetalle { get; set; }
        



    }
}
