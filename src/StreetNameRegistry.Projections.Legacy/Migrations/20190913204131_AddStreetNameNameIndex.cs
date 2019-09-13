using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Legacy.Migrations
{
    public partial class AddStreetNameNameIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NameGerman",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameFrench",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEnglish",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameDutch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameDutch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameDutch");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameEnglish",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameEnglish");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameFrench",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameFrench");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameGerman",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameGerman");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_Removed_IsFlemishRegion_Complete",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                columns: new[] { "Removed", "IsFlemishRegion", "Complete" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_NameDutch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_NameEnglish",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_NameFrench",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_NameGerman",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.DropIndex(
                name: "IX_StreetNameName_Removed_IsFlemishRegion_Complete",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName");

            migrationBuilder.AlterColumn<string>(
                name: "NameGerman",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameFrench",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEnglish",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameDutch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
