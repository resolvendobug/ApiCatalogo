using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImageUrl) VALUES ('Bebidas', 'Bebidas.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImageUrl) VALUES ('Lanches', 'Lanches.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImageUrl) VALUES ('Sobremesa', 'Sobremesa.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CATEGORIAS WHERE NOME IN ('Bebidas', 'Lanches', 'Sobremesa')");
        }
    }
}
