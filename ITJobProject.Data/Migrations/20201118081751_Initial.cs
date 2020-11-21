using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITJobProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<Guid>(nullable: false),
                    AdminName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Introduction = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    WorkingDay = table.Column<string>(nullable: true),
                    CompanySize = table.Column<int>(nullable: false),
                    TypeBusiness = table.Column<int>(nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<Guid>(nullable: false),
                    LanguageName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "RecruiterLevels",
                columns: table => new
                {
                    RecruiterLevelId = table.Column<Guid>(nullable: false),
                    RecruiterLevelName = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PostNumber = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruiterLevels", x => x.RecruiterLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Seekers",
                columns: table => new
                {
                    SeekerId = table.Column<Guid>(nullable: false),
                    SeekerName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seekers", x => x.SeekerId);
                });

            migrationBuilder.CreateTable(
                name: "Recruiters",
                columns: table => new
                {
                    RecruiterId = table.Column<Guid>(nullable: false),
                    RecruiterName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    RecruiterLevelId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiters", x => x.RecruiterId);
                    table.ForeignKey(
                        name: "FK_Recruiters_RecruiterLevels_RecruiterLevelId",
                        column: x => x.RecruiterLevelId,
                        principalTable: "RecruiterLevels",
                        principalColumn: "RecruiterLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<Guid>(nullable: false),
                    JobName = table.Column<string>(nullable: false),
                    Possition = table.Column<string>(nullable: true),
                    LanguageId = table.Column<Guid>(nullable: false),
                    Require = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    StartDateApply = table.Column<DateTime>(nullable: false),
                    EndDateApply = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: false),
                    AdminId = table.Column<Guid>(nullable: false),
                    RecruiterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Jobs_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_Recruiters_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiters",
                        principalColumn: "RecruiterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeekerJobs",
                columns: table => new
                {
                    SeekerId = table.Column<Guid>(nullable: false),
                    JobId = table.Column<Guid>(nullable: false),
                    ApplyDate = table.Column<DateTime>(nullable: false),
                    CVLink = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "TDNAM"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeekerJobs", x => new { x.SeekerId, x.JobId });
                    table.ForeignKey(
                        name: "FK_SeekerJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeekerJobs_Seekers_SeekerId",
                        column: x => x.SeekerId,
                        principalTable: "Seekers",
                        principalColumn: "SeekerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_AdminId",
                table: "Jobs",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyId",
                table: "Jobs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_LanguageId",
                table: "Jobs",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_RecruiterId",
                table: "Jobs",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Recruiters_RecruiterLevelId",
                table: "Recruiters",
                column: "RecruiterLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerJobs_JobId",
                table: "SeekerJobs",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeekerJobs");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Seekers");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Recruiters");

            migrationBuilder.DropTable(
                name: "RecruiterLevels");
        }
    }
}
