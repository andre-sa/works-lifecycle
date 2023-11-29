using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminToRoleAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IdentificationTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "IdentificationTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin", "0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5821c396-bbac-4525-8d7f-d64154697a31", "AQAAAAIAAYagAAAAEEtn30qvK8SG1vNpViHNBKpdkQIeVC5bC2Zp5X4D+C3fNhLK1NkmfC/hgVVyr8ly4A==", "3e06206a-34f2-485c-a30e-30520d6eceb0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin", "0" });

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IdentificationTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "IdentificationTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "156f11de-be67-467f-83f4-97ccd7c609a6", "AQAAAAIAAYagAAAAELNn6WE594UwZTNtjke8ScOKuhFeEbvMRgHp78SwzenRYr3Hgy02euOE2+Z4VxdjBA==", "e6c03042-21dd-4222-a78f-4925ed4703fc" });
        }
    }
}
