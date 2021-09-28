using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class EnderecoEProdutoAtualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Principal",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Principal",
                table: "Endereco");
        }
    }
}
