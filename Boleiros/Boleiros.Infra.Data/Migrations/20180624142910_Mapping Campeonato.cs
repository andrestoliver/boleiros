using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class MappingCampeonato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_BOLAO",
                newName: "IN_ATIVO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "TB_BOLAO",
                newName: "Ativo");
        }
    }
}
