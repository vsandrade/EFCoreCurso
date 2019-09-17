using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Repo.Migrations
{
    public partial class TipoAlteradoNomeReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeReal",
                table: "IdentidadesSecretas",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NomeReal",
                table: "IdentidadesSecretas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
