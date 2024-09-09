using Microsoft.EntityFrameworkCore;
namespace api.src.model;

public class AppDbContext : DbContext
{    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tbHccOrdenes>().ToTable("tbHccOrdenes");
        modelBuilder.Entity<tbHccEstatusOrden>().ToTable("tbHccEstatusOrden");
        modelBuilder.Entity<tbHccOrdenDetalle>().ToTable("tbHccOrdenDetalle");
        modelBuilder.Entity<tbHccProducto>().ToTable("tbHccProducto");
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }    
}
