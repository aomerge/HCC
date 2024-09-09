using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.src.model;

public class AppDbContext : DbContext
{    
    public DbSet<tbHccOrdenes> Ordenes { get; set; }
    public DbSet<tbHccOrdenDetalle> DetallesOrden { get; set; }
    public DbSet<tb_HccMesas> Mesas { get; set; }
    public DbSet<tbHccEstatusOrden> EstatusOrdenes { get; set; }
    public DbSet<tbHccProducto> Productos { get; set; }
    public DbSet<tbHccAlmacen> Almacenes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<tbHccOrdenes>().ToTable("tbHccOrdenes");
        // modelBuilder.Entity<tbHccEstatusOrden>().ToTable("tbHccEstatusOrden");
        // modelBuilder.Entity<tbHccOrdenDetalle>().ToTable("tbHccOrdenDetalle");
        // modelBuilder.Entity<tbHccProducto>().ToTable("tbHccProducto");
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }    
}
