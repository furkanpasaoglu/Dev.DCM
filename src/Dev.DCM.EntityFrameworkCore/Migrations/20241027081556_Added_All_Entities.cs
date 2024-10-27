using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dev.DCM.Migrations
{
    /// <inheritdoc />
    public partial class Added_All_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppAihs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeedProfile = table.Column<string>(type: "text", nullable: true),
                    ServiceProvider = table.Column<string>(type: "text", nullable: true),
                    PopInfo = table.Column<string>(type: "text", nullable: true),
                    CountryA = table.Column<string>(type: "text", nullable: true),
                    BorderCrossingPointA = table.Column<string>(type: "text", nullable: true),
                    BorderCrossingPointB = table.Column<string>(type: "text", nullable: true),
                    CircuitNaming = table.Column<string>(type: "text", nullable: true),
                    CircuitRoute = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: true),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uuid", nullable: true),
                    SubscriberNeighborhoodB = table.Column<string>(type: "text", nullable: true),
                    SubscriberStreetB = table.Column<string>(type: "text", nullable: true),
                    SubscriberBuildingNoB = table.Column<string>(type: "text", nullable: true),
                    SubscriberApartmentNoB = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppAihs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAihs_AppCities_CityId",
                        column: x => x.CityId,
                        principalTable: "AppCities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppAihs_AppCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AppCountries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppAihs_AppDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "AppDistricts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BranchName = table.Column<string>(type: "text", nullable: true),
                    BranchAddress = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppCustomerMovements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MovementCode = table.Column<int>(type: "integer", nullable: true),
                    MovementDescription = table.Column<string>(type: "text", nullable: true),
                    MovementTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
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
                    table.PrimaryKey("PK_AppCustomerMovements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppFixedLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PreviousFixedLineNumber = table.Column<string>(type: "text", nullable: true),
                    FrozenDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RestrictionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsInternationalActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsVoiceCallActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDirectoryActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsClirFeatureActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDataActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsIntercityCallActive = table.Column<bool>(type: "boolean", nullable: true),
                    CentralBuilding = table.Column<string>(type: "text", nullable: true),
                    CentralType = table.Column<string>(type: "text", nullable: true),
                    NetworkServiceNumber = table.Column<string>(type: "text", nullable: true),
                    PilotNumber = table.Column<string>(type: "text", nullable: true),
                    DdiServiceNumber = table.Column<string>(type: "text", nullable: true),
                    VisibleNumber = table.Column<string>(type: "text", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "text", nullable: true),
                    HomeOrOffice = table.Column<string>(type: "text", nullable: true),
                    SubscriberId = table.Column<string>(type: "text", nullable: true),
                    ServiceNumber = table.Column<string>(type: "text", nullable: true),
                    InternalNumber = table.Column<string>(type: "text", nullable: true),
                    AlphanumericTitle = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppFixedLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppGsmDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PreviousGsmNumber = table.Column<string>(type: "text", nullable: true),
                    FrozenDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RestrictionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsInternationalActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsVoiceCallActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDirectoryActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsClirFeatureActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDataActive = table.Column<bool>(type: "boolean", nullable: true),
                    EsKartInfo = table.Column<string>(type: "text", nullable: true),
                    Icci = table.Column<string>(type: "text", nullable: true),
                    Imsi = table.Column<string>(type: "text", nullable: true),
                    DualGsmNumber = table.Column<string>(type: "text", nullable: true),
                    FaxNumber = table.Column<string>(type: "text", nullable: true),
                    IsVpnShortCodeCallActive = table.Column<bool>(type: "boolean", nullable: false),
                    ServiceNumber = table.Column<string>(type: "text", nullable: true),
                    Info1 = table.Column<string>(type: "text", nullable: true),
                    Info2 = table.Column<string>(type: "text", nullable: true),
                    Info3 = table.Column<string>(type: "text", nullable: true),
                    AlphanumericTitle = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppGsmDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InstitutionAddress = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppInternetServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeedProfile = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    PopInfo = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppInternetServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LineNumber = table.Column<int>(type: "integer", nullable: true),
                    LineStatus = table.Column<string>(type: "text", nullable: true),
                    LineStatusCode = table.Column<int>(type: "integer", nullable: true),
                    StatusCodeDescription = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Numbers = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_AppPhones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSatellites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PreviousSatelliteLineNumber = table.Column<string>(type: "text", nullable: true),
                    FrozenDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RestrictionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsInternationalActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsVoiceCallActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDirectoryActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsClirFeatureActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDataActive = table.Column<bool>(type: "boolean", nullable: false),
                    SatelliteName = table.Column<string>(type: "text", nullable: true),
                    TerminalId = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<string>(type: "text", nullable: true),
                    Longitude = table.Column<string>(type: "text", nullable: true),
                    SpeedProfile = table.Column<string>(type: "text", nullable: true),
                    PopInfo = table.Column<string>(type: "text", nullable: true),
                    RemoteInfo = table.Column<string>(type: "text", nullable: true),
                    MainSatelliteCompany = table.Column<string>(type: "text", nullable: true),
                    SatellitePhoneNumber = table.Column<string>(type: "text", nullable: true),
                    AlphanumericTitle = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_AppSatellites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppActivations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ActivationUser = table.Column<string>(type: "text", nullable: true),
                    BranchId = table.Column<Guid>(type: "uuid", nullable: true),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: true),
                    PortalUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    IdentityUserId = table.Column<Guid>(type: "uuid", nullable: true),
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
                    table.PrimaryKey("PK_AppActivations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppActivations_AbpTenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AbpTenants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppActivations_AbpUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppActivations_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUpdaters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdaterUser = table.Column<string>(type: "text", nullable: true),
                    BranchId = table.Column<Guid>(type: "uuid", nullable: true),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    IdentityUserId = table.Column<Guid>(type: "uuid", nullable: true),
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
                    table.PrimaryKey("PK_AppUpdaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUpdaters_AbpTenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AbpTenants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUpdaters_AbpUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUpdaters_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppAuthorizedPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    NationalId = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    InstitutionId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppAuthorizedPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAuthorizedPersons_AppInstitutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "AppInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppSubscribers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerType = table.Column<int>(type: "integer", nullable: true),
                    SubscriptionStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    SubscriptionEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    NationalId = table.Column<string>(type: "text", nullable: true),
                    PassportNumber = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    TaxNumber = table.Column<string>(type: "text", nullable: true),
                    MersisNumber = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    MotherName = table.Column<string>(type: "text", nullable: true),
                    MotherMaidenName = table.Column<string>(type: "text", nullable: true),
                    BirthPlace = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Occupation = table.Column<string>(type: "text", nullable: true),
                    Tariff = table.Column<string>(type: "text", nullable: true),
                    PhoneId = table.Column<Guid>(type: "uuid", nullable: true),
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
                    table.PrimaryKey("PK_AppSubscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSubscribers_AppPhones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "AppPhones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppSatellitePhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: true),
                    ImeiNumber = table.Column<string>(type: "text", nullable: true),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    SimCardNumber = table.Column<string>(type: "text", nullable: true),
                    IsInternetUsageActive = table.Column<bool>(type: "boolean", nullable: true),
                    SatelliteServiceDetailId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppSatellitePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSatellitePhones_AppSatellites_SatelliteServiceDetailId",
                        column: x => x.SatelliteServiceDetailId,
                        principalTable: "AppSatellites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    SubscriberId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAddresses_AppSubscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "AppSubscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppIdentityDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VolumeNumber = table.Column<string>(type: "text", nullable: true),
                    FamilyRegistryNumber = table.Column<string>(type: "text", nullable: true),
                    PageNumber = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    NeighborhoodVillage = table.Column<string>(type: "text", nullable: true),
                    IdentityType = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<string>(type: "text", nullable: true),
                    IssuedPlace = table.Column<string>(type: "text", nullable: true),
                    IssuedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Affiliation = table.Column<string>(type: "text", nullable: true),
                    SubscriberId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppIdentityDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppIdentityDocuments_AppSubscribers_SubscriberId",
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
                    SubscriberId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceTypeId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppSales", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "AppContactInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactPhoneNumber1 = table.Column<string>(type: "text", nullable: true),
                    ContactPhoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppContactInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppContactInfos_AppAddresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AppAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppFacilityAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    BuildingNumber = table.Column<string>(type: "text", nullable: true),
                    ApartmentNumber = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    AddressCode = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppFacilityAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFacilityAddresses_AppAddresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AppAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppResidentialAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uuid", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    BuildingNumber = table.Column<string>(type: "text", nullable: true),
                    ApartmentNumber = table.Column<string>(type: "text", nullable: true),
                    AddressNo = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_AppResidentialAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppResidentialAddresses_AppAddresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AppAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppResidentialAddresses_AppCities_CityId",
                        column: x => x.CityId,
                        principalTable: "AppCities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppResidentialAddresses_AppDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "AppDistricts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppActivations_BranchId",
                table: "AppActivations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppActivations_IdentityUserId",
                table: "AppActivations",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppActivations_TenantId",
                table: "AppActivations",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAddresses_SubscriberId",
                table: "AppAddresses",
                column: "SubscriberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAihs_CityId",
                table: "AppAihs",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAihs_CountryId",
                table: "AppAihs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAihs_DistrictId",
                table: "AppAihs",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizedPersons_InstitutionId",
                table: "AppAuthorizedPersons",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppContactInfos_AddressId",
                table: "AppContactInfos",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppFacilityAddresses_AddressId",
                table: "AppFacilityAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AppIdentityDocuments_SubscriberId",
                table: "AppIdentityDocuments",
                column: "SubscriberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppResidentialAddresses_AddressId",
                table: "AppResidentialAddresses",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppResidentialAddresses_CityId",
                table: "AppResidentialAddresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppResidentialAddresses_DistrictId",
                table: "AppResidentialAddresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSales_ServiceTypeId",
                table: "AppSales",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSales_SubscriberId",
                table: "AppSales",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSatellitePhones_SatelliteServiceDetailId",
                table: "AppSatellitePhones",
                column: "SatelliteServiceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSubscribers_PhoneId",
                table: "AppSubscribers",
                column: "PhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdaters_BranchId",
                table: "AppUpdaters",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdaters_IdentityUserId",
                table: "AppUpdaters",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUpdaters_TenantId",
                table: "AppUpdaters",
                column: "TenantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppActivations");

            migrationBuilder.DropTable(
                name: "AppAihs");

            migrationBuilder.DropTable(
                name: "AppAuthorizedPersons");

            migrationBuilder.DropTable(
                name: "AppContactInfos");

            migrationBuilder.DropTable(
                name: "AppCustomerMovements");

            migrationBuilder.DropTable(
                name: "AppFacilityAddresses");

            migrationBuilder.DropTable(
                name: "AppFixedLines");

            migrationBuilder.DropTable(
                name: "AppGsmDetails");

            migrationBuilder.DropTable(
                name: "AppIdentityDocuments");

            migrationBuilder.DropTable(
                name: "AppInternetServices");

            migrationBuilder.DropTable(
                name: "AppLines");

            migrationBuilder.DropTable(
                name: "AppResidentialAddresses");

            migrationBuilder.DropTable(
                name: "AppSales");

            migrationBuilder.DropTable(
                name: "AppSatellitePhones");

            migrationBuilder.DropTable(
                name: "AppUpdaters");

            migrationBuilder.DropTable(
                name: "AppInstitutions");

            migrationBuilder.DropTable(
                name: "AppAddresses");

            migrationBuilder.DropTable(
                name: "AppSatellites");

            migrationBuilder.DropTable(
                name: "AppBranches");

            migrationBuilder.DropTable(
                name: "AppSubscribers");

            migrationBuilder.DropTable(
                name: "AppPhones");
        }
    }
}
