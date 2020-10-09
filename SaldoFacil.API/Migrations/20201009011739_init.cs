using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaldoFacil.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotivoBloqueio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeMotivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoBloqueio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusPedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCartao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    NomeTipo = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCartao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(maxLength: 200, nullable: true),
                    CPF = table.Column<string>(maxLength: 14, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Telefone = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartaoTransporte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    TipoCartaoId = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(maxLength: 15, nullable: true),
                    Saldo = table.Column<float>(nullable: false),
                    Tarifa = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartaoTransporte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartaoTransporte_TipoCartao_TipoCartaoId",
                        column: x => x.TipoCartaoId,
                        principalTable: "TipoCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartaoTransporte_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Logradouro = table.Column<string>(maxLength: 518, nullable: true),
                    Numero = table.Column<string>(maxLength: 10, nullable: true),
                    Complemento = table.Column<string>(maxLength: 30, nullable: true),
                    CEP = table.Column<string>(maxLength: 9, nullable: true),
                    Cidade = table.Column<string>(maxLength: 30, nullable: true),
                    Estado = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    UsuarioCPF = table.Column<string>(nullable: true),
                    UsuarioEmail = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    SenhaAntiga = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginUsuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoBloqueio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartaoTransporteId = table.Column<int>(nullable: false),
                    MotivoBloqueioId = table.Column<int>(nullable: false),
                    StatusPedidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoBloqueio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoBloqueio_CartaoTransporte_CartaoTransporteId",
                        column: x => x.CartaoTransporteId,
                        principalTable: "CartaoTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoBloqueio_StatusPedido_StatusPedidoId",
                        column: x => x.StatusPedidoId,
                        principalTable: "StatusPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoCartao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    CartaoTransporteId = table.Column<int>(nullable: false),
                    MotivoBloqueioId = table.Column<int>(nullable: false),
                    StatusPedidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoCartao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoCartao_CartaoTransporte_CartaoTransporteId",
                        column: x => x.CartaoTransporteId,
                        principalTable: "CartaoTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoCartao_MotivoBloqueio_MotivoBloqueioId",
                        column: x => x.MotivoBloqueioId,
                        principalTable: "MotivoBloqueio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoCartao_StatusPedido_StatusPedidoId",
                        column: x => x.StatusPedidoId,
                        principalTable: "StatusPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoCartao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoRecarga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartaoId = table.Column<int>(nullable: false),
                    CartaoTransporteId = table.Column<int>(nullable: true),
                    StatusPedidoId = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoRecarga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoRecarga_CartaoTransporte_CartaoTransporteId",
                        column: x => x.CartaoTransporteId,
                        principalTable: "CartaoTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitacaoRecarga_StatusPedido_StatusPedidoId",
                        column: x => x.StatusPedidoId,
                        principalTable: "StatusPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartaoTransporte_TipoCartaoId",
                table: "CartaoTransporte",
                column: "TipoCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CartaoTransporte_UsuarioId",
                table: "CartaoTransporte",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UsuarioId",
                table: "Endereco",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginUsuario_UsuarioId",
                table: "LoginUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoBloqueio_CartaoTransporteId",
                table: "SolicitacaoBloqueio",
                column: "CartaoTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoBloqueio_StatusPedidoId",
                table: "SolicitacaoBloqueio",
                column: "StatusPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoCartao_CartaoTransporteId",
                table: "SolicitacaoCartao",
                column: "CartaoTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoCartao_MotivoBloqueioId",
                table: "SolicitacaoCartao",
                column: "MotivoBloqueioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoCartao_StatusPedidoId",
                table: "SolicitacaoCartao",
                column: "StatusPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoCartao_UsuarioId",
                table: "SolicitacaoCartao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoRecarga_CartaoTransporteId",
                table: "SolicitacaoRecarga",
                column: "CartaoTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoRecarga_StatusPedidoId",
                table: "SolicitacaoRecarga",
                column: "StatusPedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "LoginUsuario");

            migrationBuilder.DropTable(
                name: "SolicitacaoBloqueio");

            migrationBuilder.DropTable(
                name: "SolicitacaoCartao");

            migrationBuilder.DropTable(
                name: "SolicitacaoRecarga");

            migrationBuilder.DropTable(
                name: "MotivoBloqueio");

            migrationBuilder.DropTable(
                name: "CartaoTransporte");

            migrationBuilder.DropTable(
                name: "StatusPedido");

            migrationBuilder.DropTable(
                name: "TipoCartao");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
