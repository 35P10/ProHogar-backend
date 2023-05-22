﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProHogarApi.Models;

#nullable disable

namespace ProHogarApi.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230522140923_StyleChangeFavoritossToFavoritos")]
    partial class StyleChangeFavoritossToFavoritos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProHogarApi.Models.Administrador", b =>
                {
                    b.Property<int>("AdministradorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministradorID"));

                    b.HasKey("AdministradorID");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("ProHogarApi.Models.Chat", b =>
                {
                    b.Property<int>("ChatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChatID"));

                    b.Property<int>("CienteID")
                        .HasColumnType("int");

                    b.Property<int>("NegocioID")
                        .HasColumnType("int");

                    b.Property<int>("PedidoID")
                        .HasColumnType("int");

                    b.HasKey("ChatID");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("ProHogarApi.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Distrito")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProHogarApi.Models.Favoritos", b =>
                {
                    b.Property<int>("FavoritosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoritosID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("ServiciosID")
                        .HasColumnType("int");

                    b.HasKey("FavoritosID");

                    b.ToTable("Favoritos");
                });

            modelBuilder.Entity("ProHogarApi.Models.Mensajes", b =>
                {
                    b.Property<int>("MensajesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MensajesID"));

                    b.Property<int>("ChatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraFechaEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensaje")
                        .HasColumnType("text");

                    b.HasKey("MensajesID");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("ProHogarApi.Models.Negocio", b =>
                {
                    b.Property<int>("NegocioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NegocioID"));

                    b.Property<string>("NombreEmpresa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("NegocioID");

                    b.ToTable("Negocio");
                });

            modelBuilder.Entity("ProHogarApi.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime>("HorarioFinal")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PrecioFinal")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ServicioID")
                        .HasColumnType("int");

                    b.HasKey("PedidoID");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ProHogarApi.Models.Servicio", b =>
                {
                    b.Property<int>("ServicioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicioID"));

                    b.Property<string>("Categoria")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Distrito")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<TimeSpan>("HorarioFin")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HorarioInicio")
                        .HasColumnType("time");

                    b.Property<int>("NegocioID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("ServicioID");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("ProHogarApi.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"));

                    b.Property<string>("Apellidos")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CorreoElectronico")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombres")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
