using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleiros.Infra.Data.Migrations
{
    public partial class MappingMuitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Palpites_TB_JOGO_JogoId",
                table: "Palpites");

            migrationBuilder.DropForeignKey(
                name: "FK_Palpites_Usuarios_UsuarioId",
                table: "Palpites");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfisUsuario_TB_BOLAO_BolaoId",
                table: "PerfisUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfisUsuario_TiposPerfil_TipoPerfilId",
                table: "PerfisUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfisUsuario_Usuarios_UsuarioId",
                table: "PerfisUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposPerfil",
                table: "TiposPerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfisUsuario",
                table: "PerfisUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfisUsuario_BolaoId",
                table: "PerfisUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfisUsuario_TipoPerfilId",
                table: "PerfisUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Palpites",
                table: "Palpites");

            migrationBuilder.DropIndex(
                name: "IX_Palpites_JogoId",
                table: "Palpites");

            migrationBuilder.DropIndex(
                name: "IX_Palpites_UsuarioId",
                table: "Palpites");

            migrationBuilder.DropColumn(
                name: "NU_GOL_MANDANTE",
                table: "TB_JOGO");

            migrationBuilder.DropColumn(
                name: "NU_GOL_VISITANTE",
                table: "TB_JOGO");

            migrationBuilder.DropColumn(
                name: "BolaoId",
                table: "PerfisUsuario");

            migrationBuilder.DropColumn(
                name: "TipoPerfilId",
                table: "PerfisUsuario");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Palpites");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Palpites");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Palpites");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "TB_USUARIO");

            migrationBuilder.RenameTable(
                name: "TiposPerfil",
                newName: "TB_TIPO_PERFIL");

            migrationBuilder.RenameTable(
                name: "PerfisUsuario",
                newName: "TB_PERFIL_USUARIO");

            migrationBuilder.RenameTable(
                name: "Palpites",
                newName: "TB_PALPITE");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_JOGO",
                newName: "IN_ATIVO");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TB_USUARIO",
                newName: "NM_USUARIO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_USUARIO",
                newName: "ID_USUARIO");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TB_TIPO_PERFIL",
                newName: "NM_TIPO_PERFIL");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_TIPO_PERFIL",
                newName: "DE_TIPO_PERFIL");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "TB_TIPO_PERFIL",
                newName: "IN_ATIVO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_TIPO_PERFIL",
                newName: "ID_TIPO_PERFIL");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "TB_PERFIL_USUARIO",
                newName: "ID_TIPO_PERFIL");

            migrationBuilder.RenameIndex(
                name: "IX_PerfisUsuario_UsuarioId",
                table: "TB_PERFIL_USUARIO",
                newName: "IX_TB_PERFIL_USUARIO_ID_TIPO_PERFIL");

            migrationBuilder.AddColumn<int>(
                name: "ID_BOLAO",
                table: "TB_PERFIL_USUARIO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_USUARIO",
                table: "TB_PERFIL_USUARIO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_JOGO",
                table: "TB_PALPITE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_USUARIO",
                table: "TB_PALPITE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NU_GOL_MANDANTE",
                table: "TB_PALPITE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NU_GOL_VISITANTE",
                table: "TB_PALPITE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_USUARIO",
                table: "TB_USUARIO",
                column: "ID_USUARIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_TIPO_PERFIL",
                table: "TB_TIPO_PERFIL",
                column: "ID_TIPO_PERFIL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PERFIL_USUARIO",
                table: "TB_PERFIL_USUARIO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PALPITE",
                table: "TB_PALPITE",
                columns: new[] { "ID_JOGO", "ID_USUARIO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERFIL_USUARIO_ID_BOLAO",
                table: "TB_PERFIL_USUARIO",
                column: "ID_BOLAO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERFIL_USUARIO_ID_USUARIO",
                table: "TB_PERFIL_USUARIO",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PALPITE_ID_USUARIO",
                table: "TB_PALPITE",
                column: "ID_USUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PALPITE_TB_JOGO_ID_JOGO",
                table: "TB_PALPITE",
                column: "ID_JOGO",
                principalTable: "TB_JOGO",
                principalColumn: "ID_JOGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PALPITE_TB_USUARIO_ID_USUARIO",
                table: "TB_PALPITE",
                column: "ID_USUARIO",
                principalTable: "TB_USUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERFIL_USUARIO_TB_TIPO_PERFIL_ID_TIPO_PERFIL",
                table: "TB_PERFIL_USUARIO",
                column: "ID_TIPO_PERFIL",
                principalTable: "TB_TIPO_PERFIL",
                principalColumn: "ID_TIPO_PERFIL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERFIL_USUARIO_TB_BOLAO_ID_BOLAO",
                table: "TB_PERFIL_USUARIO",
                column: "ID_BOLAO",
                principalTable: "TB_BOLAO",
                principalColumn: "ID_BOLAO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERFIL_USUARIO_TB_USUARIO_ID_USUARIO",
                table: "TB_PERFIL_USUARIO",
                column: "ID_USUARIO",
                principalTable: "TB_USUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PALPITE_TB_JOGO_ID_JOGO",
                table: "TB_PALPITE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PALPITE_TB_USUARIO_ID_USUARIO",
                table: "TB_PALPITE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERFIL_USUARIO_TB_TIPO_PERFIL_ID_TIPO_PERFIL",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERFIL_USUARIO_TB_BOLAO_ID_BOLAO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERFIL_USUARIO_TB_USUARIO_ID_USUARIO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_USUARIO",
                table: "TB_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_TIPO_PERFIL",
                table: "TB_TIPO_PERFIL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PERFIL_USUARIO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERFIL_USUARIO_ID_BOLAO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERFIL_USUARIO_ID_USUARIO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PALPITE",
                table: "TB_PALPITE");

            migrationBuilder.DropIndex(
                name: "IX_TB_PALPITE_ID_USUARIO",
                table: "TB_PALPITE");

            migrationBuilder.DropColumn(
                name: "ID_BOLAO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropColumn(
                name: "ID_USUARIO",
                table: "TB_PERFIL_USUARIO");

            migrationBuilder.DropColumn(
                name: "ID_JOGO",
                table: "TB_PALPITE");

            migrationBuilder.DropColumn(
                name: "ID_USUARIO",
                table: "TB_PALPITE");

            migrationBuilder.DropColumn(
                name: "NU_GOL_MANDANTE",
                table: "TB_PALPITE");

            migrationBuilder.DropColumn(
                name: "NU_GOL_VISITANTE",
                table: "TB_PALPITE");

            migrationBuilder.RenameTable(
                name: "TB_USUARIO",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "TB_TIPO_PERFIL",
                newName: "TiposPerfil");

            migrationBuilder.RenameTable(
                name: "TB_PERFIL_USUARIO",
                newName: "PerfisUsuario");

            migrationBuilder.RenameTable(
                name: "TB_PALPITE",
                newName: "Palpites");

            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "TB_JOGO",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "NM_USUARIO",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ID_USUARIO",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NM_TIPO_PERFIL",
                table: "TiposPerfil",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "DE_TIPO_PERFIL",
                table: "TiposPerfil",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "IN_ATIVO",
                table: "TiposPerfil",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "ID_TIPO_PERFIL",
                table: "TiposPerfil",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID_TIPO_PERFIL",
                table: "PerfisUsuario",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERFIL_USUARIO_ID_TIPO_PERFIL",
                table: "PerfisUsuario",
                newName: "IX_PerfisUsuario_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "NU_GOL_MANDANTE",
                table: "TB_JOGO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NU_GOL_VISITANTE",
                table: "TB_JOGO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BolaoId",
                table: "PerfisUsuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPerfilId",
                table: "PerfisUsuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Palpites",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Palpites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Palpites",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposPerfil",
                table: "TiposPerfil",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfisUsuario",
                table: "PerfisUsuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Palpites",
                table: "Palpites",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PerfisUsuario_BolaoId",
                table: "PerfisUsuario",
                column: "BolaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfisUsuario_TipoPerfilId",
                table: "PerfisUsuario",
                column: "TipoPerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_JogoId",
                table: "Palpites",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_UsuarioId",
                table: "Palpites",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Palpites_TB_JOGO_JogoId",
                table: "Palpites",
                column: "JogoId",
                principalTable: "TB_JOGO",
                principalColumn: "ID_JOGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Palpites_Usuarios_UsuarioId",
                table: "Palpites",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisUsuario_TB_BOLAO_BolaoId",
                table: "PerfisUsuario",
                column: "BolaoId",
                principalTable: "TB_BOLAO",
                principalColumn: "ID_BOLAO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisUsuario_TiposPerfil_TipoPerfilId",
                table: "PerfisUsuario",
                column: "TipoPerfilId",
                principalTable: "TiposPerfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisUsuario_Usuarios_UsuarioId",
                table: "PerfisUsuario",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
