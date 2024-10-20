using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_ServiceTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AppServiceTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AppServiceTypes");
        }
    }
}
