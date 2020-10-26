using Microsoft.EntityFrameworkCore.Migrations;

namespace SaldoFacil.API.Migrations
{
    public partial class remocaotarifasolicitacaobloqueio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tarifa",
                table: "SolicitacaoBloqueio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Tarifa",
                table: "SolicitacaoBloqueio",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
