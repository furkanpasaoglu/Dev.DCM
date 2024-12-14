using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Edited_Entities_V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAuthorizedPersons_AppSubscribers_SubscriberId",
                table: "AppAuthorizedPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_AppIdentityDocuments_AppSubscribers_SubscriberId",
                table: "AppIdentityDocuments");

            migrationBuilder.DropIndex(
                name: "IX_AppIdentityDocuments_SubscriberId",
                table: "AppIdentityDocuments");

            migrationBuilder.DropIndex(
                name: "IX_AppAuthorizedPersons_SubscriberId",
                table: "AppAuthorizedPersons");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "AppSubscribers");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorizedPersonId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerTypeId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "AppLines",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StarDate",
                table: "AppLines",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EntityMovementId",
                table: "AppCustomerMovements",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "EntityMovementType",
                table: "AppCustomerMovements",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_AuthorizedPersonId",
                table: "AppSubscribers",
                column: "AuthorizedPersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_CustomerTypeId",
                table: "AppSubscribers",
                column: "CustomerTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_IdentityDocumentId",
                table: "AppSubscribers",
                column: "IdentityDocumentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSubscribers_AppAuthorizedPersons_AuthorizedPersonId",
                table: "AppSubscribers",
                column: "AuthorizedPersonId",
                principalTable: "AppAuthorizedPersons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSubscribers_AppIdentityDocuments_IdentityDocumentId",
                table: "AppSubscribers",
                column: "IdentityDocumentId",
                principalTable: "AppIdentityDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSubscribers_CustomerType_CustomerTypeId",
                table: "AppSubscribers",
                column: "CustomerTypeId",
                principalTable: "CustomerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSubscribers_AppAuthorizedPersons_AuthorizedPersonId",
                table: "AppSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSubscribers_AppIdentityDocuments_IdentityDocumentId",
                table: "AppSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSubscribers_CustomerType_CustomerTypeId",
                table: "AppSubscribers");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropIndex(
                name: "IX_AppSubscribers_AuthorizedPersonId",
                table: "AppSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_AppSubscribers_CustomerTypeId",
                table: "AppSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_AppSubscribers_IdentityDocumentId",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                table: "AppSubscribers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "StarDate",
                table: "AppLines");

            migrationBuilder.DropColumn(
                name: "EntityMovementId",
                table: "AppCustomerMovements");

            migrationBuilder.DropColumn(
                name: "EntityMovementType",
                table: "AppCustomerMovements");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorizedPersonId",
                table: "AppSubscribers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerType",
                table: "AppSubscribers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppIdentityDocuments_SubscriberId",
                table: "AppIdentityDocuments",
                column: "SubscriberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizedPersons_SubscriberId",
                table: "AppAuthorizedPersons",
                column: "SubscriberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppAuthorizedPersons_AppSubscribers_SubscriberId",
                table: "AppAuthorizedPersons",
                column: "SubscriberId",
                principalTable: "AppSubscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppIdentityDocuments_AppSubscribers_SubscriberId",
                table: "AppIdentityDocuments",
                column: "SubscriberId",
                principalTable: "AppSubscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
