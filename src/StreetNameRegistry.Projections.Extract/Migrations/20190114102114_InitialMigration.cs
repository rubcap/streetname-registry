using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Extract.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "StreetNameRegistryExtract");

            migrationBuilder.CreateTable(
                name: "ProjectionStates",
                schema: "StreetNameRegistryExtract",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Position = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectionStates", x => x.Name)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "StreetName",
                schema: "StreetNameRegistryExtract",
                columns: table => new
                {
                    StreetNameId = table.Column<Guid>(nullable: false),
                    StreetNameOsloId = table.Column<int>(nullable: false),
                    Complete = table.Column<bool>(nullable: false),
                    ChosenLanguage = table.Column<int>(nullable: true),
                    DbaseRecord = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetName", x => x.StreetNameId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StreetName_StreetNameOsloId",
                schema: "StreetNameRegistryExtract",
                table: "StreetName",
                column: "StreetNameOsloId")
                .Annotation("SqlServer:Clustered", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectionStates",
                schema: "StreetNameRegistryExtract");

            migrationBuilder.DropTable(
                name: "StreetName",
                schema: "StreetNameRegistryExtract");
        }
    }
}
