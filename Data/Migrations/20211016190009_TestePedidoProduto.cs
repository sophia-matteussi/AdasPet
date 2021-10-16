using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class TestePedidoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedido_PedidosID",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Produto_ProdutosID",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.RenameColumn(
                name: "ProdutosID",
                table: "PedidoProduto",
                newName: "ProdutoID");

            migrationBuilder.RenameColumn(
                name: "PedidosID",
                table: "PedidoProduto",
                newName: "PedidoID");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_ProdutosID",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_ProdutoID");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "PedidoProduto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_PedidoID",
                table: "PedidoProduto",
                column: "PedidoID");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedido_PedidoID",
                table: "PedidoProduto",
                column: "PedidoID",
                principalTable: "Pedido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Produto_ProdutoID",
                table: "PedidoProduto",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedido_PedidoID",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Produto_ProdutoID",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.DropIndex(
                name: "IX_PedidoProduto_PedidoID",
                table: "PedidoProduto");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "PedidoProduto");

            migrationBuilder.RenameColumn(
                name: "ProdutoID",
                table: "PedidoProduto",
                newName: "ProdutosID");

            migrationBuilder.RenameColumn(
                name: "PedidoID",
                table: "PedidoProduto",
                newName: "PedidosID");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_ProdutoID",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_ProdutosID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                columns: new[] { "PedidosID", "ProdutosID" });

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedido_PedidosID",
                table: "PedidoProduto",
                column: "PedidosID",
                principalTable: "Pedido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Produto_ProdutosID",
                table: "PedidoProduto",
                column: "ProdutosID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
