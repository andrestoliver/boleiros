using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class MappingRodada2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Rodadas_RodadaId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rodadas_TB_CAMPEONATO_CampeonatoId",
                table: "Rodadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rodadas",
                table: "Rodadas");

            migrationBuilder.RenameTable(
                name: "Rodadas",
                newName: "TB_RODADA");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "TB_RODADA",
                newName: "NU_RODADA");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_RODADA",
                newName: "DE_RODADA");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_RODADA",
                newName: "IN_ATIVO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_RODADA",
                newName: "ID_RODADA");

            migrationBuilder.RenameColumn(
                name: "CampeonatoId",
                table: "TB_RODADA",
                newName: "ID_CAMPEONATO");

            migrationBuilder.RenameIndex(
                name: "IX_Rodadas_CampeonatoId",
                table: "TB_RODADA",
                newName: "IX_TB_RODADA_ID_CAMPEONATO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_RODADA",
                table: "TB_RODADA",
                column: "ID_RODADA");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_TB_RODADA_RodadaId",
                table: "Jogos",
                column: "RodadaId",
                principalTable: "TB_RODADA",
                principalColumn: "ID_RODADA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_RODADA_TB_CAMPEONATO_ID_CAMPEONATO",
                table: "TB_RODADA",
                column: "ID_CAMPEONATO",
                principalTable: "TB_CAMPEONATO",
                principalColumn: "ID_CAMPENATO",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_TB_RODADA_RodadaId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_RODADA_TB_CAMPEONATO_ID_CAMPEONATO",
                table: "TB_RODADA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_RODADA",
                table: "TB_RODADA");

            migrationBuilder.RenameTable(
                name: "TB_RODADA",
                newName: "Rodadas");

            migrationBuilder.RenameColumn(
                name: "NU_RODADA",
                table: "Rodadas",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "DE_RODADA",
                table: "Rodadas",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "Rodadas",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "ID_RODADA",
                table: "Rodadas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID_CAMPEONATO",
                table: "Rodadas",
                newName: "CampeonatoId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_RODADA_ID_CAMPEONATO",
                table: "Rodadas",
                newName: "IX_Rodadas_CampeonatoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rodadas",
                table: "Rodadas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Rodadas_RodadaId",
                table: "Jogos",
                column: "RodadaId",
                principalTable: "Rodadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rodadas_TB_CAMPEONATO_CampeonatoId",
                table: "Rodadas",
                column: "CampeonatoId",
                principalTable: "TB_CAMPEONATO",
                principalColumn: "ID_CAMPENATO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
