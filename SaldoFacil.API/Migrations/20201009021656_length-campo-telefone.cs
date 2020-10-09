using Microsoft.EntityFrameworkCore.Migrations;

namespace SaldoFacil.API.Migrations
{
    public partial class lengthcampotelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuario",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(13) CHARACTER SET utf8mb4",
                oldMaxLength: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuario",
                type: "varchar(13) CHARACTER SET utf8mb4",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);
        }
    }
}
