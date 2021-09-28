using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class enderecoAtualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Endereco",
                type: "varchar(2)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Endereco");
        }
    }
}
