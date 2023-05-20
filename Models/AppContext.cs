//coordina la funcionalidad de Entity Framework

using Microsoft.EntityFrameworkCore;
using ProHogarApi.Models;

namespace ProHogarApi.Models;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }
    public DbSet<ProHogarApi.Models.Negocio> Negocio { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Usuario> Usuario { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Servicio> Servicio { get; set; } = default!;

}