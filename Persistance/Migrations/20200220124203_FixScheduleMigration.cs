using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class FixScheduleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonContactTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonContactTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PathId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paths_Courses_PathId",
                        column: x => x.PathId,
                        principalTable: "Paths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    PersonNo = table.Column<string>(nullable: true),
                    IdentityNo = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstNameEn = table.Column<string>(nullable: false),
                    LastNameEn = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    PersonTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonType_People_PersonTypeId",
                        column: x => x.PersonTypeId,
                        principalTable: "PersonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    ScheduleId = table.Column<int>(nullable: false),
                    Presence = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonSchedules_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Groups_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Subjects_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddresss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    PersonId = table.Column<int>(nullable: false),
                    PersonAddressTypeId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddresss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonAddressTypes_PersonAddresses_PersonAddressTypeId",
                        column: x => x.PersonAddressTypeId,
                        principalTable: "PersonAddressTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_PersonContacts_PathId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonBankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    PersonId = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banks_PersonBankAccounts_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_PersonBankAccounts_PathId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    PersonContactTypetId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    Contact = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonContactTypes_PersonContacts_PersonContactTypeId",
                        column: x => x.PersonContactTypetId,
                        principalTable: "PersonContactTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_PersonContacts_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPersonStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    PersonId = table.Column<int>(nullable: false),
                    PersonStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPersonStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_PersonPersonStatuses_PathId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonStatus_StatusPeople_PersonStatusId",
                        column: x => x.PersonStatusId,
                        principalTable: "PersonStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchedulePersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    PersonId = table.Column<int>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false),
                    PersonStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulePersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_SchedulePeople_PathId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonStatus_SchedulePeople_PersonStatusId",
                        column: x => x.PersonStatusId,
                        principalTable: "PersonStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_SchedulePeople_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupPersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    GroupId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    PersonStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_GroupAttendents_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_GroupPeople_PathId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonStatuses_GroupPeople_PersonStatusId",
                        column: x => x.PersonStatusId,
                        principalTable: "PersonStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateCustomerId = table.Column<int>(nullable: true),
                    CreateAppId = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifiedCustomerId = table.Column<int>(nullable: true),
                    LastModifiedAppId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(nullable: false, defaultValue: false),
                    SubjectId = table.Column<int>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectSchedules_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectSchedules_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PathId",
                table: "Courses",
                column: "PathId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPersons_GroupId",
                table: "GroupPersons",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPersons_PersonId",
                table: "GroupPersons",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPersons_PersonStatusId",
                table: "GroupPersons",
                column: "PersonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CourseId",
                table: "Groups",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonTypeId",
                table: "People",
                column: "PersonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddresss_PersonAddressTypeId",
                table: "PersonAddresss",
                column: "PersonAddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddresss_PersonId",
                table: "PersonAddresss",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonBankAccounts_BankId",
                table: "PersonBankAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonBankAccounts_PersonId",
                table: "PersonBankAccounts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonContacts_PersonContactTypetId",
                table: "PersonContacts",
                column: "PersonContactTypetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonContacts_PersonId",
                table: "PersonContacts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPersonStatuses_PersonId",
                table: "PersonPersonStatuses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPersonStatuses_PersonStatusId",
                table: "PersonPersonStatuses",
                column: "PersonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSchedules_ScheduleId",
                table: "PersonSchedules",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulePersons_PersonId",
                table: "SchedulePersons",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulePersons_PersonStatusId",
                table: "SchedulePersons",
                column: "PersonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulePersons_ScheduleId",
                table: "SchedulePersons",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_CourseId",
                table: "Subject",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSchedules_ScheduleId",
                table: "SubjectSchedules",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSchedules_SubjectId",
                table: "SubjectSchedules",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupPersons");

            migrationBuilder.DropTable(
                name: "PersonAddresss");

            migrationBuilder.DropTable(
                name: "PersonBankAccounts");

            migrationBuilder.DropTable(
                name: "PersonContacts");

            migrationBuilder.DropTable(
                name: "PersonPersonStatuses");

            migrationBuilder.DropTable(
                name: "PersonSchedules");

            migrationBuilder.DropTable(
                name: "SchedulePersons");

            migrationBuilder.DropTable(
                name: "SubjectSchedules");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "PersonAddressTypes");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "PersonContactTypes");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "PersonStatuses");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "PersonTypes");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Paths");
        }
    }
}
