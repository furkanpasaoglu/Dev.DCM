using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_Tenant_Entity_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTenantDetails_AbpTenants_TenantId1",
                table: "AppTenantDetails");

            migrationBuilder.DropIndex(
                name: "IX_AppTenantDetails_TenantId",
                table: "AppTenantDetails");

            migrationBuilder.DropIndex(
                name: "IX_AppTenantDetails_TenantId1",
                table: "AppTenantDetails");

            migrationBuilder.DropColumn(
                name: "TenantId1",
                table: "AppTenantDetails");

            migrationBuilder.CreateIndex(
                name: "IX_AppTenantDetails_TenantId",
                table: "AppTenantDetails",
                column: "TenantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppTenantDetails_TenantId",
                table: "AppTenantDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId1",
                table: "AppTenantDetails",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "FK_AppTenantDetails_AbpTenants_TenantId1",
                table: "AppTenantDetails",
                column: "TenantId1",
                principalTable: "AbpTenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
