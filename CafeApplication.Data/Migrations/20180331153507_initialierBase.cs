using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeApplication.Data.Migrations
{
    public partial class initialierBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consommateur",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    DerniereSelection = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consommateur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consommation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    ConsommateurID = table.Column<long>(nullable: false),
                    TypeBoisson = table.Column<int>(nullable: false),
                    NombreCuilliere = table.Column<int>(nullable: false),
                    PropreMug = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consommation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consommation_Consommateur_ConsommateurID",
                        column: x => x.ConsommateurID,
                        principalTable: "Consommateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Consommateur",
                columns: new[] { "Id", "AddedDate", "DerniereSelection", "IPAddress", "ModifiedDate", "Nom", "Prenom" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cousineau", "Carl" });

            migrationBuilder.InsertData(
                table: "Consommateur",
                columns: new[] { "Id", "AddedDate", "DerniereSelection", "IPAddress", "ModifiedDate", "Nom", "Prenom" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BelleVille", " Suzanne" });

            migrationBuilder.CreateIndex(
                name: "IX_Consommation_ConsommateurID",
                table: "Consommation",
                column: "ConsommateurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consommation");

            migrationBuilder.DropTable(
                name: "Consommateur");
        }
    }
}
