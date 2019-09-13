using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Legacy.Migrations
{
    public partial class AddStreetNameListIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StreetNameList_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameList_Complete_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList",
                columns: new[] { "Complete", "Removed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StreetNameList_Complete_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameList_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList",
                column: "Removed");
        }
    }
}
