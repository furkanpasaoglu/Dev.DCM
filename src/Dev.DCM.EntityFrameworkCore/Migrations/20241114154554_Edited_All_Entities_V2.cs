using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_All_Entities_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAuthorizedPersons_AppInstitutions_InstitutionId",
                table: "AppAuthorizedPersons");

            migrationBuilder.DropTable(
                name: "AppInstitutions");

            migrationBuilder.DropTable(
                name: "AppSales");

            migrationBuilder.DropTable(
                name: "AppPhones");

            migrationBuilder.DropIndex(
                name: "IX_AppAuthorizedPersons_InstitutionId",
                table: "AppAuthorizedPersons");

            migrationBuilder.RenameColumn(
                name: "InstitutionId",
                table: "AppAuthorizedPersons",
                newName: "SubscriberId");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorizedPersonId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorizedPersonId1",
                table: "AppSubscribers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "AppSatellites",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AihId",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AihId1",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FixedLineId",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FixedLineId1",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GsmDetailId",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GsmDetailId1",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InternetServiceId",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InternetServiceId1",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AppLines",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SatelliteId",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SatelliteId1",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriberId",
                table: "AppLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "AppInternetServices",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "AppGsmDetails",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "AppFixedLines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "InstitutionAddress",
                table: "AppAuthorizedPersons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LineId",
                table: "AppAihs",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_AuthorizedPersonId1",
                table: "AppSubscribers",
                column: "AuthorizedPersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_AihId1",
                table: "AppLines",
                column: "AihId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_FixedLineId1",
                table: "AppLines",
                column: "FixedLineId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_GsmDetailId1",
                table: "AppLines",
                column: "GsmDetailId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_InternetServiceId1",
                table: "AppLines",
                column: "InternetServiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_SatelliteId1",
                table: "AppLines",
                column: "SatelliteId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_SubscriberId",
                table: "AppLines",
                column: "SubscriberId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppAihs_AihId1",
                table: "AppLines",
                column: "AihId1",
                principalTable: "AppAihs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppFixedLines_FixedLineId1",
                table: "AppLines",
                column: "FixedLineId1",
                principalTable: "AppFixedLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppGsmDetails_GsmDetailId1",
                table: "AppLines",
                column: "GsmDetailId1",
                principalTable: "AppGsmDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppInternetServices_InternetServiceId1",
                table: "AppLines",
                column: "InternetServiceId1",
                principalTable: "AppInternetServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppSatellites_SatelliteId1",
                table: "AppLines",
                column: "SatelliteId1",
                principalTable: "AppSatellites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppSubscribers_SubscriberId",
                table: "AppLines",
                column: "SubscriberId",
                principalTable: "AppSubscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSubscribers_AppAuthorizedPersons_AuthorizedPersonId1",
                table: "AppSubscribers",
                column: "AuthorizedPersonId1",
                principalTable: "AppAuthorizedPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppAihs_AihId1",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppFixedLines_FixedLineId1",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppGsmDetails_GsmDetailId1",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppInternetServices_InternetServiceId1",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppSatellites_SatelliteId1",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppSubscribers_SubscriberId",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSubscribers_AppAuthorizedPersons_AuthorizedPersonId1",
                table: "AppSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_AppSubscribers_AuthorizedPersonId1",
                table: "AppSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_AihId1",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_FixedLineId1",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_GsmDetailId1",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_InternetServiceId1",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_SatelliteId1",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_SubscriberId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "AuthorizedPersonId",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "AuthorizedPersonId1",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AppSatellites");

            migrationBuilder.DropColumn(
                name: "AihId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "AihId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "FixedLineId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "FixedLineId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "GsmDetailId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "GsmDetailId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "InternetServiceId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "InternetServiceId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "SatelliteId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "SatelliteId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "SubscriberId",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AppInternetServices");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AppGsmDetails");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AppFixedLines");

            migrationBuilder.DropColumn(
                name: "InstitutionAddress",
                table: "AppAuthorizedPersons");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AppAihs");

            migrationBuilder.RenameColumn(
                name: "SubscriberId",
                table: "AppAuthorizedPersons",
                newName: "InstitutionId");

            migrationBuilder.CreateTable(
                name: "AppInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    InstitutionAddress = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    Number = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPhones_AppSubscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "AppSubscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppSales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSales_AppPhones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "AppPhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppSales_AppServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "AppServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppSales_AppSubscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "AppSubscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizedPersons_InstitutionId",
                table: "AppAuthorizedPersons",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPhones_SubscriberId",
                table: "AppPhones",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSales_PhoneId",
                table: "AppSales",
                column: "PhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppSales_ServiceTypeId",
                table: "AppSales",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSales_SubscriberId",
                table: "AppSales",
                column: "SubscriberId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAuthorizedPersons_AppInstitutions_InstitutionId",
                table: "AppAuthorizedPersons",
                column: "InstitutionId",
                principalTable: "AppInstitutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
