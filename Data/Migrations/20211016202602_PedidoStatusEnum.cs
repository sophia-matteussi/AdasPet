using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class PedidoStatusEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PedidoProduto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "StatusDoPedido",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "PedidoProduto");

            migrationBuilder.AlterColumn<string>(
                name: "StatusDoPedido",
                table: "Pedido",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
