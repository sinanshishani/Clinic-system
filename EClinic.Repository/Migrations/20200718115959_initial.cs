using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EClinic.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountContact",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    AccountId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountPermission",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    PermissionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountSubscriptionPlan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    AccountId = table.Column<long>(nullable: false),
                    SubscriptionPlanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSubscriptionPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Allergic",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disease",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disease", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    RegionalId = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    AccountId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompany",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    FaxNumber = table.Column<string>(nullable: true),
                    PostalBox = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    VisitPrice = table.Column<double>(nullable: false),
                    ContractExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractStatus = table.Column<string>(nullable: false),
                    ContractFileUrl = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    AccountId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitProcedure",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitProcedure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurgeriesProcedures",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    SurgeryProcedureId = table.Column<long>(nullable: false),
                    SurgeryId = table.Column<long>(nullable: false),
                    SystemSurgeryProcedureId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgeriesProcedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surgery",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurgeryProcedure",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgeryProcedure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    AccountId = table.Column<long>(nullable: false),
                    IsDoctor = table.Column<bool>(nullable: false),
                    IsAccountManager = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginPeriod = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AccountId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalContact",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    ExtensionNumber = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    HospitalId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalContact_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalContact_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalContact_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalContact_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanyContact",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    ExtensionNumber = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    InsuranceCompanyId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanyContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceCompanyContact_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsuranceCompanyContact_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsuranceCompanyContact_InsuranceCompany_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsuranceCompanyContact_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitComplaintDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PainDegree = table.Column<int>(nullable: true),
                    Place = table.Column<string>(maxLength: 500, nullable: true),
                    Duration = table.Column<int>(nullable: true),
                    PainIncreasinFactors = table.Column<string>(nullable: true),
                    DiseaseCause = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitComplaintDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaintDetails_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaintDetails_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaintDetails_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientAppointment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    DoctorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAppointment_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAppointment_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAppointment_User_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientAppointment_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicalVisitProcedure",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MedicalProcedureId = table.Column<long>(nullable: false),
                    MedicalProcedureName = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ProcedureInsuranceStatus = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    IsInsuranceApproved = table.Column<bool>(nullable: false),
                    ApprovalNumber = table.Column<string>(nullable: true),
                    MedicalProceduresPayloadRatio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicalVisitProcedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientMedicalVisitProcedure_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientMedicalVisitProcedure_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientMedicalVisitProcedure_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsAutoPermission = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permission_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permission_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemAllergic",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAllergic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemAllergic_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAllergic_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAllergic_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemBank",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemBank_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemBank_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemBank_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemComplaint",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemComplaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemComplaint_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemComplaint_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemComplaint_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemDiagnosis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemDiagnosis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemDiagnosis_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemDiagnosis_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemDiagnosis_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemDisease",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemDisease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemDisease_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemDisease_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemDisease_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemMedicalVisitProcedure",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMedicalVisitProcedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemMedicalVisitProcedure_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemMedicalVisitProcedure_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemMedicalVisitProcedure_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemSubscriptionPlan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSubscriptionPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionPlan_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionPlan_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionPlan_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemSurgery",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSurgery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSurgery_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgery_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgery_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemSurgeryProcedure",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSurgeryProcedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSurgeryProcedure_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgeryProcedure_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgeryProcedure_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemAccountType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    SystemSubscriptionPlanId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAccountType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemAccountType_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAccountType_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAccountType_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAccountType_SystemSubscriptionPlan_SystemSubscriptionPlanId",
                        column: x => x.SystemSubscriptionPlanId,
                        principalTable: "SystemSubscriptionPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemSubscriptionDuration",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SubscriptionPlanId = table.Column<long>(nullable: false),
                    DurationInDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSubscriptionDuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionDuration_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionDuration_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionDuration_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSubscriptionDuration_SystemSubscriptionPlan_SubscriptionPlanId",
                        column: x => x.SubscriptionPlanId,
                        principalTable: "SystemSubscriptionPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemSurgeriesProcedures",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SurgeryProcedureId = table.Column<long>(nullable: false),
                    SurgeryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSurgeriesProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSurgeriesProcedures_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgeriesProcedures_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgeriesProcedures_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSurgeriesProcedures_SystemSurgery_SurgeryId",
                        column: x => x.SurgeryId,
                        principalTable: "SystemSurgery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemSurgeriesProcedures_SystemSurgeryProcedure_SurgeryProcedureId",
                        column: x => x.SurgeryProcedureId,
                        principalTable: "SystemSurgeryProcedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionAccountType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PermissionId = table.Column<long>(nullable: false),
                    AccountTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionAccountType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionAccountType_SystemAccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "SystemAccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionAccountType_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionAccountType_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionAccountType_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionAccountType_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemAccountSubType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountTypeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAccountSubType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemAccountSubType_SystemAccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "SystemAccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemAccountSubType_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAccountSubType_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemAccountSubType_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    IsAdminAccount = table.Column<bool>(nullable: false),
                    ManageId = table.Column<long>(nullable: true),
                    AccountTypeId = table.Column<long>(nullable: false),
                    AccountSubTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_SystemAccountSubType_AccountSubTypeId",
                        column: x => x.AccountSubTypeId,
                        principalTable: "SystemAccountSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_SystemAccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "SystemAccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PermissionAccountSubType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PermissionId = table.Column<long>(nullable: false),
                    AccountSubTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionAccountSubType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionAccountSubType_SystemAccountSubType_AccountSubTypeId",
                        column: x => x.AccountSubTypeId,
                        principalTable: "SystemAccountSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionAccountSubType_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionAccountSubType_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionAccountSubType_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionAccountSubType_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientAllergic",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AllergicId = table.Column<long>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAllergic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAllergic_Allergic_AllergicId",
                        column: x => x.AllergicId,
                        principalTable: "Allergic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientAllergic_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAllergic_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitComplaint",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ComplaintId = table.Column<long>(nullable: false),
                    MedicalVisitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitComplaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaint_Complaint_ComplaintId",
                        column: x => x.ComplaintId,
                        principalTable: "Complaint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaint_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaint_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitComplaint_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitDiagnosis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MedicalVisitId = table.Column<long>(nullable: false),
                    DiagnosisId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitDiagnosis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitDiagnosis_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitDiagnosis_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitDiagnosis_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalVisitDiagnosis_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisit",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    DoctorId = table.Column<long>(nullable: false),
                    ComplaintId = table.Column<long>(nullable: false),
                    ComplaintDetails = table.Column<string>(maxLength: 500, nullable: true),
                    DiagnosisId = table.Column<long>(nullable: false),
                    DiagnosisDetails = table.Column<string>(maxLength: 500, nullable: true),
                    VisitNotes = table.Column<string>(maxLength: 500, nullable: true),
                    InsuranceFormNumber = table.Column<string>(maxLength: 500, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    PatientPricePayload = table.Column<double>(nullable: false),
                    MedicalProceduresPrice = table.Column<double>(nullable: false),
                    PatientMedicalProceduresPricePayload = table.Column<double>(nullable: false),
                    PatientPayloadTotal = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    NeedHospitalAdmission = table.Column<bool>(nullable: false),
                    HospitalAdmissionNotes = table.Column<string>(nullable: true),
                    NeedCheckUp = table.Column<bool>(nullable: false),
                    NeedMedicine = table.Column<bool>(nullable: false),
                    NeedXRay = table.Column<bool>(nullable: false),
                    NeedMedicalPrcedure = table.Column<bool>(nullable: false),
                    IsInsuranceActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisit_MedicalVisitComplaintDetails_ComplaintId",
                        column: x => x.ComplaintId,
                        principalTable: "MedicalVisitComplaintDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalVisit_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisit_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisit_MedicalVisitDiagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "MedicalVisitDiagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalVisit_User_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalVisit_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitInsurance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FormNumber = table.Column<string>(nullable: true),
                    FormUrl = table.Column<string>(nullable: true),
                    InsuranceNumber = table.Column<string>(nullable: true),
                    InRate = table.Column<double>(nullable: false),
                    OutRate = table.Column<double>(nullable: false),
                    DoctorVisitRateType = table.Column<string>(nullable: true),
                    DoctorVisitRate = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    MedicalVisitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitInsurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitInsurance_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitInsurance_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitInsurance_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitInsurance_MedicalVisit_MedicalVisitId",
                        column: x => x.MedicalVisitId,
                        principalTable: "MedicalVisit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitMedicine",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    HowToUse = table.Column<string>(nullable: true),
                    MedicalVisitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitMedicine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitMedicine_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitMedicine_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitMedicine_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitMedicine_MedicalVisit_MedicalVisitId",
                        column: x => x.MedicalVisitId,
                        principalTable: "MedicalVisit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientFamilyDisease",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DiseaseId = table.Column<long>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientFamilyDisease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientFamilyDisease_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientFamilyDisease_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientFamilyDisease_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientInternalDisease",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DiseaseId = table.Column<long>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInternalDisease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientInternalDisease_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientInternalDisease_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientInternalDisease_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientSurgicalDisease",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DiseaseId = table.Column<long>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientSurgicalDisease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientSurgicalDisease_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSurgicalDisease_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSurgicalDisease_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalVisit",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    ReportFileUrl = table.Column<string>(nullable: true),
                    IsValidInsurance = table.Column<bool>(nullable: false),
                    HasProcedure = table.Column<bool>(nullable: false),
                    DoctorFeesPrice = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    PaymentNote = table.Column<string>(nullable: false),
                    DcotorId = table.Column<long>(nullable: false),
                    HospitalId = table.Column<long>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalVisit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalVisit_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalVisit_User_DcotorId",
                        column: x => x.DcotorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalVisit_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalVisit_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalVisit_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientInsurance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InsuranceNumber = table.Column<string>(nullable: false),
                    MedicalVisitPayloadRate = table.Column<int>(nullable: false),
                    MedicalProceduresPayloadRate = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    DoctorVisitRateType = table.Column<int>(nullable: false),
                    DoctorVisitRate = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(maxLength: 200, nullable: true),
                    PatientProfileId = table.Column<long>(nullable: false),
                    InsuranceCompanyId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInsurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientInsurance_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientInsurance_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientInsurance_InsuranceCompany_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientInsurance_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitCheckup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    HasResult = table.Column<bool>(nullable: false),
                    MedicalVisitId = table.Column<long>(nullable: false),
                    ResultId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitCheckup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckup_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckup_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckup_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckup_MedicalVisit_MedicalVisitId",
                        column: x => x.MedicalVisitId,
                        principalTable: "MedicalVisit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitCheckupResult",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CheckupId = table.Column<long>(nullable: false),
                    LabName = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    DoctorNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitCheckupResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResult_MedicalVisitCheckup_CheckupId",
                        column: x => x.CheckupId,
                        principalTable: "MedicalVisitCheckup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResult_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResult_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResult_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitCheckupResultFile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ResultId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitCheckupResultFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResultFile_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResultFile_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitCheckupResultFile_MedicalVisitCheckupResult_ResultId",
                        column: x => x.ResultId,
                        principalTable: "MedicalVisitCheckupResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitXRay",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MedicalVisitId = table.Column<long>(nullable: false),
                    ResultId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    HasResult = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitXRay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRay_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRay_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRay_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRay_MedicalVisit_MedicalVisitId",
                        column: x => x.MedicalVisitId,
                        principalTable: "MedicalVisit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitXRayResult",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    XRayId = table.Column<long>(nullable: false),
                    LabName = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    DoctorNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitXRayResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResult_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResult_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResult_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResult_MedicalVisitXRay_XRayId",
                        column: x => x.XRayId,
                        principalTable: "MedicalVisitXRay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisitXRayResultFile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ResultId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisitXRayResultFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResultFile_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResultFile_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalVisitXRayResultFile_MedicalVisitXRayResult_ResultId",
                        column: x => x.ResultId,
                        principalTable: "MedicalVisitXRayResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientBiomatric",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PainParecentage = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: true),
                    PatientProfileId = table.Column<long>(nullable: false),
                    MedicalVisitId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientBiomatric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientBiomatric_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBiomatric_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBiomatric_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBiomatric_MedicalVisit_MedicalVisitId",
                        column: x => x.MedicalVisitId,
                        principalTable: "MedicalVisit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientProfile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IdNumber = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ProfileNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HeightWeightLastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    HasHealthInsurance = table.Column<bool>(nullable: true),
                    PermanentTreatments = table.Column<string>(nullable: true),
                    DoctorId = table.Column<long>(nullable: false),
                    InsuranceId = table.Column<long>(nullable: true),
                    PatientAdditionalInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientProfile_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientProfile_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientProfile_PatientInsurance_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "PatientInsurance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientProfile_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientAdditionalInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    SocialStatus = table.Column<int>(nullable: false),
                    FamilyMembersCount = table.Column<int>(nullable: false),
                    FamilyIncome = table.Column<double>(nullable: false),
                    EducationalLevel = table.Column<int>(nullable: false),
                    Job = table.Column<string>(nullable: true),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAdditionalInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInfo_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInfo_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInfo_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInfo_PatientProfile_PatientProfileId",
                        column: x => x.PatientProfileId,
                        principalTable: "PatientProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientSurgery",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientSurgery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientSurgery_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSurgery_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSurgery_PatientProfile_PatientProfileId",
                        column: x => x.PatientProfileId,
                        principalTable: "PatientProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientTicketInClinic",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TicketNumber = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    PatientProfileId = table.Column<long>(nullable: false),
                    DoctorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTicketInClinic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientTicketInClinic_User_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientTicketInClinic_User_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientTicketInClinic_User_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientTicketInClinic_User_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientTicketInClinic_PatientProfile_PatientProfileId",
                        column: x => x.PatientProfileId,
                        principalTable: "PatientProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountSubTypeId",
                table: "Account",
                column: "AccountSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountContact_AccountId",
                table: "AccountContact",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountContact_CreatorUserId",
                table: "AccountContact",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountContact_DeleterUserId",
                table: "AccountContact",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountContact_LastModifierUserId",
                table: "AccountContact",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountPermission_AccountId",
                table: "AccountPermission",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountPermission_CreatorUserId",
                table: "AccountPermission",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountPermission_DeleterUserId",
                table: "AccountPermission",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountPermission_LastModifierUserId",
                table: "AccountPermission",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountPermission_PermissionId",
                table: "AccountPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountSubscriptionPlan_AccountId",
                table: "AccountSubscriptionPlan",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountSubscriptionPlan_CreatorUserId",
                table: "AccountSubscriptionPlan",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountSubscriptionPlan_DeleterUserId",
                table: "AccountSubscriptionPlan",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountSubscriptionPlan_LastModifierUserId",
                table: "AccountSubscriptionPlan",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountSubscriptionPlan_SubscriptionPlanId",
                table: "AccountSubscriptionPlan",
                column: "SubscriptionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergic_AccountId",
                table: "Allergic",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergic_CreatorUserId",
                table: "Allergic",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergic_DeleterUserId",
                table: "Allergic",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergic_LastModifierUserId",
                table: "Allergic",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_AccountId",
                table: "Bank",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CreatorUserId",
                table: "Bank",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_DeleterUserId",
                table: "Bank",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_LastModifierUserId",
                table: "Bank",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AccountId",
                table: "Complaint",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_CreatorUserId",
                table: "Complaint",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_DeleterUserId",
                table: "Complaint",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_LastModifierUserId",
                table: "Complaint",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_AccountId",
                table: "Diagnosis",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_CreatorUserId",
                table: "Diagnosis",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_DeleterUserId",
                table: "Diagnosis",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_LastModifierUserId",
                table: "Diagnosis",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Disease_AccountId",
                table: "Disease",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Disease_CreatorUserId",
                table: "Disease",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Disease_DeleterUserId",
                table: "Disease",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Disease_LastModifierUserId",
                table: "Disease",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_AccountId",
                table: "Hospital",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_CreatorUserId",
                table: "Hospital",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_DeleterUserId",
                table: "Hospital",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_LastModifierUserId",
                table: "Hospital",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalContact_CreatorUserId",
                table: "HospitalContact",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalContact_DeleterUserId",
                table: "HospitalContact",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalContact_HospitalId",
                table: "HospitalContact",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalContact_LastModifierUserId",
                table: "HospitalContact",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalVisit_CreatorUserId",
                table: "HospitalVisit",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalVisit_DcotorId",
                table: "HospitalVisit",
                column: "DcotorId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalVisit_DeleterUserId",
                table: "HospitalVisit",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalVisit_HospitalId",
                table: "HospitalVisit",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalVisit_LastModifierUserId",
                table: "HospitalVisit",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalVisit_PatientProfileId",
                table: "HospitalVisit",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_AccountId",
                table: "InsuranceCompany",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_CreatorUserId",
                table: "InsuranceCompany",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_DeleterUserId",
                table: "InsuranceCompany",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_LastModifierUserId",
                table: "InsuranceCompany",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompanyContact_CreatorUserId",
                table: "InsuranceCompanyContact",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompanyContact_DeleterUserId",
                table: "InsuranceCompanyContact",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompanyContact_InsuranceCompanyId",
                table: "InsuranceCompanyContact",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompanyContact_LastModifierUserId",
                table: "InsuranceCompanyContact",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisit_ComplaintId",
                table: "MedicalVisit",
                column: "ComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisit_CreatorUserId",
                table: "MedicalVisit",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisit_DeleterUserId",
                table: "MedicalVisit",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisit_DiagnosisId",
                table: "MedicalVisit",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisit_DoctorId",
                table: "MedicalVisit",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisit_LastModifierUserId",
                table: "MedicalVisit",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckup_CreatorUserId",
                table: "MedicalVisitCheckup",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckup_DeleterUserId",
                table: "MedicalVisitCheckup",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckup_LastModifierUserId",
                table: "MedicalVisitCheckup",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckup_MedicalVisitId",
                table: "MedicalVisitCheckup",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckup_ResultId",
                table: "MedicalVisitCheckup",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResult_CheckupId",
                table: "MedicalVisitCheckupResult",
                column: "CheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResult_CreatorUserId",
                table: "MedicalVisitCheckupResult",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResult_DeleterUserId",
                table: "MedicalVisitCheckupResult",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResult_LastModifierUserId",
                table: "MedicalVisitCheckupResult",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResultFile_CreatorUserId",
                table: "MedicalVisitCheckupResultFile",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResultFile_DeleterUserId",
                table: "MedicalVisitCheckupResultFile",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitCheckupResultFile_ResultId",
                table: "MedicalVisitCheckupResultFile",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaint_ComplaintId",
                table: "MedicalVisitComplaint",
                column: "ComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaint_CreatorUserId",
                table: "MedicalVisitComplaint",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaint_DeleterUserId",
                table: "MedicalVisitComplaint",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaint_LastModifierUserId",
                table: "MedicalVisitComplaint",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaint_MedicalVisitId",
                table: "MedicalVisitComplaint",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaintDetails_CreatorUserId",
                table: "MedicalVisitComplaintDetails",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaintDetails_DeleterUserId",
                table: "MedicalVisitComplaintDetails",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitComplaintDetails_LastModifierUserId",
                table: "MedicalVisitComplaintDetails",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitDiagnosis_CreatorUserId",
                table: "MedicalVisitDiagnosis",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitDiagnosis_DeleterUserId",
                table: "MedicalVisitDiagnosis",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitDiagnosis_DiagnosisId",
                table: "MedicalVisitDiagnosis",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitDiagnosis_LastModifierUserId",
                table: "MedicalVisitDiagnosis",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitDiagnosis_MedicalVisitId",
                table: "MedicalVisitDiagnosis",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitInsurance_CreatorUserId",
                table: "MedicalVisitInsurance",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitInsurance_DeleterUserId",
                table: "MedicalVisitInsurance",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitInsurance_LastModifierUserId",
                table: "MedicalVisitInsurance",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitInsurance_MedicalVisitId",
                table: "MedicalVisitInsurance",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitMedicine_CreatorUserId",
                table: "MedicalVisitMedicine",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitMedicine_DeleterUserId",
                table: "MedicalVisitMedicine",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitMedicine_LastModifierUserId",
                table: "MedicalVisitMedicine",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitMedicine_MedicalVisitId",
                table: "MedicalVisitMedicine",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitProcedure_AccountId",
                table: "MedicalVisitProcedure",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitProcedure_CreatorUserId",
                table: "MedicalVisitProcedure",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitProcedure_DeleterUserId",
                table: "MedicalVisitProcedure",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitProcedure_LastModifierUserId",
                table: "MedicalVisitProcedure",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRay_CreatorUserId",
                table: "MedicalVisitXRay",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRay_DeleterUserId",
                table: "MedicalVisitXRay",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRay_LastModifierUserId",
                table: "MedicalVisitXRay",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRay_MedicalVisitId",
                table: "MedicalVisitXRay",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRay_ResultId",
                table: "MedicalVisitXRay",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResult_CreatorUserId",
                table: "MedicalVisitXRayResult",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResult_DeleterUserId",
                table: "MedicalVisitXRayResult",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResult_LastModifierUserId",
                table: "MedicalVisitXRayResult",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResult_XRayId",
                table: "MedicalVisitXRayResult",
                column: "XRayId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResultFile_CreatorUserId",
                table: "MedicalVisitXRayResultFile",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResultFile_DeleterUserId",
                table: "MedicalVisitXRayResultFile",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalVisitXRayResultFile_ResultId",
                table: "MedicalVisitXRayResultFile",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInfo_CreatorUserId",
                table: "PatientAdditionalInfo",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInfo_DeleterUserId",
                table: "PatientAdditionalInfo",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInfo_LastModifierUserId",
                table: "PatientAdditionalInfo",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInfo_PatientProfileId",
                table: "PatientAdditionalInfo",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergic_AllergicId",
                table: "PatientAllergic",
                column: "AllergicId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergic_CreatorUserId",
                table: "PatientAllergic",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergic_DeleterUserId",
                table: "PatientAllergic",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergic_PatientProfileId",
                table: "PatientAllergic",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointment_CreatorUserId",
                table: "PatientAppointment",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointment_DeleterUserId",
                table: "PatientAppointment",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointment_DoctorId",
                table: "PatientAppointment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointment_LastModifierUserId",
                table: "PatientAppointment",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBiomatric_CreatorUserId",
                table: "PatientBiomatric",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBiomatric_DeleterUserId",
                table: "PatientBiomatric",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBiomatric_LastModifierUserId",
                table: "PatientBiomatric",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBiomatric_MedicalVisitId",
                table: "PatientBiomatric",
                column: "MedicalVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBiomatric_PatientProfileId",
                table: "PatientBiomatric",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFamilyDisease_CreatorUserId",
                table: "PatientFamilyDisease",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFamilyDisease_DeleterUserId",
                table: "PatientFamilyDisease",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFamilyDisease_DiseaseId",
                table: "PatientFamilyDisease",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFamilyDisease_PatientProfileId",
                table: "PatientFamilyDisease",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsurance_CreatorUserId",
                table: "PatientInsurance",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsurance_DeleterUserId",
                table: "PatientInsurance",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsurance_InsuranceCompanyId",
                table: "PatientInsurance",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsurance_LastModifierUserId",
                table: "PatientInsurance",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsurance_PatientProfileId",
                table: "PatientInsurance",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInternalDisease_CreatorUserId",
                table: "PatientInternalDisease",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInternalDisease_DeleterUserId",
                table: "PatientInternalDisease",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInternalDisease_DiseaseId",
                table: "PatientInternalDisease",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInternalDisease_PatientProfileId",
                table: "PatientInternalDisease",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalVisitProcedure_CreatorUserId",
                table: "PatientMedicalVisitProcedure",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalVisitProcedure_DeleterUserId",
                table: "PatientMedicalVisitProcedure",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalVisitProcedure_LastModifierUserId",
                table: "PatientMedicalVisitProcedure",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProfile_CreatorUserId",
                table: "PatientProfile",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProfile_DeleterUserId",
                table: "PatientProfile",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProfile_InsuranceId",
                table: "PatientProfile",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProfile_LastModifierUserId",
                table: "PatientProfile",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProfile_PatientAdditionalInfoId",
                table: "PatientProfile",
                column: "PatientAdditionalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgery_CreatorUserId",
                table: "PatientSurgery",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgery_DeleterUserId",
                table: "PatientSurgery",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgery_PatientProfileId",
                table: "PatientSurgery",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgicalDisease_CreatorUserId",
                table: "PatientSurgicalDisease",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgicalDisease_DeleterUserId",
                table: "PatientSurgicalDisease",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgicalDisease_DiseaseId",
                table: "PatientSurgicalDisease",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSurgicalDisease_PatientProfileId",
                table: "PatientSurgicalDisease",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTicketInClinic_CreatorUserId",
                table: "PatientTicketInClinic",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTicketInClinic_DeleterUserId",
                table: "PatientTicketInClinic",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTicketInClinic_DoctorId",
                table: "PatientTicketInClinic",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTicketInClinic_LastModifierUserId",
                table: "PatientTicketInClinic",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTicketInClinic_PatientProfileId",
                table: "PatientTicketInClinic",
                column: "PatientProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_CreatorUserId",
                table: "Permission",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_DeleterUserId",
                table: "Permission",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_LastModifierUserId",
                table: "Permission",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountSubType_AccountSubTypeId",
                table: "PermissionAccountSubType",
                column: "AccountSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountSubType_CreatorUserId",
                table: "PermissionAccountSubType",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountSubType_DeleterUserId",
                table: "PermissionAccountSubType",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountSubType_LastModifierUserId",
                table: "PermissionAccountSubType",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountSubType_PermissionId",
                table: "PermissionAccountSubType",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountType_AccountTypeId",
                table: "PermissionAccountType",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountType_CreatorUserId",
                table: "PermissionAccountType",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountType_DeleterUserId",
                table: "PermissionAccountType",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountType_LastModifierUserId",
                table: "PermissionAccountType",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionAccountType_PermissionId",
                table: "PermissionAccountType",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_AccountId",
                table: "SurgeriesProcedures",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_CreatorUserId",
                table: "SurgeriesProcedures",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_DeleterUserId",
                table: "SurgeriesProcedures",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_LastModifierUserId",
                table: "SurgeriesProcedures",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_SurgeryId",
                table: "SurgeriesProcedures",
                column: "SurgeryId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_SurgeryProcedureId",
                table: "SurgeriesProcedures",
                column: "SurgeryProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeriesProcedures_SystemSurgeryProcedureId",
                table: "SurgeriesProcedures",
                column: "SystemSurgeryProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgery_AccountId",
                table: "Surgery",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgery_CreatorUserId",
                table: "Surgery",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgery_DeleterUserId",
                table: "Surgery",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgery_LastModifierUserId",
                table: "Surgery",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryProcedure_AccountId",
                table: "SurgeryProcedure",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryProcedure_CreatorUserId",
                table: "SurgeryProcedure",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryProcedure_DeleterUserId",
                table: "SurgeryProcedure",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryProcedure_LastModifierUserId",
                table: "SurgeryProcedure",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountSubType_AccountTypeId",
                table: "SystemAccountSubType",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountSubType_CreatorUserId",
                table: "SystemAccountSubType",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountSubType_DeleterUserId",
                table: "SystemAccountSubType",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountSubType_LastModifierUserId",
                table: "SystemAccountSubType",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountType_CreatorUserId",
                table: "SystemAccountType",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountType_DeleterUserId",
                table: "SystemAccountType",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountType_LastModifierUserId",
                table: "SystemAccountType",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccountType_SystemSubscriptionPlanId",
                table: "SystemAccountType",
                column: "SystemSubscriptionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAllergic_CreatorUserId",
                table: "SystemAllergic",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAllergic_DeleterUserId",
                table: "SystemAllergic",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAllergic_LastModifierUserId",
                table: "SystemAllergic",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemBank_CreatorUserId",
                table: "SystemBank",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemBank_DeleterUserId",
                table: "SystemBank",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemBank_LastModifierUserId",
                table: "SystemBank",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemComplaint_CreatorUserId",
                table: "SystemComplaint",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemComplaint_DeleterUserId",
                table: "SystemComplaint",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemComplaint_LastModifierUserId",
                table: "SystemComplaint",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemDiagnosis_CreatorUserId",
                table: "SystemDiagnosis",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemDiagnosis_DeleterUserId",
                table: "SystemDiagnosis",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemDiagnosis_LastModifierUserId",
                table: "SystemDiagnosis",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemDisease_CreatorUserId",
                table: "SystemDisease",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemDisease_DeleterUserId",
                table: "SystemDisease",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemDisease_LastModifierUserId",
                table: "SystemDisease",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMedicalVisitProcedure_CreatorUserId",
                table: "SystemMedicalVisitProcedure",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMedicalVisitProcedure_DeleterUserId",
                table: "SystemMedicalVisitProcedure",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMedicalVisitProcedure_LastModifierUserId",
                table: "SystemMedicalVisitProcedure",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionDuration_CreatorUserId",
                table: "SystemSubscriptionDuration",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionDuration_DeleterUserId",
                table: "SystemSubscriptionDuration",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionDuration_LastModifierUserId",
                table: "SystemSubscriptionDuration",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionDuration_SubscriptionPlanId",
                table: "SystemSubscriptionDuration",
                column: "SubscriptionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionPlan_CreatorUserId",
                table: "SystemSubscriptionPlan",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionPlan_DeleterUserId",
                table: "SystemSubscriptionPlan",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSubscriptionPlan_LastModifierUserId",
                table: "SystemSubscriptionPlan",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeriesProcedures_CreatorUserId",
                table: "SystemSurgeriesProcedures",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeriesProcedures_DeleterUserId",
                table: "SystemSurgeriesProcedures",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeriesProcedures_LastModifierUserId",
                table: "SystemSurgeriesProcedures",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeriesProcedures_SurgeryId",
                table: "SystemSurgeriesProcedures",
                column: "SurgeryId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeriesProcedures_SurgeryProcedureId",
                table: "SystemSurgeriesProcedures",
                column: "SurgeryProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgery_CreatorUserId",
                table: "SystemSurgery",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgery_DeleterUserId",
                table: "SystemSurgery",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgery_LastModifierUserId",
                table: "SystemSurgery",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeryProcedure_CreatorUserId",
                table: "SystemSurgeryProcedure",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeryProcedure_DeleterUserId",
                table: "SystemSurgeryProcedure",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSurgeryProcedure_LastModifierUserId",
                table: "SystemSurgeryProcedure",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountId",
                table: "User",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountId1",
                table: "User",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatorUserId",
                table: "User",
                column: "CreatorUserId",
                unique: true,
                filter: "[CreatorUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_DeleterUserId",
                table: "User",
                column: "DeleterUserId",
                unique: true,
                filter: "[DeleterUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_LastModifierUserId",
                table: "User",
                column: "LastModifierUserId",
                unique: true,
                filter: "[LastModifierUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountContact_Account_AccountId",
                table: "AccountContact",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountContact_User_CreatorUserId",
                table: "AccountContact",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountContact_User_DeleterUserId",
                table: "AccountContact",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountContact_User_LastModifierUserId",
                table: "AccountContact",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountPermission_Account_AccountId",
                table: "AccountPermission",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountPermission_User_CreatorUserId",
                table: "AccountPermission",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountPermission_User_DeleterUserId",
                table: "AccountPermission",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountPermission_User_LastModifierUserId",
                table: "AccountPermission",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountPermission_Permission_PermissionId",
                table: "AccountPermission",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSubscriptionPlan_Account_AccountId",
                table: "AccountSubscriptionPlan",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSubscriptionPlan_User_CreatorUserId",
                table: "AccountSubscriptionPlan",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSubscriptionPlan_User_DeleterUserId",
                table: "AccountSubscriptionPlan",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSubscriptionPlan_User_LastModifierUserId",
                table: "AccountSubscriptionPlan",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSubscriptionPlan_SystemSubscriptionPlan_SubscriptionPlanId",
                table: "AccountSubscriptionPlan",
                column: "SubscriptionPlanId",
                principalTable: "SystemSubscriptionPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Allergic_Account_AccountId",
                table: "Allergic",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Allergic_User_CreatorUserId",
                table: "Allergic",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Allergic_User_DeleterUserId",
                table: "Allergic",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Allergic_User_LastModifierUserId",
                table: "Allergic",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Account_AccountId",
                table: "Bank",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_CreatorUserId",
                table: "Bank",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_DeleterUserId",
                table: "Bank",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_LastModifierUserId",
                table: "Bank",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Account_AccountId",
                table: "Complaint",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_User_CreatorUserId",
                table: "Complaint",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_User_DeleterUserId",
                table: "Complaint",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_User_LastModifierUserId",
                table: "Complaint",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_Account_AccountId",
                table: "Diagnosis",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_User_CreatorUserId",
                table: "Diagnosis",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_User_DeleterUserId",
                table: "Diagnosis",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_User_LastModifierUserId",
                table: "Diagnosis",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disease_Account_AccountId",
                table: "Disease",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disease_User_CreatorUserId",
                table: "Disease",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disease_User_DeleterUserId",
                table: "Disease",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disease_User_LastModifierUserId",
                table: "Disease",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_Account_AccountId",
                table: "Hospital",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_User_CreatorUserId",
                table: "Hospital",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_User_DeleterUserId",
                table: "Hospital",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_User_LastModifierUserId",
                table: "Hospital",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompany_Account_AccountId",
                table: "InsuranceCompany",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompany_User_CreatorUserId",
                table: "InsuranceCompany",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompany_User_DeleterUserId",
                table: "InsuranceCompany",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompany_User_LastModifierUserId",
                table: "InsuranceCompany",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitProcedure_Account_AccountId",
                table: "MedicalVisitProcedure",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitProcedure_User_CreatorUserId",
                table: "MedicalVisitProcedure",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitProcedure_User_DeleterUserId",
                table: "MedicalVisitProcedure",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitProcedure_User_LastModifierUserId",
                table: "MedicalVisitProcedure",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_Account_AccountId",
                table: "SurgeriesProcedures",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_User_CreatorUserId",
                table: "SurgeriesProcedures",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_User_DeleterUserId",
                table: "SurgeriesProcedures",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_User_LastModifierUserId",
                table: "SurgeriesProcedures",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_Surgery_SurgeryId",
                table: "SurgeriesProcedures",
                column: "SurgeryId",
                principalTable: "Surgery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_SurgeryProcedure_SurgeryProcedureId",
                table: "SurgeriesProcedures",
                column: "SurgeryProcedureId",
                principalTable: "SurgeryProcedure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeriesProcedures_SystemSurgeryProcedure_SystemSurgeryProcedureId",
                table: "SurgeriesProcedures",
                column: "SystemSurgeryProcedureId",
                principalTable: "SystemSurgeryProcedure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surgery_Account_AccountId",
                table: "Surgery",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Surgery_User_CreatorUserId",
                table: "Surgery",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surgery_User_DeleterUserId",
                table: "Surgery",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surgery_User_LastModifierUserId",
                table: "Surgery",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeryProcedure_Account_AccountId",
                table: "SurgeryProcedure",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeryProcedure_User_CreatorUserId",
                table: "SurgeryProcedure",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeryProcedure_User_DeleterUserId",
                table: "SurgeryProcedure",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgeryProcedure_User_LastModifierUserId",
                table: "SurgeryProcedure",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Account_AccountId",
                table: "User",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Account_AccountId1",
                table: "User",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergic_PatientProfile_PatientProfileId",
                table: "PatientAllergic",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitComplaint_MedicalVisit_MedicalVisitId",
                table: "MedicalVisitComplaint",
                column: "MedicalVisitId",
                principalTable: "MedicalVisit",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitDiagnosis_MedicalVisit_MedicalVisitId",
                table: "MedicalVisitDiagnosis",
                column: "MedicalVisitId",
                principalTable: "MedicalVisit",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientFamilyDisease_PatientProfile_PatientProfileId",
                table: "PatientFamilyDisease",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInternalDisease_PatientProfile_PatientProfileId",
                table: "PatientInternalDisease",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSurgicalDisease_PatientProfile_PatientProfileId",
                table: "PatientSurgicalDisease",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalVisit_PatientProfile_PatientProfileId",
                table: "HospitalVisit",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsurance_PatientProfile_PatientProfileId",
                table: "PatientInsurance",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitCheckup_MedicalVisitCheckupResult_ResultId",
                table: "MedicalVisitCheckup",
                column: "ResultId",
                principalTable: "MedicalVisitCheckupResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisitXRay_MedicalVisitXRayResult_ResultId",
                table: "MedicalVisitXRay",
                column: "ResultId",
                principalTable: "MedicalVisitXRayResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientBiomatric_PatientProfile_PatientProfileId",
                table: "PatientBiomatric",
                column: "PatientProfileId",
                principalTable: "PatientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientProfile_PatientAdditionalInfo_PatientAdditionalInfoId",
                table: "PatientProfile",
                column: "PatientAdditionalInfoId",
                principalTable: "PatientAdditionalInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_SystemAccountSubType_AccountSubTypeId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_SystemAccountType_AccountTypeId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_Account_AccountId",
                table: "Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompany_Account_AccountId",
                table: "InsuranceCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Account_AccountId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Account_AccountId1",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_User_CreatorUserId",
                table: "Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_User_DeleterUserId",
                table: "Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_User_LastModifierUserId",
                table: "Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompany_User_CreatorUserId",
                table: "InsuranceCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompany_User_DeleterUserId",
                table: "InsuranceCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompany_User_LastModifierUserId",
                table: "InsuranceCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_User_CreatorUserId",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_User_DeleterUserId",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_User_DoctorId",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_User_LastModifierUserId",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckup_User_CreatorUserId",
                table: "MedicalVisitCheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckup_User_DeleterUserId",
                table: "MedicalVisitCheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckup_User_LastModifierUserId",
                table: "MedicalVisitCheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckupResult_User_CreatorUserId",
                table: "MedicalVisitCheckupResult");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckupResult_User_DeleterUserId",
                table: "MedicalVisitCheckupResult");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckupResult_User_LastModifierUserId",
                table: "MedicalVisitCheckupResult");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitComplaintDetails_User_CreatorUserId",
                table: "MedicalVisitComplaintDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitComplaintDetails_User_DeleterUserId",
                table: "MedicalVisitComplaintDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitComplaintDetails_User_LastModifierUserId",
                table: "MedicalVisitComplaintDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitDiagnosis_User_CreatorUserId",
                table: "MedicalVisitDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitDiagnosis_User_DeleterUserId",
                table: "MedicalVisitDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitDiagnosis_User_LastModifierUserId",
                table: "MedicalVisitDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRay_User_CreatorUserId",
                table: "MedicalVisitXRay");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRay_User_DeleterUserId",
                table: "MedicalVisitXRay");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRay_User_LastModifierUserId",
                table: "MedicalVisitXRay");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRayResult_User_CreatorUserId",
                table: "MedicalVisitXRayResult");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRayResult_User_DeleterUserId",
                table: "MedicalVisitXRayResult");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRayResult_User_LastModifierUserId",
                table: "MedicalVisitXRayResult");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAdditionalInfo_User_CreatorUserId",
                table: "PatientAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAdditionalInfo_User_DeleterUserId",
                table: "PatientAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAdditionalInfo_User_LastModifierUserId",
                table: "PatientAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsurance_User_CreatorUserId",
                table: "PatientInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsurance_User_DeleterUserId",
                table: "PatientInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsurance_User_LastModifierUserId",
                table: "PatientInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientProfile_User_CreatorUserId",
                table: "PatientProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientProfile_User_DeleterUserId",
                table: "PatientProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientProfile_User_LastModifierUserId",
                table: "PatientProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAdditionalInfo_PatientProfile_PatientProfileId",
                table: "PatientAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsurance_PatientProfile_PatientProfileId",
                table: "PatientInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_MedicalVisitComplaintDetails_ComplaintId",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_MedicalVisitDiagnosis_DiagnosisId",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckup_MedicalVisit_MedicalVisitId",
                table: "MedicalVisitCheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRay_MedicalVisit_MedicalVisitId",
                table: "MedicalVisitXRay");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitCheckup_MedicalVisitCheckupResult_ResultId",
                table: "MedicalVisitCheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisitXRay_MedicalVisitXRayResult_ResultId",
                table: "MedicalVisitXRay");

            migrationBuilder.DropTable(
                name: "AccountContact");

            migrationBuilder.DropTable(
                name: "AccountPermission");

            migrationBuilder.DropTable(
                name: "AccountSubscriptionPlan");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "HospitalContact");

            migrationBuilder.DropTable(
                name: "HospitalVisit");

            migrationBuilder.DropTable(
                name: "InsuranceCompanyContact");

            migrationBuilder.DropTable(
                name: "MedicalVisitCheckupResultFile");

            migrationBuilder.DropTable(
                name: "MedicalVisitComplaint");

            migrationBuilder.DropTable(
                name: "MedicalVisitInsurance");

            migrationBuilder.DropTable(
                name: "MedicalVisitMedicine");

            migrationBuilder.DropTable(
                name: "MedicalVisitProcedure");

            migrationBuilder.DropTable(
                name: "MedicalVisitXRayResultFile");

            migrationBuilder.DropTable(
                name: "PatientAllergic");

            migrationBuilder.DropTable(
                name: "PatientAppointment");

            migrationBuilder.DropTable(
                name: "PatientBiomatric");

            migrationBuilder.DropTable(
                name: "PatientFamilyDisease");

            migrationBuilder.DropTable(
                name: "PatientInternalDisease");

            migrationBuilder.DropTable(
                name: "PatientMedicalVisitProcedure");

            migrationBuilder.DropTable(
                name: "PatientSurgery");

            migrationBuilder.DropTable(
                name: "PatientSurgicalDisease");

            migrationBuilder.DropTable(
                name: "PatientTicketInClinic");

            migrationBuilder.DropTable(
                name: "PermissionAccountSubType");

            migrationBuilder.DropTable(
                name: "PermissionAccountType");

            migrationBuilder.DropTable(
                name: "SurgeriesProcedures");

            migrationBuilder.DropTable(
                name: "SystemAllergic");

            migrationBuilder.DropTable(
                name: "SystemBank");

            migrationBuilder.DropTable(
                name: "SystemComplaint");

            migrationBuilder.DropTable(
                name: "SystemDiagnosis");

            migrationBuilder.DropTable(
                name: "SystemDisease");

            migrationBuilder.DropTable(
                name: "SystemMedicalVisitProcedure");

            migrationBuilder.DropTable(
                name: "SystemSubscriptionDuration");

            migrationBuilder.DropTable(
                name: "SystemSurgeriesProcedures");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "Allergic");

            migrationBuilder.DropTable(
                name: "Disease");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Surgery");

            migrationBuilder.DropTable(
                name: "SurgeryProcedure");

            migrationBuilder.DropTable(
                name: "SystemSurgery");

            migrationBuilder.DropTable(
                name: "SystemSurgeryProcedure");

            migrationBuilder.DropTable(
                name: "SystemAccountSubType");

            migrationBuilder.DropTable(
                name: "SystemAccountType");

            migrationBuilder.DropTable(
                name: "SystemSubscriptionPlan");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PatientProfile");

            migrationBuilder.DropTable(
                name: "PatientInsurance");

            migrationBuilder.DropTable(
                name: "PatientAdditionalInfo");

            migrationBuilder.DropTable(
                name: "InsuranceCompany");

            migrationBuilder.DropTable(
                name: "MedicalVisitComplaintDetails");

            migrationBuilder.DropTable(
                name: "MedicalVisitDiagnosis");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "MedicalVisit");

            migrationBuilder.DropTable(
                name: "MedicalVisitCheckupResult");

            migrationBuilder.DropTable(
                name: "MedicalVisitCheckup");

            migrationBuilder.DropTable(
                name: "MedicalVisitXRayResult");

            migrationBuilder.DropTable(
                name: "MedicalVisitXRay");
        }
    }
}
