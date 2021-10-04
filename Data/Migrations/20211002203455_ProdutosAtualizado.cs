using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class ProdutosAtualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Pedido_PedidoID",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_PedidoID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PedidoID",
                table: "Produto");

            migrationBuilder.CreateTable(
                name: "PedidoProduto",
                columns: table => new
                {
                    PedidosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProduto", x => new { x.PedidosID, x.ProdutosID });
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Pedido_PedidosID",
                        column: x => x.PedidosID,
                        principalTable: "Pedido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Produto_ProdutosID",
                        column: x => x.ProdutosID,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_ProdutosID",
                table: "PedidoProduto",
                column: "ProdutosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoProduto");

            migrationBuilder.AddColumn<Guid>(
                name: "PedidoID",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PedidoID",
                table: "Produto",
                column: "PedidoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Pedido_PedidoID",
                table: "Produto",
                column: "PedidoID",
                principalTable: "Pedido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
