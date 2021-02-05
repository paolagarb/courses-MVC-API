using Microsoft.EntityFrameworkCore.Migrations;

namespace Cursos.Migrations
{
    public partial class Certificado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CertificadoGratuito",
                table: "Cursos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TemCertificado",
                table: "Cursos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificadoGratuito",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "TemCertificado",
                table: "Cursos");
        }
    }
}
