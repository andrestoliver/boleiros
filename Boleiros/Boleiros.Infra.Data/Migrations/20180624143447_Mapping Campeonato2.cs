using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class MappingCampeonato2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rodadas_Campeonatos_CampeonatoId",
                table: "Rodadas");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_BOLAO_Campeonatos_ID_CAMPEONATO",
                table: "TB_BOLAO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campeonatos",
                table: "Campeonatos");

            migrationBuilder.RenameTable(
                name: "Campeonatos",
                newName: "TB_CAMPEONATO");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TB_CAMPEONATO",
                newName: "NM_CAMPENATO");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_CAMPEONATO",
                newName: "DE_CAMPENATO");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_CAMPEONATO",
                newName: "IN_ATIVO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_CAMPEONATO",
                newName: "ID_CAMPENATO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_CAMPEONATO",
                table: "TB_CAMPEONATO",
                column: "ID_CAMPENATO");

            migrationBuilder.AddForeignKey(
                name: "FK_Rodadas_TB_CAMPEONATO_CampeonatoId",
                table: "Rodadas",
                column: "CampeonatoId",
                principalTable: "TB_CAMPEONATO",
                principalColumn: "ID_CAMPENATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_BOLAO_TB_CAMPEONATO_ID_CAMPEONATO",
                table: "TB_BOLAO",
                column: "ID_CAMPEONATO",
                principalTable: "TB_CAMPEONATO",
                principalColumn: "ID_CAMPENATO",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rodadas_TB_CAMPEONATO_CampeonatoId",
                table: "Rodadas");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_BOLAO_TB_CAMPEONATO_ID_CAMPEONATO",
                table: "TB_BOLAO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_CAMPEONATO",
                table: "TB_CAMPEONATO");

            migrationBuilder.RenameTable(
                name: "TB_CAMPEONATO",
                newName: "Campeonatos");

            migrationBuilder.RenameColumn(
                name: "NM_CAMPENATO",
                table: "Campeonatos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "DE_CAMPENATO",
                table: "Campeonatos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "Campeonatos",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "ID_CAMPENATO",
                table: "Campeonatos",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campeonatos",
                table: "Campeonatos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rodadas_Campeonatos_CampeonatoId",
                table: "Rodadas",
                column: "CampeonatoId",
                principalTable: "Campeonatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_BOLAO_Campeonatos_ID_CAMPEONATO",
                table: "TB_BOLAO",
                column: "ID_CAMPEONATO",
                principalTable: "Campeonatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
