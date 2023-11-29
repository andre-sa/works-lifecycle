using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_AcademicYears_EnrollmentCompletedFK",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_AcademicYears_EnrollmentStartedFK",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Courses_CourseFK",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Persons_StudentFK",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposals_Persons_AdvisorId",
                table: "Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Proposals_AdvisorId",
                table: "Proposals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "AdvisorId",
                table: "Proposals");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                newName: "Enrollments");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_StudentFK",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentFK");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_EnrollmentStartedFK",
                table: "Enrollments",
                newName: "IX_Enrollments_EnrollmentStartedFK");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_EnrollmentCompletedFK",
                table: "Enrollments",
                newName: "IX_Enrollments_EnrollmentCompletedFK");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_CourseFK",
                table: "Enrollments",
                newName: "IX_Enrollments_CourseFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdvisorProposal",
                columns: table => new
                {
                    AdvisorsId = table.Column<int>(type: "int", nullable: false),
                    ProposalsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvisorProposal", x => new { x.AdvisorsId, x.ProposalsId });
                    table.ForeignKey(
                        name: "FK_AdvisorProposal_Persons_AdvisorsId",
                        column: x => x.AdvisorsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvisorProposal_Proposals_ProposalsId",
                        column: x => x.ProposalsId,
                        principalTable: "Proposals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsValidations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Validated = table.Column<bool>(type: "bit", nullable: false),
                    ValidationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonFK = table.Column<int>(type: "int", nullable: false),
                    ProjectFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsValidations_Persons_PersonFK",
                        column: x => x.PersonFK,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectsValidations_Projects_ProjectFK",
                        column: x => x.ProjectFK,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvisorProposal_ProposalsId",
                table: "AdvisorProposal",
                column: "ProposalsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsValidations_PersonFK",
                table: "ProjectsValidations",
                column: "PersonFK");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsValidations_ProjectFK",
                table: "ProjectsValidations",
                column: "ProjectFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_AcademicYears_EnrollmentCompletedFK",
                table: "Enrollments",
                column: "EnrollmentCompletedFK",
                principalTable: "AcademicYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_AcademicYears_EnrollmentStartedFK",
                table: "Enrollments",
                column: "EnrollmentStartedFK",
                principalTable: "AcademicYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Persons_StudentFK",
                table: "Enrollments",
                column: "StudentFK",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_AcademicYears_EnrollmentCompletedFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_AcademicYears_EnrollmentStartedFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Persons_StudentFK",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "AdvisorProposal");

            migrationBuilder.DropTable(
                name: "ProjectsValidations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "Enrollment");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentFK",
                table: "Enrollment",
                newName: "IX_Enrollment_StudentFK");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_EnrollmentStartedFK",
                table: "Enrollment",
                newName: "IX_Enrollment_EnrollmentStartedFK");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_EnrollmentCompletedFK",
                table: "Enrollment",
                newName: "IX_Enrollment_EnrollmentCompletedFK");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_CourseFK",
                table: "Enrollment",
                newName: "IX_Enrollment_CourseFK");

            migrationBuilder.AddColumn<int>(
                name: "AdvisorId",
                table: "Proposals",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_AdvisorId",
                table: "Proposals",
                column: "AdvisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_AcademicYears_EnrollmentCompletedFK",
                table: "Enrollment",
                column: "EnrollmentCompletedFK",
                principalTable: "AcademicYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_AcademicYears_EnrollmentStartedFK",
                table: "Enrollment",
                column: "EnrollmentStartedFK",
                principalTable: "AcademicYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Courses_CourseFK",
                table: "Enrollment",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Persons_StudentFK",
                table: "Enrollment",
                column: "StudentFK",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposals_Persons_AdvisorId",
                table: "Proposals",
                column: "AdvisorId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
