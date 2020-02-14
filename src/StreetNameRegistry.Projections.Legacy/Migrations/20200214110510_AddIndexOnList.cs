using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Legacy.Migrations
{
    public partial class AddIndexOnList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StreetNameList_Complete_Removed_PersistentLocalId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList",
                columns: new[] { "Complete", "Removed", "PersistentLocalId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StreetNameList_Complete_Removed_PersistentLocalId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList");
        }
    }
}
