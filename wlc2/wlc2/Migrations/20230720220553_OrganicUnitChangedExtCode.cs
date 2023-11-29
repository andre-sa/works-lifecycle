using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class OrganicUnitChangedExtCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExternalCode",
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
                values: new object[] { "a5076b4b-2619-4e9f-a348-28022a684f51", "AQAAAAIAAYagAAAAEGj/o4o5dIOYwV+EkJHc2ohqxVazW8fi8OZOnRA9TMX2RNPEe0ogyVm50t0WCGWyIw==", "127066d8-46ea-42f9-b6c6-a2c4be7d9de3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExternalCode",
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
                values: new object[] { "8d7df042-ed02-46e7-9357-314129546d1a", "AQAAAAIAAYagAAAAEGQVtvnsuFaq/LBzEX5vu1ODpwVEM8Mh7Lqbl6IF9oCWL100ZjMDjaaGDqxmiFN2gQ==", "6956be07-c819-48c9-b131-a6e8938b6467" });
        }
    }
}
