using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_All_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AppServiceTypes_No",
                table: "AppServiceTypes",
                column: "No",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppServiceTypes_ServiceTypeValue",
                table: "AppServiceTypes",
                column: "ServiceTypeValue",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppParameters_Name",
                table: "AppParameters",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLineStatusCodes_Code",
                table: "AppLineStatusCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppJobCodes_Code",
                table: "AppJobCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppJobCodes_No",
                table: "AppJobCodes",
                column: "No",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppIdentityTypes_No",
                table: "AppIdentityTypes",
                column: "No",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppDistricts_Name",
                table: "AppDistricts",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCustomerMovementCodes_Code",
                table: "AppCustomerMovementCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCustomerMovementCodes_Description",
                table: "AppCustomerMovementCodes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCountries_Code",
                table: "AppCountries",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCountries_Name",
                table: "AppCountries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCities_Name",
                table: "AppCities",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppServiceTypes_No",
                table: "AppServiceTypes");

            migrationBuilder.DropIndex(
                name: "IX_AppServiceTypes_ServiceTypeValue",
                table: "AppServiceTypes");

            migrationBuilder.DropIndex(
                name: "IX_AppParameters_Name",
                table: "AppParameters");

            migrationBuilder.DropIndex(
                name: "IX_AppLineStatusCodes_Code",
                table: "AppLineStatusCodes");

            migrationBuilder.DropIndex(
                name: "IX_AppJobCodes_Code",
                table: "AppJobCodes");

            migrationBuilder.DropIndex(
                name: "IX_AppJobCodes_No",
                table: "AppJobCodes");

            migrationBuilder.DropIndex(
                name: "IX_AppIdentityTypes_No",
                table: "AppIdentityTypes");

            migrationBuilder.DropIndex(
                name: "IX_AppDistricts_Name",
                table: "AppDistricts");

            migrationBuilder.DropIndex(
                name: "IX_AppCustomerMovementCodes_Code",
                table: "AppCustomerMovementCodes");

            migrationBuilder.DropIndex(
                name: "IX_AppCustomerMovementCodes_Description",
                table: "AppCustomerMovementCodes");

            migrationBuilder.DropIndex(
                name: "IX_AppCountries_Code",
                table: "AppCountries");

            migrationBuilder.DropIndex(
                name: "IX_AppCountries_Name",
                table: "AppCountries");

            migrationBuilder.DropIndex(
                name: "IX_AppCities_Name",
                table: "AppCities");
        }
    }
}
