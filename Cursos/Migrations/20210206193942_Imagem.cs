using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cursos.Migrations
{
    public partial class Imagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Dados",
                table: "Cursos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "Dados",
                table: "Cursos");
        }
    }
}
