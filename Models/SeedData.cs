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
            // Look for any usuarios.
            if (!context.Usuario.Any()){
                context.Usuario.AddRange(
                    new Usuario{
                        Nombres = "Juan",
                        Apellidos = "Perez",
                        CorreoElectronico = "juan@example.com",
                        Password = "password123"
                    },
                    new Usuario{
                        Nombres = "Maria",
                        Apellidos = "Gonzalez",
                        CorreoElectronico = "maria@example.com",
                        Password = "password456"
                    },
                    new Usuario{
                        Nombres = "Carlos",
                        Apellidos = "Lopez",
                        CorreoElectronico = "carlos@example.com",
                        Password = "password789"
                    },
                    new Usuario{
                        Nombres = "Laura",
                        Apellidos = "Sanchez",
                        CorreoElectronico = "laura@example.com",
                        Password = "passwordabc"
                    },
                    new Usuario{
                        Nombres = "Pedro",
                        Apellidos = "Martinez",
                        CorreoElectronico = "pedro@example.com",
                        Password = "passwordxyz"
                    },
                    new Usuario{
                        Nombres = "Ana",
                        Apellidos = "Ramirez",
                        CorreoElectronico = "ana@example.com",
                        Password = "password123456"
                    },
                    new Usuario
                    {
                        Nombres = "Luisa",
                        Apellidos = "Villanueva",
                        CorreoElectronico = "lvillanueva@unsa.edu.pe",
                        Password = "password"
                    }
                );
            }

            // Look for any negocios.
            if (!context.Negocio.Any()){
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
            
            // Look for any clientes.
            if (!context.Cliente.Any()){
                context.Cliente.AddRange(
                    new Cliente{
                        Telefono = 123456789,
                        Distrito = "Miraflores",
                        Direccion = "Av. Larco 123"
                    },
                    new Cliente{
                        Telefono = 987654321,
                        Distrito = "San Isidro",
                        Direccion = "Av. Arequipa 456"
                    },
                    new Cliente{
                        Telefono = 456789123,
                        Distrito = "Surco",
                        Direccion = "Av. Caminos del Inca 789"
                    },
                    new Cliente{
                        Telefono = 789123456,
                        Distrito = "La Molina",
                        Direccion = "Av. Javier Prado 321"
                    }
                );
            }
            
            // Look for any servicios.
            if (!context.Servicio.Any()){
                context.Servicio.AddRange(
                    new Servicio{
                        Distrito = "Miraflores",
                        Direccion = "Av. Larco 432",
                        Nombre = "Servicio 01",
                        Descripcion = "Descripción del servicio 01",
                        HorarioInicio = TimeSpan.Parse("09:00"),
                        HorarioFin = TimeSpan.Parse("18:00"),
                        Categoria = "Servicio de Limpieza",
                        NegocioID = 1
                    },
                    new Servicio{
                        Distrito = "San Isidro",
                        Direccion = "Av. Arequipa 245",
                        Nombre = "Servicio 02",
                        Descripcion = "Descripción del servicio 02",
                        HorarioInicio = TimeSpan.Parse("10:00"),
                        HorarioFin = TimeSpan.Parse("19:00"),
                        Categoria = "Servicio de Limpieza",
                        NegocioID = 1
                    },
                    new Servicio
                    {
                        Distrito = "Surco",
                        Direccion = "Av. Caminos del Inca 489",
                        Nombre = "Servicio 03",
                        Descripcion = "Descripción del servicio 03",
                        HorarioInicio = TimeSpan.Parse("08:00"),
                        HorarioFin = TimeSpan.Parse("17:00"),
                        Categoria = "Servicio de Limpieza",
                        NegocioID = 1
                    },
                    new Servicio
                    {
                        Distrito = "La Molina",
                        Direccion = "Av. Javier Prado 453",
                        Nombre = "Servicio 04",
                        Descripcion = "Descripción del servicio 04",
                        HorarioInicio = TimeSpan.Parse("9:00"),
                        HorarioFin = TimeSpan.Parse("20:00"),
                        Categoria = "Servicio de Limpieza",
                        NegocioID = 2
                    },
                    new Servicio
                    {
                        Distrito = "San Borja",
                        Direccion = "Av. Primavera 789",
                        Nombre = "Servicio 05",
                        Descripcion = "Descripción del servicio 05",
                        HorarioInicio = TimeSpan.Parse("09:00"),
                        HorarioFin = TimeSpan.Parse("18:00"),
                        Categoria = "Servicio de Limpieza",
                        NegocioID = 2
                    },
                    new Servicio
                    {
                        Distrito = "Lince",
                        Direccion = "Av. Arequipa 987",
                        Nombre = "Servicio 06",
                        Descripcion = "Descripción del servicio 06",
                        HorarioInicio = TimeSpan.Parse("10:00"),
                        HorarioFin = TimeSpan.Parse("19:00"),
                        Categoria = "Servicio de Limpieza",
                        NegocioID = 2
                    }
                );
            }

            // Look for any pedidos.
            if (!context.Pedido.Any()){
                context.Pedido.AddRange(
                    new Pedido{
                        PrecioFinal = 100.50m,
                        HorarioFinal = DateTime.Now.AddDays(10),
                        Estado = "Reservado",
                        ClienteID = 3,
                        ServicioID = 1
                    },
                    new Pedido{
                        PrecioFinal = 75.20m,
                        HorarioFinal = DateTime.Now,
                        Estado = "En Domicilio",
                        ClienteID = 4,
                        ServicioID = 2
                    },
                    new Pedido{
                        PrecioFinal = 200.00m,
                        HorarioFinal = DateTime.Now.AddDays(-15),
                        Estado = "Terminado",
                        ClienteID = 5,
                        ServicioID = 4
                    },
                    new Pedido{
                        PrecioFinal = 150.75m,
                        HorarioFinal = DateTime.Now,
                        Estado = "Cancelado",
                        ClienteID = 6,
                        ServicioID = 5
                    }
                );  
            }

            // Look for any chats.
            if (!context.Chat.Any()){
                context.Chat.AddRange(
                    new Chat{
                        NegocioID = 1,
                        CienteID = 3,
                        PedidoID = 1
                    },
                    new Chat{
                        NegocioID = 1,
                        CienteID = 4,
                        PedidoID = 2
                    },
                    new Chat{
                        NegocioID = 2,
                        CienteID = 5,
                        PedidoID = 3
                    },
                    new Chat{
                        NegocioID = 2,
                        CienteID = 6,
                        PedidoID = 4
                    }
                );  
            }
            
            // Look for any mensajes.
            if (!context.Mensajes.Any()){
                context.Mensajes.AddRange(
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now,
                        Mensaje = "Hola, ¿que tal?",
                        ChatID = 1
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(2),
                        Mensaje = "Bien, gracias",
                        ChatID = 1
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(5),
                        Mensaje = "Estoy interesado en tus servicios.",
                        ChatID = 1
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(7),
                        Mensaje = "Perfecto, ¿cuál es tu disponibilidad?",
                        ChatID = 1
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(10),
                        Mensaje = "¿Puedes hacerlo el proximo martes a las 10 AM?",
                        ChatID = 1
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(12),
                        Mensaje = "Si. Nos vemos entonces.",
                        ChatID = 1
                    },

                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(15),
                        Mensaje = "Hola, estoy interesado en tu servicio.",
                        ChatID = 2
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(17),
                        Mensaje = "Genial, ¿en qué puedo ayudarte?",
                        ChatID = 2
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(10),
                        Mensaje = "¿Puedes hacerlo hoy a las 2 PM?",
                        ChatID = 2
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(12),
                        Mensaje = "Si. Nos vemos entonces.",
                        ChatID = 2
                    },

                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddDays(-16),
                        Mensaje = "Necesito más información sobre los precios.",
                        ChatID = 3
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddDays(-16),
                        Mensaje = "Claro, te puedo enviar una cotización detallada.",
                        ChatID = 3
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddDays(-15),
                        Mensaje = "¿Puedes hacerlo hoy las 2 PM?",
                        ChatID = 3
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddDays(-15),
                        Mensaje = "Si. Nos vemos entonces.",
                        ChatID = 3
                    },

                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(15),
                        Mensaje = "Hola, estoy interesado en tu servicio.",
                        ChatID = 4
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(17),
                        Mensaje = "Genial, ¿en qué puedo ayudarte?",
                        ChatID = 4
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(10),
                        Mensaje = "¿Puedes hacerlo hoy a las 3 PM?",
                        ChatID = 4
                    },
                    new Mensajes{
                        HoraFechaEnvio = DateTime.Now.AddMinutes(12),
                        Mensaje = "No, disculpa.",
                        ChatID = 4
                    }
                );
            }
            
            // Look for any favoritos.
            if (!context.Favoritos.Any()){
                context.Favoritos.AddRange(
                    new Favoritos {
                        ClienteID = 1,
                        ServiciosID = 1
                    },
                    new Favoritos {
                        ClienteID = 1,
                        ServiciosID = 2
                    },
                    new Favoritos {
                        ClienteID = 1,
                        ServiciosID = 4
                    },
                    new Favoritos {
                        ClienteID = 1,
                        ServiciosID = 5
                    },
                    new Favoritos {
                        ClienteID = 2,
                        ServiciosID = 1
                    },
                    new Favoritos {
                        ClienteID = 2,
                        ServiciosID = 3
                    }
                );
            }
            
            context.SaveChanges();
        }
    }
}
