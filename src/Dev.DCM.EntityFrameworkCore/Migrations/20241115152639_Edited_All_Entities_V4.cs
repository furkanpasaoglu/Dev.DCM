using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_All_Entities_V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppActivations_AbpUsers_IdentityUserId",
                table: "AppActivations");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAddresses_AppSubscribers_SubscriberId",
                table: "AppAddresses");

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
                name: "FK_AppSubscribers_AppAuthorizedPersons_AuthorizedPersonId1",
                table: "AppSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUpdaters_AbpUsers_IdentityUserId",
                table: "AppUpdaters");

            migrationBuilder.DropIndex(
                name: "IX_AppUpdaters_IdentityUserId",
                table: "AppUpdaters");

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
                name: "IX_AppAddresses_SubscriberId",
                table: "AppAddresses");

            migrationBuilder.DropIndex(
                name: "IX_AppActivations_IdentityUserId",
                table: "AppActivations");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "AppUpdaters");

            migrationBuilder.DropColumn(
                name: "AuthorizedPersonId1",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "AihId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "FixedLineId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "GsmDetailId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "InternetServiceId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "SatelliteId1",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "AppActivations");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdentityDocumentId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContactInfoId",
                table: "AppAddresses",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResidentialAddressId",
                table: "AppAddresses",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdaters_UserId",
                table: "AppUpdaters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_AddressId",
                table: "AppSubscribers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_AihId",
                table: "AppLines",
                column: "AihId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_FixedLineId",
                table: "AppLines",
                column: "FixedLineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_GsmDetailId",
                table: "AppLines",
                column: "GsmDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_InternetServiceId",
                table: "AppLines",
                column: "InternetServiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLines_SatelliteId",
                table: "AppLines",
                column: "SatelliteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizedPersons_SubscriberId",
                table: "AppAuthorizedPersons",
                column: "SubscriberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppActivations_PortalUserId",
                table: "AppActivations",
                column: "PortalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppActivations_AbpUsers_PortalUserId",
                table: "AppActivations",
                column: "PortalUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAuthorizedPersons_AppSubscribers_SubscriberId",
                table: "AppAuthorizedPersons",
                column: "SubscriberId",
                principalTable: "AppSubscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppAihs_AihId",
                table: "AppLines",
                column: "AihId",
                principalTable: "AppAihs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppFixedLines_FixedLineId",
                table: "AppLines",
                column: "FixedLineId",
                principalTable: "AppFixedLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppGsmDetails_GsmDetailId",
                table: "AppLines",
                column: "GsmDetailId",
                principalTable: "AppGsmDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppInternetServices_InternetServiceId",
                table: "AppLines",
                column: "InternetServiceId",
                principalTable: "AppInternetServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLines_AppSatellites_SatelliteId",
                table: "AppLines",
                column: "SatelliteId",
                principalTable: "AppSatellites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSubscribers_AppAddresses_AddressId",
                table: "AppSubscribers",
                column: "AddressId",
                principalTable: "AppAddresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUpdaters_AbpUsers_UserId",
                table: "AppUpdaters",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppActivations_AbpUsers_PortalUserId",
                table: "AppActivations");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAuthorizedPersons_AppSubscribers_SubscriberId",
                table: "AppAuthorizedPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppAihs_AihId",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppFixedLines_FixedLineId",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppGsmDetails_GsmDetailId",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppInternetServices_InternetServiceId",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLines_AppSatellites_SatelliteId",
                table: "AppLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSubscribers_AppAddresses_AddressId",
                table: "AppSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUpdaters_AbpUsers_UserId",
                table: "AppUpdaters");

            migrationBuilder.DropIndex(
                name: "IX_AppUpdaters_UserId",
                table: "AppUpdaters");

            migrationBuilder.DropIndex(
                name: "IX_AppSubscribers_AddressId",
                table: "AppSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_AihId",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_FixedLineId",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_GsmDetailId",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_InternetServiceId",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppLines_SatelliteId",
                table: "AppLines");

            migrationBuilder.DropIndex(
                name: "IX_AppAuthorizedPersons_SubscriberId",
                table: "AppAuthorizedPersons");

            migrationBuilder.DropIndex(
                name: "IX_AppActivations_PortalUserId",
                table: "AppActivations");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "IdentityDocumentId",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "AppAddresses");

            migrationBuilder.DropColumn(
                name: "ResidentialAddressId",
                table: "AppAddresses");

            migrationBuilder.AddColumn<Guid>(
                name: "IdentityUserId",
                table: "AppUpdaters",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorizedPersonId1",
                table: "AppSubscribers",
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
                name: "FixedLineId1",
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
                name: "InternetServiceId1",
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
                name: "IdentityUserId",
                table: "AppActivations",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdaters_IdentityUserId",
                table: "AppUpdaters",
                column: "IdentityUserId");

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
                name: "IX_AppAddresses_SubscriberId",
                table: "AppAddresses",
                column: "SubscriberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppActivations_IdentityUserId",
                table: "AppActivations",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppActivations_AbpUsers_IdentityUserId",
                table: "AppActivations",
                column: "IdentityUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAddresses_AppSubscribers_SubscriberId",
                table: "AppAddresses",
                column: "SubscriberId",
                principalTable: "AppSubscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_AppSubscribers_AppAuthorizedPersons_AuthorizedPersonId1",
                table: "AppSubscribers",
                column: "AuthorizedPersonId1",
                principalTable: "AppAuthorizedPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUpdaters_AbpUsers_IdentityUserId",
                table: "AppUpdaters",
                column: "IdentityUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }
    }
}
