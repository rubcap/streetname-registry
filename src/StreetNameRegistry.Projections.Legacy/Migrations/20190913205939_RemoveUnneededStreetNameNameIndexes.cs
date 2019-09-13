using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Legacy.Migrations
{
    public partial class RemoveUnneededStreetNameNameIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_Complete",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_IsFlemishRegion",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_Complete",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "Complete");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_IsFlemishRegion",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "IsFlemishRegion");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "Removed");
        }
    }
}
