using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaldoFacil.API.Migrations
{
    public partial class etapaevento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoBloqueio_StatusPedido_StatusPedidoId",
                table: "SolicitacaoBloqueio");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoCartao_StatusPedido_StatusPedidoId",
                table: "SolicitacaoCartao");

            migrationBuilder.DropIndex(
                name: "IX_SolicitacaoCartao_StatusPedidoId",
                table: "SolicitacaoCartao");

            migrationBuilder.DropIndex(
                name: "IX_SolicitacaoBloqueio_StatusPedidoId",
                table: "SolicitacaoBloqueio");

            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "SolicitacaoRecarga");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "SolicitacaoRecarga");

            migrationBuilder.DropColumn(
                name: "StatusPedidoId",
                table: "SolicitacaoCartao");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "SolicitacaoBloqueio");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "SolicitacaoBloqueio");

            migrationBuilder.DropColumn(
                name: "StatusPedidoId",
                table: "SolicitacaoBloqueio");

            migrationBuilder.CreateTable(
                name: "EtapaEvento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatusPedidoId = table.Column<int>(nullable: false),
                    DataMudancaStatus = table.Column<DateTime>(nullable: false),
                    SolicitacaoBloqueioId = table.Column<int>(nullable: true),
                    SolicitacaoCartaoId = table.Column<int>(nullable: true),
                    SolicitacaoRecargaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtapaEvento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EtapaEvento_SolicitacaoBloqueio_SolicitacaoBloqueioId",
                        column: x => x.SolicitacaoBloqueioId,
                        principalTable: "SolicitacaoBloqueio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EtapaEvento_SolicitacaoCartao_SolicitacaoCartaoId",
                        column: x => x.SolicitacaoCartaoId,
                        principalTable: "SolicitacaoCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EtapaEvento_SolicitacaoRecarga_SolicitacaoRecargaId",
                        column: x => x.SolicitacaoRecargaId,
                        principalTable: "SolicitacaoRecarga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EtapaEvento_StatusPedido_StatusPedidoId",
                        column: x => x.StatusPedidoId,
                        principalTable: "StatusPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EtapaEvento_SolicitacaoBloqueioId",
                table: "EtapaEvento",
                column: "SolicitacaoBloqueioId");

            migrationBuilder.CreateIndex(
                name: "IX_EtapaEvento_SolicitacaoCartaoId",
                table: "EtapaEvento",
                column: "SolicitacaoCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_EtapaEvento_SolicitacaoRecargaId",
                table: "EtapaEvento",
                column: "SolicitacaoRecargaId");

            migrationBuilder.CreateIndex(
                name: "IX_EtapaEvento_StatusPedidoId",
                table: "EtapaEvento",
                column: "StatusPedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EtapaEvento");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFinal",
                table: "SolicitacaoRecarga",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "SolicitacaoRecarga",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StatusPedidoId",
                table: "SolicitacaoCartao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "SolicitacaoBloqueio",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "SolicitacaoBloqueio",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StatusPedidoId",
                table: "SolicitacaoBloqueio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoCartao_StatusPedidoId",
                table: "SolicitacaoCartao",
                column: "StatusPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoBloqueio_StatusPedidoId",
                table: "SolicitacaoBloqueio",
                column: "StatusPedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoBloqueio_StatusPedido_StatusPedidoId",
                table: "SolicitacaoBloqueio",
                column: "StatusPedidoId",
                principalTable: "StatusPedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoCartao_StatusPedido_StatusPedidoId",
                table: "SolicitacaoCartao",
                column: "StatusPedidoId",
                principalTable: "StatusPedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
