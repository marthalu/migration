using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaDeRopa.Migrations
{
    public partial class migracionBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Talla = table.Column<string>(nullable: false),
                    Precio = table.Column<float>(nullable: false),
                    PrendaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiendas_Prendas_PrendaId",
                        column: x => x.PrendaId,
                        principalTable: "Prendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tiendas_PrendaId",
                table: "Tiendas",
                column: "PrendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiendas");

            migrationBuilder.DropTable(
                name: "Prendas");
        }
    }
}
