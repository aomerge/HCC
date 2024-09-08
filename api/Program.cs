using api.src.model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    var env = hostingContext.HostingEnvironment;
    config.SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)          
          .AddEnvironmentVariables();
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//Console.WriteLine($"Cadena de conexión cargada: {connectionString}");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapControllers();

app.MapGet("/checkdb", async (AppDbContext dbContext) =>
{
    try
    {
        // Intenta hacer una consulta simple para verificar la conexión
        var canConnect = await dbContext.Database.CanConnectAsync();
        if (canConnect)
        {
            return Results.Ok("La base de datos está conectada correctamente.");
        }
        else
        {
            return Results.Problem("No se pudo conectar a la base de datos.", statusCode: 500);
        }
    }
    catch (Exception ex)
    {
        return Results.Problem($"Error al conectar a la base de datos: {ex.Message}", statusCode: 500);
    }
});

app.MapGet("/", () => "Hello World!");


app.Run();
