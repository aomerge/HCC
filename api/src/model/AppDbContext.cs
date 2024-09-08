using Microsoft.EntityFrameworkCore;
namespace api.src.model;

public class AppDbContext : DbContext
{    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {        
    //     optionsBuilder.UseSqlServer("Server=localhost,1433;Database=HCC;User Id=sa;Password=TuContraseñaSegura!;TrustServerCertificate=True;");
    // }
}
