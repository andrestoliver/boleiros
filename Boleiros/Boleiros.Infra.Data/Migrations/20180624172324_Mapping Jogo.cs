using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class MappingJogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_TB_RODADA_RodadaId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Palpites_Jogos_JogoId",
                table: "Palpites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jogos",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "IdMandante",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "IdRodada",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "IdVisitante",
                table: "Jogos");

            migrationBuilder.RenameTable(
                name: "Jogos",
                newName: "TB_JOGO");

            migrationBuilder.RenameColumn(
                name: "NumeroGolVisitante",
                table: "TB_JOGO",
                newName: "NU_GOL_VISITANTE");

            migrationBuilder.RenameColumn(
                name: "NumeroGolMandante",
                table: "TB_JOGO",
                newName: "NU_GOL_MANDANTE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_JOGO",
                newName: "ID_JOGO");

            migrationBuilder.RenameColumn(
                name: "RodadaId",
                table: "TB_JOGO",
                newName: "ID_VISITANTE");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_RodadaId",
                table: "TB_JOGO",
                newName: "IX_TB_JOGO_ID_VISITANTE");

            migrationBuilder.AddColumn<int>(
                name: "ID_MANDANTE",
                table: "TB_JOGO",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_RODADA",
                table: "TB_JOGO",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_JOGO",
                table: "TB_JOGO",
                column: "ID_JOGO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_JOGO_ID_MANDANTE",
                table: "TB_JOGO",
                column: "ID_MANDANTE");

            migrationBuilder.CreateIndex(
                name: "IX_TB_JOGO_ID_RODADA",
                table: "TB_JOGO",
                column: "ID_RODADA");

            migrationBuilder.AddForeignKey(
                name: "FK_Palpites_TB_JOGO_JogoId",
                table: "Palpites",
                column: "JogoId",
                principalTable: "TB_JOGO",
                principalColumn: "ID_JOGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_Times_ID_MANDANTE",
                table: "TB_JOGO",
                column: "ID_MANDANTE",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_TB_RODADA_ID_RODADA",
                table: "TB_JOGO",
                column: "ID_RODADA",
                principalTable: "TB_RODADA",
                principalColumn: "ID_RODADA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_JOGO_Times_ID_VISITANTE",
                table: "TB_JOGO",
                column: "ID_VISITANTE",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Palpites_TB_JOGO_JogoId",
                table: "Palpites");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_Times_ID_MANDANTE",
                table: "TB_JOGO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_TB_RODADA_ID_RODADA",
                table: "TB_JOGO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_JOGO_Times_ID_VISITANTE",
                table: "TB_JOGO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_JOGO",
                table: "TB_JOGO");

            migrationBuilder.DropIndex(
                name: "IX_TB_JOGO_ID_MANDANTE",
                table: "TB_JOGO");

            migrationBuilder.DropIndex(
                name: "IX_TB_JOGO_ID_RODADA",
                table: "TB_JOGO");

            migrationBuilder.DropColumn(
                name: "ID_MANDANTE",
                table: "TB_JOGO");

            migrationBuilder.DropColumn(
                name: "ID_RODADA",
                table: "TB_JOGO");

            migrationBuilder.RenameTable(
                name: "TB_JOGO",
                newName: "Jogos");

            migrationBuilder.RenameColumn(
                name: "NU_GOL_VISITANTE",
                table: "Jogos",
                newName: "NumeroGolVisitante");

            migrationBuilder.RenameColumn(
                name: "NU_GOL_MANDANTE",
                table: "Jogos",
                newName: "NumeroGolMandante");

            migrationBuilder.RenameColumn(
                name: "ID_JOGO",
                table: "Jogos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID_VISITANTE",
                table: "Jogos",
                newName: "RodadaId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_JOGO_ID_VISITANTE",
                table: "Jogos",
                newName: "IX_Jogos_RodadaId");

            migrationBuilder.AddColumn<int>(
                name: "IdMandante",
                table: "Jogos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRodada",
                table: "Jogos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVisitante",
                table: "Jogos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jogos",
                table: "Jogos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_TB_RODADA_RodadaId",
                table: "Jogos",
                column: "RodadaId",
                principalTable: "TB_RODADA",
                principalColumn: "ID_RODADA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Palpites_Jogos_JogoId",
                table: "Palpites",
                column: "JogoId",
                principalTable: "Jogos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
