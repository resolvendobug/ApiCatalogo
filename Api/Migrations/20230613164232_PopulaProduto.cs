using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Coca-Cola', 'Refrigerante de Cola', 5.45, 'Coca-Cola.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Bebidas'))");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Guaraná', 'Refrigerante de Guaraná', 5.45, 'Guaraná.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Bebidas'))");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Hamburguer', 'Hamburguer de Carne', 15.45, 'Hamburguer.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Lanches'))");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Cheese Salada', 'Hamburguer de Carne com Queijo', 18.45, 'CheeseSalada.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Lanches'))");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Cheese Burger Bacon', 'Hamburguer de Carne com Queijo e Bacon', 20.45, 'CheeseBurgerBacon.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Lanches'))");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Pudim', 'Pudim de Leite Condensado', 10.45, 'Pudim.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Sobremesa'))");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) "+
                    "VALUES ('Bolo de Chocolate', 'Bolo de Chocolate com Cobertura', 12.45, 'BoloChocolate.jpg', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Sobremesa'))");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PRODUTOS WHERE NOME IN ('Coca-Cola', 'Guaraná', 'Hamburguer', 'Cheese Salada', 'Cheese Burger Bacon', 'Pudim', 'Bolo de Chocolate')");
        }
    }
}
