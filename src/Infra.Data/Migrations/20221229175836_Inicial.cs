using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinhaProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhaProducao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProdutoTipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoteiroProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    LinhaProducaoId = table.Column<int>(type: "int", nullable: false),
                    Sequencia = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoteiroProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoteiroProducao_LinhaProducao_LinhaProducaoId",
                        column: x => x.LinhaProducaoId,
                        principalTable: "LinhaProducao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdemProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    LinhaProducaoId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    QuantidadeAbertura = table.Column<double>(type: "float", nullable: false),
                    QuantidadeFinalizada = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemProducao_LinhaProducao_LinhaProducaoId",
                        column: x => x.LinhaProducaoId,
                        principalTable: "LinhaProducao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdemProducao_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecursosProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    RoteiroProducaoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    QuantidadePadrao = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursosProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecursosProducao_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecursosProducao_RoteiroProducao_RoteiroProducaoId",
                        column: x => x.RoteiroProducaoId,
                        principalTable: "RoteiroProducao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApontamentoProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    OrdemProducaoId = table.Column<int>(type: "int", nullable: false),
                    RoteiroProducaoOrigemId = table.Column<int>(type: "int", nullable: false),
                    RoteiroProducaoOrigemId1 = table.Column<int>(type: "int", nullable: false),
                    RoteiroProducaoDestinoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApontamentoProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApontamentoProducao_OrdemProducao_OrdemProducaoId",
                        column: x => x.OrdemProducaoId,
                        principalTable: "OrdemProducao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApontamentoProducao_RoteiroProducao_RoteiroProducaoOrigemId",
                        column: x => x.RoteiroProducaoOrigemId,
                        principalTable: "RoteiroProducao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApontamentoProducao_RoteiroProducao_RoteiroProducaoOrigemId1",
                        column: x => x.RoteiroProducaoOrigemId1,
                        principalTable: "RoteiroProducao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumoProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    OrdemProducaoId = table.Column<int>(type: "int", nullable: false),
                    ApontamentoProducaoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumoProducao_ApontamentoProducao_ApontamentoProducaoId",
                        column: x => x.ApontamentoProducaoId,
                        principalTable: "ApontamentoProducao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConsumoProducao_OrdemProducao_OrdemProducaoId",
                        column: x => x.OrdemProducaoId,
                        principalTable: "OrdemProducao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConsumoProducao_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApontamentoProducao_OrdemProducaoId",
                table: "ApontamentoProducao",
                column: "OrdemProducaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApontamentoProducao_RoteiroProducaoOrigemId",
                table: "ApontamentoProducao",
                column: "RoteiroProducaoOrigemId");

            migrationBuilder.CreateIndex(
                name: "IX_ApontamentoProducao_RoteiroProducaoOrigemId1",
                table: "ApontamentoProducao",
                column: "RoteiroProducaoOrigemId1");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoProducao_ApontamentoProducaoId",
                table: "ConsumoProducao",
                column: "ApontamentoProducaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoProducao_OrdemProducaoId",
                table: "ConsumoProducao",
                column: "OrdemProducaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoProducao_ProdutoId",
                table: "ConsumoProducao",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemProducao_LinhaProducaoId",
                table: "OrdemProducao",
                column: "LinhaProducaoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemProducao_ProdutoId",
                table: "OrdemProducao",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosProducao_ProdutoId",
                table: "RecursosProducao",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosProducao_RoteiroProducaoId",
                table: "RecursosProducao",
                column: "RoteiroProducaoId");

            migrationBuilder.CreateIndex(
                name: "IX_RoteiroProducao_LinhaProducaoId",
                table: "RoteiroProducao",
                column: "LinhaProducaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumoProducao");

            migrationBuilder.DropTable(
                name: "RecursosProducao");

            migrationBuilder.DropTable(
                name: "ApontamentoProducao");

            migrationBuilder.DropTable(
                name: "OrdemProducao");

            migrationBuilder.DropTable(
                name: "RoteiroProducao");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "LinhaProducao");
        }
    }
}
