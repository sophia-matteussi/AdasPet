using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class pedidoAtualizado2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Pedido",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Troco",
                table: "Pedido",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Troco",
                table: "Pedido");
        }
    }
}
