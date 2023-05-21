using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProHogarApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    AdministradorID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.AdministradorID);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    ChatID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NegocioID = table.Column<int>(type: "INTEGER", nullable: false),
                    CienteID = table.Column<int>(type: "INTEGER", nullable: false),
                    PedidoID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ChatID);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Telefono = table.Column<int>(type: "INTEGER", nullable: false),
                    Distrito = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    MensajesID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoraFechaEnvio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: true),
                    ChatID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.MensajesID);
                });

            migrationBuilder.CreateTable(
                name: "Negocio",
                columns: table => new
                {
                    NegocioID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreEmpresa = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Telefono = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocio", x => x.NegocioID);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    PedidoID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrecioFinal = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: false),
                    HorarioFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    ClienteID = table.Column<int>(type: "INTEGER", nullable: false),
                    ServicioID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.PedidoID);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    ServicioID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Distrito = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 64, nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    HorarioInicio = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    HorarioFin = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    NegocioID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.ServicioID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CorreoElectronico = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "TEXT", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Negocio");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
