using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Produtos\"(\"Nome\", \"Descricao\", \"Preco\", \"ImagemUrl\", \"Estoque\", \"DataCadastro\", \"CategoriaId\") " +
                "VALUES('Coca-Cola', 'Refrigerante de cola 350ml', 5.50, 'coca.jpg', 25, now(), 1)");
            migrationBuilder.Sql("INSERT INTO \"Produtos\"(\"Nome\", \"Descricao\", \"Preco\", \"ImagemUrl\", \"Estoque\", \"DataCadastro\", \"CategoriaId\") " +
                "VALUES('Lanche de Atum', 'Lanche de atum com maionese', 8.50, 'lanche.jpg', 15, now(), 2)");
            migrationBuilder.Sql("INSERT INTO \"Produtos\"(\"Nome\", \"Descricao\", \"Preco\", \"ImagemUrl\", \"Estoque\", \"DataCadastro\", \"CategoriaId\") " +
                "VALUES('Pudim 100g', 'Pudim de leite condensado', 6.75, 'pudim.jpg', 10, now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Categorias\"");
        }
    }
}
