using Microsoft.EntityFrameworkCore.Migrations;

namespace SaldoFacil.API.Migrations
{
    public partial class descricaomotivobloqueio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeStatus",
                table: "StatusPedido");

            migrationBuilder.DropColumn(
                name: "NomeMotivo",
                table: "MotivoBloqueio");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoStatus",
                table: "StatusPedido",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoMotivo",
                table: "MotivoBloqueio",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoBloqueio_MotivoBloqueioId",
                table: "SolicitacaoBloqueio",
                column: "MotivoBloqueioId");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitacaoBloqueio_MotivoBloqueio_MotivoBloqueioId",
                table: "SolicitacaoBloqueio",
                column: "MotivoBloqueioId",
                principalTable: "MotivoBloqueio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitacaoBloqueio_MotivoBloqueio_MotivoBloqueioId",
                table: "SolicitacaoBloqueio");

            migrationBuilder.DropIndex(
                name: "IX_SolicitacaoBloqueio_MotivoBloqueioId",
                table: "SolicitacaoBloqueio");

            migrationBuilder.DropColumn(
                name: "DescricaoStatus",
                table: "StatusPedido");

            migrationBuilder.DropColumn(
                name: "DescricaoMotivo",
                table: "MotivoBloqueio");

            migrationBuilder.AddColumn<string>(
                name: "NomeStatus",
                table: "StatusPedido",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeMotivo",
                table: "MotivoBloqueio",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
