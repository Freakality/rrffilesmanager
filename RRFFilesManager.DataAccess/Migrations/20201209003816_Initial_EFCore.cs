using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Initial_EFCore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisabilityInsuranceCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityInsuranceCompanies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HearAboutUs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HearAboutUs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lawyers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    NumberID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MatterTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatterTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MobileCarriers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Gate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileCarriers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MatterSubTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MatterTypeID = table.Column<int>(nullable: true),
                    StatutoryNotice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatterSubTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MatterSubTypes_MatterTypes_MatterTypeID",
                        column: x => x.MatterTypeID,
                        principalTable: "MatterTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatterTypeID = table.Column<int>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    TypeOfTemplate = table.Column<string>(nullable: true),
                    TemplateName = table.Column<string>(nullable: true),
                    TemplatePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Templates_MatterTypes_MatterTypeID",
                        column: x => x.MatterTypeID,
                        principalTable: "MatterTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SuiteApt = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    WorkNumber = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    MobileCarrier = table.Column<string>(nullable: true),
                    EmailToText = table.Column<string>(nullable: true),
                    OtherNotes = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clients_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Companies_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileNumber = table.Column<int>(nullable: false),
                    MatterTypeID = table.Column<int>(nullable: true),
                    DateOfCall = table.Column<DateTime>(nullable: false),
                    DateOFLoss = table.Column<DateTime>(nullable: false),
                    StaffInterviewerID = table.Column<int>(nullable: true),
                    HowHearID = table.Column<int>(nullable: true),
                    FileLawyerID = table.Column<int>(nullable: true),
                    ResponsibleLawyerID = table.Column<int>(nullable: true),
                    MatterSubTypeID = table.Column<int>(nullable: true),
                    LimitationPeriod = table.Column<string>(nullable: true),
                    StatutoryNotice = table.Column<string>(nullable: true),
                    AdditionalNotes = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Files_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Lawyers_FileLawyerID",
                        column: x => x.FileLawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_HearAboutUs_HowHearID",
                        column: x => x.HowHearID,
                        principalTable: "HearAboutUs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_MatterSubTypes_MatterSubTypeID",
                        column: x => x.MatterSubTypeID,
                        principalTable: "MatterSubTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_MatterTypes_MatterTypeID",
                        column: x => x.MatterTypeID,
                        principalTable: "MatterTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Lawyers_ResponsibleLawyerID",
                        column: x => x.ResponsibleLawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Lawyers_StaffInterviewerID",
                        column: x => x.StaffInterviewerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Intakes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileID = table.Column<int>(nullable: true),
                    LiaDate = table.Column<DateTime>(nullable: false),
                    LiaMVR = table.Column<bool>(nullable: false),
                    LiaReportCollision = table.Column<bool>(nullable: false),
                    LiaMVCExchange = table.Column<bool>(nullable: false),
                    LiaOtherDoc = table.Column<bool>(nullable: false),
                    LiaWhereAccident = table.Column<string>(nullable: true),
                    LiaExplain = table.Column<string>(nullable: true),
                    LiaHavePhotos = table.Column<string>(nullable: true),
                    LiaEstimDamage = table.Column<string>(nullable: true),
                    LiaYourFault = table.Column<string>(nullable: true),
                    LiaDriverName = table.Column<string>(nullable: true),
                    LiaOwnerName = table.Column<string>(nullable: true),
                    LiaInsuranceCo = table.Column<string>(nullable: true),
                    LiaHaveCopy = table.Column<string>(nullable: true),
                    LiaOwnNegligence = table.Column<string>(nullable: true),
                    LiaFaultPerson = table.Column<string>(nullable: true),
                    LiaMunicipality = table.Column<string>(nullable: true),
                    LiaNotifiedMunicipality = table.Column<string>(nullable: true),
                    LiaNotes = table.Column<string>(nullable: true),
                    EILWereEmployed = table.Column<string>(nullable: true),
                    EILEmployed4Weeks = table.Column<string>(nullable: true),
                    EILEmployed52Weeks = table.Column<string>(nullable: true),
                    EILT4Employee = table.Column<string>(nullable: true),
                    EILT4Company = table.Column<string>(nullable: true),
                    EILCollecInsurance = table.Column<string>(nullable: true),
                    EILEmployeeGrossEarning = table.Column<string>(nullable: true),
                    EILHowLongEmployee = table.Column<string>(nullable: true),
                    EILJobTitle = table.Column<string>(nullable: true),
                    EILExplainJob = table.Column<string>(nullable: true),
                    EILWereSelfEmployed = table.Column<string>(nullable: true),
                    EILSelfBusinessName = table.Column<string>(nullable: true),
                    EILSelfGrossEarning = table.Column<string>(nullable: true),
                    EILHowLongBusiness = table.Column<string>(nullable: true),
                    EILNotes = table.Column<string>(nullable: true),
                    DamHitVehicleConcrete = table.Column<string>(nullable: true),
                    DamHeadInjuries = table.Column<string>(nullable: true),
                    DamUpperBodyInjuries = table.Column<string>(nullable: true),
                    DamLowerBodyInjuries = table.Column<string>(nullable: true),
                    DamPsychologicalEffect = table.Column<string>(nullable: true),
                    DamPrescribed = table.Column<string>(nullable: true),
                    DamWereSeeingDoctor = table.Column<string>(nullable: true),
                    DamPreAccident = table.Column<string>(nullable: true),
                    DamPreIllness = table.Column<string>(nullable: true),
                    DamNotes = table.Column<string>(nullable: true),
                    AccBenDriverPassenger = table.Column<string>(nullable: true),
                    AccBenWereRegisOwner = table.Column<string>(nullable: true),
                    AccBenRegisOwnerName = table.Column<string>(nullable: true),
                    AccBenPolicyNumber = table.Column<string>(nullable: true),
                    AccBenClaimNumber = table.Column<string>(nullable: true),
                    AccBenInsuranceCompany = table.Column<string>(nullable: true),
                    AccBenAdjuster = table.Column<string>(nullable: true),
                    AccBenOCF1 = table.Column<string>(nullable: true),
                    AccBenOCF2 = table.Column<string>(nullable: true),
                    AccBenOCF3 = table.Column<string>(nullable: true),
                    AccBenReplacBenef = table.Column<string>(nullable: true),
                    AccBenNotes = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PolSickBenefits = table.Column<string>(nullable: true),
                    PolWhoPaidBenefits = table.Column<string>(nullable: true),
                    PolDateLostBenefits = table.Column<DateTime>(nullable: false),
                    PolDeniedSTPorLTD = table.Column<string>(nullable: true),
                    PolHowMuchBeingPaid = table.Column<string>(nullable: true),
                    PolCompanyDeniedBenefitsID = table.Column<int>(nullable: true),
                    PolLTDPrivateOrEmployerGroup = table.Column<string>(nullable: true),
                    PolDateSubmittedLTD = table.Column<DateTime>(nullable: false),
                    PolDateStartedCollLTD = table.Column<DateTime>(nullable: false),
                    PolDateLastDayLTD = table.Column<DateTime>(nullable: false),
                    PolFirstTimeLTDApproved = table.Column<string>(nullable: true),
                    PolReasonTerminateLTD = table.Column<string>(nullable: true),
                    PolApplicationForCPP = table.Column<string>(nullable: true),
                    PolCPPOwnOrCompany = table.Column<string>(nullable: true),
                    PolCPPApproved = table.Column<string>(nullable: true),
                    PolOtherNotes = table.Column<string>(nullable: true),
                    Hold = table.Column<bool>(nullable: false),
                    ExcelFile = table.Column<string>(nullable: true),
                    WordFile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intakes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Intakes_Files_FileID",
                        column: x => x.FileID,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Intakes_DisabilityInsuranceCompanies_PolCompanyDeniedBenefitsID",
                        column: x => x.PolCompanyDeniedBenefitsID,
                        principalTable: "DisabilityInsuranceCompanies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ProvinceID",
                table: "Clients",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProvinceID",
                table: "Companies",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CompanyID",
                table: "Contacts",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ProvinceID",
                table: "Contacts",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ClientID",
                table: "Files",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FileLawyerID",
                table: "Files",
                column: "FileLawyerID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_HowHearID",
                table: "Files",
                column: "HowHearID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_MatterSubTypeID",
                table: "Files",
                column: "MatterSubTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_MatterTypeID",
                table: "Files",
                column: "MatterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ResponsibleLawyerID",
                table: "Files",
                column: "ResponsibleLawyerID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_StaffInterviewerID",
                table: "Files",
                column: "StaffInterviewerID");

            migrationBuilder.CreateIndex(
                name: "IX_Intakes_FileID",
                table: "Intakes",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_Intakes_PolCompanyDeniedBenefitsID",
                table: "Intakes",
                column: "PolCompanyDeniedBenefitsID");

            migrationBuilder.CreateIndex(
                name: "IX_MatterSubTypes_MatterTypeID",
                table: "MatterSubTypes",
                column: "MatterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_MatterTypeID",
                table: "Templates",
                column: "MatterTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Intakes");

            migrationBuilder.DropTable(
                name: "MobileCarriers");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "DisabilityInsuranceCompanies");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Lawyers");

            migrationBuilder.DropTable(
                name: "HearAboutUs");

            migrationBuilder.DropTable(
                name: "MatterSubTypes");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "MatterTypes");
        }
    }
}
