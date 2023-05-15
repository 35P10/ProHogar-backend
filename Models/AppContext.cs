//coordina la funcionalidad de Entity Framework

using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    //public DbSet<TodoItem> TodoItems { get; set; } = null!;
}