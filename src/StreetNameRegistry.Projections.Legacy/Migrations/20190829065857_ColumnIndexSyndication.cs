using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Legacy.Migrations
{
    public partial class ColumnIndexSyndication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "CI_StreetNameSyndication_Position",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameSyndication",
                column: "Position")
                .Annotation("SqlServer:ColumnStoreIndex", "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "CI_StreetNameSyndication_Position",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameSyndication");
        }
    }
}
