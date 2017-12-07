using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace aplicacionEjemplo1.Migrations.DALMySQL
{
    public partial class incluyeMySQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pelicula",
                columns: table => new
                {
                    NombrePelicula = table.Column<string>(maxLength: 255, nullable: false),
                    ApellidoDirector = table.Column<string>(maxLength: 255, nullable: false),
                    NombreDirector = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pelicula", x => x.NombrePelicula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pelicula");
        }
    }
}
