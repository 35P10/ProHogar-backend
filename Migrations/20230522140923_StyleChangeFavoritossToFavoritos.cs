using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProHogarApi.Migrations
{
    /// <inheritdoc />
    public partial class StyleChangeFavoritossToFavoritos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favoritoss",
                table: "Favoritoss");

            migrationBuilder.RenameTable(
                name: "Favoritoss",
                newName: "Favoritos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favoritos",
                table: "Favoritos",
                column: "FavoritosID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favoritos",
                table: "Favoritos");

            migrationBuilder.RenameTable(
                name: "Favoritos",
                newName: "Favoritoss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favoritoss",
                table: "Favoritoss",
                column: "FavoritosID");
        }
    }
}
