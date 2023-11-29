using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class OrganicUnitChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Abbreviation",
                table: "OrganicUnits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d7df042-ed02-46e7-9357-314129546d1a", "AQAAAAIAAYagAAAAEGQVtvnsuFaq/LBzEX5vu1ODpwVEM8Mh7Lqbl6IF9oCWL100ZjMDjaaGDqxmiFN2gQ==", "6956be07-c819-48c9-b131-a6e8938b6467" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Abbreviation",
                table: "OrganicUnits",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dbca57d-7b78-4b97-b891-3d20219a6237", "AQAAAAIAAYagAAAAEHNbKsXc7SBwtOvsBbYdbWGewDO3O5UQV+CSvAQpPVPfihp+VyOicy7Kwft6rlDm9g==", "9fbb8f34-662d-41d0-bffb-380824757c28" });
        }
    }
}
