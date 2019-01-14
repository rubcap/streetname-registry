using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetNameRegistry.Projections.Legacy.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "StreetNameRegistryLegacy");

            migrationBuilder.CreateTable(
                name: "ProjectionStates",
                schema: "StreetNameRegistryLegacy",
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
                name: "StreetNameDetails",
                schema: "StreetNameRegistryLegacy",
                columns: table => new
                {
                    StreetNameId = table.Column<Guid>(nullable: false),
                    OsloId = table.Column<int>(nullable: true),
                    NisCode = table.Column<string>(nullable: true),
                    NameDutch = table.Column<string>(nullable: true),
                    NameFrench = table.Column<string>(nullable: true),
                    NameGerman = table.Column<string>(nullable: true),
                    NameEnglish = table.Column<string>(nullable: true),
                    HomonymAdditionDutch = table.Column<string>(nullable: true),
                    HomonymAdditionFrench = table.Column<string>(nullable: true),
                    HomonymAdditionGerman = table.Column<string>(nullable: true),
                    HomonymAdditionEnglish = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Complete = table.Column<bool>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    VersionTimestamp = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetNameDetails", x => x.StreetNameId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "StreetNameList",
                schema: "StreetNameRegistryLegacy",
                columns: table => new
                {
                    StreetNameId = table.Column<Guid>(nullable: false),
                    OsloId = table.Column<int>(nullable: true),
                    NameDutch = table.Column<string>(nullable: true),
                    NameFrench = table.Column<string>(nullable: true),
                    NameGerman = table.Column<string>(nullable: true),
                    NameEnglish = table.Column<string>(nullable: true),
                    HomonymAdditionDutch = table.Column<string>(nullable: true),
                    HomonymAdditionFrench = table.Column<string>(nullable: true),
                    HomonymAdditionGerman = table.Column<string>(nullable: true),
                    HomonymAdditionEnglish = table.Column<string>(nullable: true),
                    Complete = table.Column<bool>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    NisCode = table.Column<string>(nullable: true),
                    VersionTimestamp = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetNameList", x => x.StreetNameId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "StreetNameName",
                schema: "StreetNameRegistryLegacy",
                columns: table => new
                {
                    StreetNameId = table.Column<Guid>(nullable: false),
                    OsloId = table.Column<int>(nullable: false),
                    NisCode = table.Column<string>(nullable: true),
                    NameDutch = table.Column<string>(nullable: true),
                    NameDutchSearch = table.Column<string>(nullable: true),
                    NameFrench = table.Column<string>(nullable: true),
                    NameFrenchSearch = table.Column<string>(nullable: true),
                    NameGerman = table.Column<string>(nullable: true),
                    NameGermanSearch = table.Column<string>(nullable: true),
                    NameEnglish = table.Column<string>(nullable: true),
                    NameEnglishSearch = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    IsFlemishRegion = table.Column<bool>(nullable: false),
                    Complete = table.Column<bool>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    VersionTimestamp = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetNameName", x => x.StreetNameId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "StreetNameSyndication",
                schema: "StreetNameRegistryLegacy",
                columns: table => new
                {
                    Position = table.Column<long>(nullable: false),
                    StreetNameId = table.Column<Guid>(nullable: false),
                    OsloId = table.Column<int>(nullable: true),
                    NisCode = table.Column<string>(nullable: true),
                    ChangeType = table.Column<string>(nullable: true),
                    NameDutch = table.Column<string>(nullable: true),
                    NameFrench = table.Column<string>(nullable: true),
                    NameGerman = table.Column<string>(nullable: true),
                    NameEnglish = table.Column<string>(nullable: true),
                    HomonymAdditionDutch = table.Column<string>(nullable: true),
                    HomonymAdditionFrench = table.Column<string>(nullable: true),
                    HomonymAdditionGerman = table.Column<string>(nullable: true),
                    HomonymAdditionEnglish = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false),
                    RecordCreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    LastChangedOn = table.Column<DateTimeOffset>(nullable: false),
                    Application = table.Column<int>(nullable: true),
                    Modification = table.Column<int>(nullable: true),
                    Operator = table.Column<string>(nullable: true),
                    Organisation = table.Column<int>(nullable: true),
                    Plan = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetNameSyndication", x => x.Position)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "StreetNameVersions",
                schema: "StreetNameRegistryLegacy",
                columns: table => new
                {
                    StreetNameId = table.Column<Guid>(nullable: false),
                    Position = table.Column<long>(nullable: false),
                    OsloId = table.Column<int>(nullable: true),
                    NisCode = table.Column<string>(nullable: true),
                    NameDutch = table.Column<string>(nullable: true),
                    NameFrench = table.Column<string>(nullable: true),
                    NameGerman = table.Column<string>(nullable: true),
                    NameEnglish = table.Column<string>(nullable: true),
                    HomonymAdditionDutch = table.Column<string>(nullable: true),
                    HomonymAdditionFrench = table.Column<string>(nullable: true),
                    HomonymAdditionGerman = table.Column<string>(nullable: true),
                    HomonymAdditionEnglish = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Complete = table.Column<bool>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    VersionTimestamp = table.Column<DateTimeOffset>(nullable: true),
                    Application = table.Column<int>(nullable: true),
                    Modification = table.Column<int>(nullable: true),
                    Operator = table.Column<string>(nullable: true),
                    Organisation = table.Column<int>(nullable: true),
                    Plan = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetNameVersions", x => new { x.StreetNameId, x.Position })
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameDetails_OsloId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameDetails",
                column: "OsloId")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameDetails_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameDetails",
                column: "Removed");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameList_NisCode",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList",
                column: "NisCode");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameList_OsloId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList",
                column: "OsloId")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameList_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameList",
                column: "Removed");

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
                name: "IX_StreetNameName_NameDutchSearch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameDutchSearch");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameEnglishSearch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameEnglishSearch");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameFrenchSearch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameFrenchSearch");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NameGermanSearch",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NameGermanSearch");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_NisCode",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "NisCode");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_OsloId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "OsloId");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "Removed");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_Status",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameName_VersionTimestamp",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameName",
                column: "VersionTimestamp");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameSyndication_StreetNameId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameSyndication",
                column: "StreetNameId");

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameVersions_OsloId",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameVersions",
                column: "OsloId")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_StreetNameVersions_Removed",
                schema: "StreetNameRegistryLegacy",
                table: "StreetNameVersions",
                column: "Removed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectionStates",
                schema: "StreetNameRegistryLegacy");

            migrationBuilder.DropTable(
                name: "StreetNameDetails",
                schema: "StreetNameRegistryLegacy");

            migrationBuilder.DropTable(
                name: "StreetNameList",
                schema: "StreetNameRegistryLegacy");

            migrationBuilder.DropTable(
                name: "StreetNameName",
                schema: "StreetNameRegistryLegacy");

            migrationBuilder.DropTable(
                name: "StreetNameSyndication",
                schema: "StreetNameRegistryLegacy");

            migrationBuilder.DropTable(
                name: "StreetNameVersions",
                schema: "StreetNameRegistryLegacy");
        }
    }
}
