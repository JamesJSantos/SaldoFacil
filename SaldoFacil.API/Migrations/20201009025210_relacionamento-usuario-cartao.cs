using Microsoft.EntityFrameworkCore.Migrations;

namespace SaldoFacil.API.Migrations
{
    public partial class relacionamentousuariocartao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartaoTransporte_Usuario_UsuarioId",
                table: "CartaoTransporte");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "CartaoTransporte",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CartaoTransporte_Usuario_UsuarioId",
                table: "CartaoTransporte",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartaoTransporte_Usuario_UsuarioId",
                table: "CartaoTransporte");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "CartaoTransporte",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartaoTransporte_Usuario_UsuarioId",
                table: "CartaoTransporte",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
