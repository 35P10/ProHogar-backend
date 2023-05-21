using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProHogarApi.Migrations
{
    /// <inheritdoc />
    public partial class AddComentariosFavPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServicioID",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ServicioID",
                table: "Pedido");
        }
    }
}
