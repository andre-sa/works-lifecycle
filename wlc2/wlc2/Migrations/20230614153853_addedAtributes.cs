using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class addedAtributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProposalStudent_Persons_StudentsId",
                table: "ProposalStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProposalStudent_Proposals_ProposalsId",
                table: "ProposalStudent");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "JuryMembers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "ProposalStudent",
                newName: "ProponentStudentsId");

            migrationBuilder.RenameColumn(
                name: "ProposalsId",
                table: "ProposalStudent",
                newName: "AutoProposalsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProposalStudent_StudentsId",
                table: "ProposalStudent",
                newName: "IX_ProposalStudent_ProponentStudentsId");

            migrationBuilder.RenameColumn(
                name: "Abstract",
                table: "Projects",
                newName: "AbstractPT");

            migrationBuilder.RenameColumn(
                name: "PHD",
                table: "Persons",
                newName: "PhD");

            migrationBuilder.RenameColumn(
                name: "Abreviation",
                table: "OrganicUnits",
                newName: "Abbreviation");

            migrationBuilder.AddColumn<int>(
                name: "ProposalStatus",
                table: "Proposals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AbstractEN",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatus",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Sex",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JuryMemberRole",
                table: "JuryMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationStatus",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentStatus = table.Column<int>(type: "int", nullable: false),
                    ECTS = table.Column<int>(type: "int", nullable: false),
                    EnrollmentStartedFK = table.Column<int>(type: "int", nullable: false),
                    EnrollmentCompletedFK = table.Column<int>(type: "int", nullable: false),
                    StudentFK = table.Column<int>(type: "int", nullable: false),
                    CourseFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollment_AcademicYears_EnrollmentCompletedFK",
                        column: x => x.EnrollmentCompletedFK,
                        principalTable: "AcademicYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_AcademicYears_EnrollmentStartedFK",
                        column: x => x.EnrollmentStartedFK,
                        principalTable: "AcademicYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollment_Courses_CourseFK",
                        column: x => x.CourseFK,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Persons_StudentFK",
                        column: x => x.StudentFK,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseFK",
                table: "Enrollment",
                column: "CourseFK");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_EnrollmentCompletedFK",
                table: "Enrollment",
                column: "EnrollmentCompletedFK");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_EnrollmentStartedFK",
                table: "Enrollment",
                column: "EnrollmentStartedFK");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentFK",
                table: "Enrollment",
                column: "StudentFK");

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalStudent_Persons_ProponentStudentsId",
                table: "ProposalStudent",
                column: "ProponentStudentsId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalStudent_Proposals_AutoProposalsId",
                table: "ProposalStudent",
                column: "AutoProposalsId",
                principalTable: "Proposals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProposalStudent_Persons_ProponentStudentsId",
                table: "ProposalStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProposalStudent_Proposals_AutoProposalsId",
                table: "ProposalStudent");

            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropColumn(
                name: "ProposalStatus",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "AbstractEN",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStatus",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "JuryMemberRole",
                table: "JuryMembers");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ApplicationStatus",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "ProponentStudentsId",
                table: "ProposalStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "AutoProposalsId",
                table: "ProposalStudent",
                newName: "ProposalsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProposalStudent_ProponentStudentsId",
                table: "ProposalStudent",
                newName: "IX_ProposalStudent_StudentsId");

            migrationBuilder.RenameColumn(
                name: "AbstractPT",
                table: "Projects",
                newName: "Abstract");

            migrationBuilder.RenameColumn(
                name: "PhD",
                table: "Persons",
                newName: "PHD");

            migrationBuilder.RenameColumn(
                name: "Abbreviation",
                table: "OrganicUnits",
                newName: "Abreviation");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Proposals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JuryRole",
                table: "JuryMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Persons_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalStudent_Persons_StudentsId",
                table: "ProposalStudent",
                column: "StudentsId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalStudent_Proposals_ProposalsId",
                table: "ProposalStudent",
                column: "ProposalsId",
                principalTable: "Proposals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
