using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdasPet.Data.Migrations
{
    public partial class MaisObjetos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "varchar(15)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Entregador",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    CNH = table.Column<string>(type: "varchar(20)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: false),
                    TipoVeiculo = table.Column<string>(type: "varchar(15)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", nullable: false),
                    Renavam = table.Column<string>(type: "varchar(30)", nullable: false),
                    ContaCadastroId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregador", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entregador_AspNetUsers_ContaCadastroId",
                        column: x => x.ContaCadastroId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RazaoSocial = table.Column<string>(type: "varchar(200)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: false),
                    ContaCadastroId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fornecedor_AspNetUsers_ContaCadastroId",
                        column: x => x.ContaCadastroId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    NumeroCasa = table.Column<string>(type: "varchar(5)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(30)", nullable: false),
                    ClienteID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FornecedorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Endereco_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endereco_Fornecedor_FornecedorID",
                        column: x => x.FornecedorID,
                        principalTable: "Fornecedor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusDoPedido = table.Column<string>(type: "varchar(20)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pagamento = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClienteID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntregadorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnderecoID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Endereco_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Entregador_EntregadorID",
                        column: x => x.EntregadorID,
                        principalTable: "Entregador",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(200)", nullable: false),
                    TipoDeAnimal = table.Column<string>(type: "varchar(20)", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(20)", nullable: false),
                    Preco = table.Column<decimal>(type: "money", nullable: false),
                    QtdEmEstoque = table.Column<int>(type: "int", nullable: false),
                    PrecisaDeCarro = table.Column<bool>(type: "bit", nullable: false),
                    ContaCadastroId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PedidoID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produto_AspNetUsers_ContaCadastroId",
                        column: x => x.ContaCadastroId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Pedido_PedidoID",
                        column: x => x.PedidoID,
                        principalTable: "Pedido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClienteID",
                table: "Endereco",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_FornecedorID",
                table: "Endereco",
                column: "FornecedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Entregador_ContaCadastroId",
                table: "Entregador",
                column: "ContaCadastroId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_ContaCadastroId",
                table: "Fornecedor",
                column: "ContaCadastroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteID",
                table: "Pedido",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EnderecoID",
                table: "Pedido",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EntregadorID",
                table: "Pedido",
                column: "EntregadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ContaCadastroId",
                table: "Produto",
                column: "ContaCadastroId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PedidoID",
                table: "Produto",
                column: "PedidoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Entregador");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "varchar(11)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");
        }
    }
}
