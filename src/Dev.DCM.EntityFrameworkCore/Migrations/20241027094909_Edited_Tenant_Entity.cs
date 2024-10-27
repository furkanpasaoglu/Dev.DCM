using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_Tenant_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSubscribers_AppPhones_PhoneId",
                table: "AppSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_AppSubscribers_PhoneId",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "AppSubscribers");

            migrationBuilder.RenameColumn(
                name: "Numbers",
                table: "AppPhones",
                newName: "Number");

            migrationBuilder.AddColumn<Guid>(
                name: "PhoneId",
                table: "AppSales",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AppPhones",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriberId",
                table: "AppPhones",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AppTenantDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OperatorCode = table.Column<string>(type: "text", nullable: false),
                    TaxNumber = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false),
                    TenantId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTenantDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTenantDetails_AbpTenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppTenantDetails_AbpTenants_TenantId1",
                        column: x => x.TenantId1,
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppSales_PhoneId",
                table: "AppSales",
                column: "PhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppPhones_SubscriberId",
                table: "AppPhones",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTenantDetails_TenantId",
                table: "AppTenantDetails",
                column: "TenantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppTenantDetails_TenantId1",
                table: "AppTenantDetails",
                column: "TenantId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppPhones_AppSubscribers_SubscriberId",
                table: "AppPhones",
                column: "SubscriberId",
                principalTable: "AppSubscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSales_AppPhones_PhoneId",
                table: "AppSales",
                column: "PhoneId",
                principalTable: "AppPhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPhones_AppSubscribers_SubscriberId",
                table: "AppPhones");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSales_AppPhones_PhoneId",
                table: "AppSales");

            migrationBuilder.DropTable(
                name: "AppTenantDetails");

            migrationBuilder.DropIndex(
                name: "IX_AppSales_PhoneId",
                table: "AppSales");

            migrationBuilder.DropIndex(
                name: "IX_AppPhones_SubscriberId",
                table: "AppPhones");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "AppSales");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AppPhones");

            migrationBuilder.DropColumn(
                name: "SubscriberId",
                table: "AppPhones");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "AppPhones",
                newName: "Numbers");

            migrationBuilder.AddColumn<Guid>(
                name: "PhoneId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_PhoneId",
                table: "AppSubscribers",
                column: "PhoneId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSubscribers_AppPhones_PhoneId",
                table: "AppSubscribers",
                column: "PhoneId",
                principalTable: "AppPhones",
                principalColumn: "Id");
        }
    }
}
