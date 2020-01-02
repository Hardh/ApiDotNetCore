using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRestDotNetCore.Migrations
{
    public partial class CorrigeNomeCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "Cursos");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Cursos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Cursos");

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
