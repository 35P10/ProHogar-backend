using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProHogarApi.Models;
using System;
using System.Linq;

namespace ProHogarApi.Models;

public static class SeedData {
    public static void Initialize(IServiceProvider serviceProvider) {
        using (var context = new AppDBContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<AppDBContext>>()))
        {
            // Look for any negocios.
            if (context.Negocio.Any())
            {
                return;   // DB has been seeded
            }

            context.Negocio.AddRange(
                new Negocio{
                    //Id = 1, database automatically assigns it.
                    NombreEmpresa = "Negocio 01",
                    Telefono = 123456789
                },
                new Negocio{
                    NombreEmpresa = "Negocio 02",
                    Telefono = 123456789
                }
            );
            
            context.SaveChanges();
        }
    }
}
