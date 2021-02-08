﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RRFFilesManager.DataAccess;

namespace RRFFilesManager.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210208021806_DaysFromDateOfLoss")]
    partial class DaysFromDateOfLoss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RRFFilesManager.Abstractions.Archive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FileId");

                    b.HasIndex("TemplateId");

                    b.ToTable("Archives");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailToText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileCarrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuiteApt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int?>("Contact1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Contact2Id")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DirectExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailToText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("HealthCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileCarrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamMember")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("Contact1Id");

                    b.HasIndex("Contact2Id");

                    b.HasIndex("GroupID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.DisabilityInsuranceCompany", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DisabilityInsuranceCompanies");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.File", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOFLoss")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfCall")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FileLawyerID")
                        .HasColumnType("int");

                    b.Property<int>("FileNumber")
                        .HasColumnType("int");

                    b.Property<int?>("HowHearID")
                        .HasColumnType("int");

                    b.Property<string>("LimitationPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatterSubTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("MatterTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("ResponsibleLawyerID")
                        .HasColumnType("int");

                    b.Property<int?>("StaffInterviewerID")
                        .HasColumnType("int");

                    b.Property<string>("StatutoryNotice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("FileLawyerID");

                    b.HasIndex("HowHearID");

                    b.HasIndex("MatterSubTypeID");

                    b.HasIndex("MatterTypeID");

                    b.HasIndex("ResponsibleLawyerID");

                    b.HasIndex("StaffInterviewerID");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.HearAboutUs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HearAboutUs");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Intake", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccBenAdjuster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenClaimNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenDriverPassenger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenInsuranceCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenOCF1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenOCF2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenOCF3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenPolicyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenRegisOwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenReplacBenef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccBenWereRegisOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamHeadInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamHitVehicleConcrete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamLowerBodyInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamPreAccident")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamPreIllness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamPrescribed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamPsychologicalEffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamUpperBodyInjuries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamWereSeeingDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILCollecInsurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILEmployed4Weeks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILEmployed52Weeks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILEmployeeGrossEarning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILExplainJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILHowLongBusiness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILHowLongEmployee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILJobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILSelfBusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILSelfGrossEarning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILT4Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILT4Employee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILWereEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EILWereSelfEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExcelFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<bool>("Hold")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LiaDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LiaDriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaEstimDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaExplain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaFaultPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaHaveCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaHavePhotos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaInsuranceCo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LiaMVCExchange")
                        .HasColumnType("bit");

                    b.Property<bool>("LiaMVR")
                        .HasColumnType("bit");

                    b.Property<string>("LiaMunicipality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaNotifiedMunicipality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LiaOtherDoc")
                        .HasColumnType("bit");

                    b.Property<string>("LiaOwnNegligence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaOwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LiaReportCollision")
                        .HasColumnType("bit");

                    b.Property<string>("LiaWhereAccident")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiaYourFault")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolApplicationForCPP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolCPPApproved")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolCPPOwnOrCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PolCompanyDeniedBenefitsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PolDateLastDayLTD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PolDateLostBenefits")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PolDateStartedCollLTD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PolDateSubmittedLTD")
                        .HasColumnType("datetime2");

                    b.Property<string>("PolDeniedSTPorLTD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolFirstTimeLTDApproved")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolHowMuchBeingPaid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolLTDPrivateOrEmployerGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolOtherNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolReasonTerminateLTD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolSickBenefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolWhoPaidBenefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordFile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FileId")
                        .IsUnique();

                    b.HasIndex("PolCompanyDeniedBenefitsID");

                    b.ToTable("Intakes");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Lawyer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Lawyers");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.MatterSubType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DaysFromDateOfLoss")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatterTypeID")
                        .HasColumnType("int");

                    b.Property<string>("StatutoryNotice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MatterTypeID");

                    b.ToTable("MatterSubTypes");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.MatterType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MatterTypes");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.MobileCarrier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MobileCarriers");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Province", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Template", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatterTypeID")
                        .HasColumnType("int");

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplatePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfTemplate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MatterTypeID");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Archive", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.File", "File")
                        .WithMany("Archives")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRFFilesManager.Abstractions.Template", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Client", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Company", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Contact", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.HasOne("RRFFilesManager.Abstractions.Contact", "Contact1")
                        .WithMany()
                        .HasForeignKey("Contact1Id");

                    b.HasOne("RRFFilesManager.Abstractions.Contact", "Contact2")
                        .WithMany()
                        .HasForeignKey("Contact2Id");

                    b.HasOne("RRFFilesManager.Abstractions.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID");

                    b.HasOne("RRFFilesManager.Abstractions.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.File", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.Contact", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("RRFFilesManager.Abstractions.Lawyer", "FileLawyer")
                        .WithMany()
                        .HasForeignKey("FileLawyerID");

                    b.HasOne("RRFFilesManager.Abstractions.HearAboutUs", "HowHear")
                        .WithMany()
                        .HasForeignKey("HowHearID");

                    b.HasOne("RRFFilesManager.Abstractions.MatterSubType", "MatterSubType")
                        .WithMany()
                        .HasForeignKey("MatterSubTypeID");

                    b.HasOne("RRFFilesManager.Abstractions.MatterType", "MatterType")
                        .WithMany()
                        .HasForeignKey("MatterTypeID");

                    b.HasOne("RRFFilesManager.Abstractions.Lawyer", "ResponsibleLawyer")
                        .WithMany()
                        .HasForeignKey("ResponsibleLawyerID");

                    b.HasOne("RRFFilesManager.Abstractions.Lawyer", "StaffInterviewer")
                        .WithMany()
                        .HasForeignKey("StaffInterviewerID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Intake", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.File", "File")
                        .WithOne("Intake")
                        .HasForeignKey("RRFFilesManager.Abstractions.Intake", "FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRFFilesManager.Abstractions.DisabilityInsuranceCompany", "PolCompanyDeniedBenefits")
                        .WithMany()
                        .HasForeignKey("PolCompanyDeniedBenefitsID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.MatterSubType", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.MatterType", "MatterType")
                        .WithMany()
                        .HasForeignKey("MatterTypeID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Position", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID");
                });

            modelBuilder.Entity("RRFFilesManager.Abstractions.Template", b =>
                {
                    b.HasOne("RRFFilesManager.Abstractions.MatterType", "MatterType")
                        .WithMany()
                        .HasForeignKey("MatterTypeID");
                });
#pragma warning restore 612, 618
        }
    }
}
