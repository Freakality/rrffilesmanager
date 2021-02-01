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
                        .Annotation("Jet:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityInsuranceCompanies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HearAboutUs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GroupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positions_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatterSubTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
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
                        .Annotation("Jet:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
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
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    GroupID = table.Column<int>(nullable: true),
                    Salutation = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    LicenseNumber = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    WorkNumber = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true),
                    DirectNumber = table.Column<string>(nullable: true),
                    DirectExtension = table.Column<string>(nullable: true),
                    OfficeNumber = table.Column<string>(nullable: true),
                    OfficeExtension = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    MobileCarrier = table.Column<string>(nullable: true),
                    EmailToText = table.Column<string>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    HealthCard = table.Column<string>(nullable: true),
                    SIN = table.Column<string>(nullable: true),
                    FirstLenguage = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    TeamMember = table.Column<string>(nullable: true),
                    Contact1Id = table.Column<int>(nullable: true),
                    Contact2Id = table.Column<int>(nullable: true),
                    Link = table.Column<string>(nullable: true)
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
                        name: "FK_Contacts_Contacts_Contact1Id",
                        column: x => x.Contact1Id,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Contacts_Contact2Id",
                        column: x => x.Contact2Id,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
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
                name: "Files",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
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
                        name: "FK_Files_Contacts_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Contacts",
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
                name: "Archives",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    TemplateId = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archives", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Archives_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Archives_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Intakes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
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
                        name: "FK_Intakes_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Intakes_DisabilityInsuranceCompanies_PolCompanyDeniedBenefit~",
                        column: x => x.PolCompanyDeniedBenefitsID,
                        principalTable: "DisabilityInsuranceCompanies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archives_FileId",
                table: "Archives",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Archives_TemplateId",
                table: "Archives",
                column: "TemplateId");

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
                name: "IX_Contacts_Contact1Id",
                table: "Contacts",
                column: "Contact1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Contact2Id",
                table: "Contacts",
                column: "Contact2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_GroupID",
                table: "Contacts",
                column: "GroupID");

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
                name: "IX_Intakes_FileId",
                table: "Intakes",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Intakes_PolCompanyDeniedBenefitsID",
                table: "Intakes",
                column: "PolCompanyDeniedBenefitsID");

            migrationBuilder.CreateIndex(
                name: "IX_MatterSubTypes_MatterTypeID",
                table: "MatterSubTypes",
                column: "MatterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_GroupID",
                table: "Positions",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_MatterTypeID",
                table: "Templates",
                column: "MatterTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archives");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Intakes");

            migrationBuilder.DropTable(
                name: "MobileCarriers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "DisabilityInsuranceCompanies");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Lawyers");

            migrationBuilder.DropTable(
                name: "HearAboutUs");

            migrationBuilder.DropTable(
                name: "MatterSubTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "MatterTypes");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
