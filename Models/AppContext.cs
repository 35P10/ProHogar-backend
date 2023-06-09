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
    public DbSet<ProHogarApi.Models.Administrador> Administrador { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Cliente> Cliente { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Pedido> Pedido { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Chat> Chat { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Mensajes> Mensajes { get; set; } = default!;
    public DbSet<ProHogarApi.Models.Favoritos> Favoritos { get; set; } = default!;
    // public DbSet<ProHogarApi.Models.ComentariosServicios> ComentariosServicios { get; set; } = default!;

}