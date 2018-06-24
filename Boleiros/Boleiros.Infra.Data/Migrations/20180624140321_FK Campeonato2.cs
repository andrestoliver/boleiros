using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class FKCampeonato2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boloes_Campeonatos_CampeonatoId",
                table: "Boloes");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfisUsuario_Boloes_BolaoId",
                table: "PerfisUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boloes",
                table: "Boloes");

            migrationBuilder.RenameTable(
                name: "Boloes",
                newName: "TB_BOLAO");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TB_BOLAO",
                newName: "NM_BOLAO");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_BOLAO",
                newName: "DE_BOLAO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_BOLAO",
                newName: "ID_BOLAO");

            migrationBuilder.RenameColumn(
                name: "CampeonatoId",
                table: "TB_BOLAO",
                newName: "ID_CAMPEONATO");

            migrationBuilder.RenameIndex(
                name: "IX_Boloes_CampeonatoId",
                table: "TB_BOLAO",
                newName: "IX_TB_BOLAO_ID_CAMPEONATO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_BOLAO",
                table: "TB_BOLAO",
                column: "ID_BOLAO");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisUsuario_TB_BOLAO_BolaoId",
                table: "PerfisUsuario",
                column: "BolaoId",
                principalTable: "TB_BOLAO",
                principalColumn: "ID_BOLAO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_BOLAO_Campeonatos_ID_CAMPEONATO",
                table: "TB_BOLAO",
                column: "ID_CAMPEONATO",
                principalTable: "Campeonatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfisUsuario_TB_BOLAO_BolaoId",
                table: "PerfisUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_BOLAO_Campeonatos_ID_CAMPEONATO",
                table: "TB_BOLAO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_BOLAO",
                table: "TB_BOLAO");

            migrationBuilder.RenameTable(
                name: "TB_BOLAO",
                newName: "Boloes");

            migrationBuilder.RenameColumn(
                name: "NM_BOLAO",
                table: "Boloes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "DE_BOLAO",
                table: "Boloes",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "ID_BOLAO",
                table: "Boloes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID_CAMPEONATO",
                table: "Boloes",
                newName: "CampeonatoId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_BOLAO_ID_CAMPEONATO",
                table: "Boloes",
                newName: "IX_Boloes_CampeonatoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boloes",
                table: "Boloes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Boloes_Campeonatos_CampeonatoId",
                table: "Boloes",
                column: "CampeonatoId",
                principalTable: "Campeonatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisUsuario_Boloes_BolaoId",
                table: "PerfisUsuario",
                column: "BolaoId",
                principalTable: "Boloes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
