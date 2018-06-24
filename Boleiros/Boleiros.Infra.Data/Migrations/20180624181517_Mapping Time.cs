using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class MappingTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_Times_ID_MANDANTE",
                table: "TB_JOGO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_Times_ID_VISITANTE",
                table: "TB_JOGO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Times",
                table: "Times");

            migrationBuilder.RenameTable(
                name: "Times",
                newName: "TB_TIME");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_PALPITE",
                newName: "IN_ATIVO");

            migrationBuilder.RenameColumn(
                name: "Sigla",
                table: "TB_TIME",
                newName: "NM_SIGLA");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TB_TIME",
                newName: "NM_TIME");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_TIME",
                newName: "DE_TIME");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_TIME",
                newName: "IN_ATIVO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_TIME",
                newName: "ID_TIME");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_TIME",
                table: "TB_TIME",
                column: "ID_TIME");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_TB_TIME_ID_MANDANTE",
                table: "TB_JOGO",
                column: "ID_MANDANTE",
                principalTable: "TB_TIME",
                principalColumn: "ID_TIME",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_TB_TIME_ID_VISITANTE",
                table: "TB_JOGO",
                column: "ID_VISITANTE",
                principalTable: "TB_TIME",
                principalColumn: "ID_TIME",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_TB_TIME_ID_MANDANTE",
                table: "TB_JOGO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_TB_TIME_ID_VISITANTE",
                table: "TB_JOGO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_TIME",
                table: "TB_TIME");

            migrationBuilder.RenameTable(
                name: "TB_TIME",
                newName: "Times");

            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "TB_PALPITE",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "NM_SIGLA",
                table: "Times",
                newName: "Sigla");

            migrationBuilder.RenameColumn(
                name: "NM_TIME",
                table: "Times",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "DE_TIME",
                table: "Times",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "Times",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "ID_TIME",
                table: "Times",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Times",
                table: "Times",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_Times_ID_MANDANTE",
                table: "TB_JOGO",
                column: "ID_MANDANTE",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_Times_ID_VISITANTE",
                table: "TB_JOGO",
                column: "ID_VISITANTE",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
