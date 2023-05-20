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
            if(!context.Negocio.Any()){
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
            }

            if(!context.Servicio.Any()){
                context.Servicio.AddRange(
                    new Servicio{
                        //Id = 1, database automatically assigns it.
                        Distrito = "Arequipa",
                        Direccion = "Cabaña Maria",
                        Nombre = "Servicio de limpieza del hogar profesional",
                        Descripcion = "Descripcion!",
                        HorarioInicio = new TimeSpan(2, 14, 18),
                        HorarioFin = new TimeSpan(2, 14, 18),
                        Categoria = "Limpieza del hogar",
                        NegocioID = 1
                    }
                );
            }

            context.SaveChanges();
        }
    }
}
