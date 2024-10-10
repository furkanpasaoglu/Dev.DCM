using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Added_Types_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCustomerMovementCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ProcessingMethod = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCustomerMovementCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIdentityTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    No = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: false),
                    TypeCode = table.Column<string>(type: "text", nullable: false),
                    SerialNo = table.Column<string>(type: "text", nullable: false),
                    IdentityNo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppJobCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    No = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppJobCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppLineStatusCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    StatusDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLineStatusCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppServiceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    No = table.Column<int>(type: "integer", nullable: false),
                    BusinessType = table.Column<string>(type: "text", nullable: false),
                    InfrastructureType = table.Column<string>(type: "text", nullable: false),
                    ServiceTypeValue = table.Column<string>(type: "text", nullable: false),
                    ValueDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppServiceTypes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCustomerMovementCodes");

            migrationBuilder.DropTable(
                name: "AppIdentityTypes");

            migrationBuilder.DropTable(
                name: "AppJobCodes");

            migrationBuilder.DropTable(
                name: "AppLineStatusCodes");

            migrationBuilder.DropTable(
                name: "AppServiceTypes");
        }
    }
}
