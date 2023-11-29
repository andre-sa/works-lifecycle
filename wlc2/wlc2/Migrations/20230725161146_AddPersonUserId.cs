using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee9945ac-477e-4209-9a4d-b373b5843ecf", "AQAAAAIAAYagAAAAEBN7KMLhikYhXtAPkTIOu0HdiaKGUuO2T9elKjraBgAw3cCt0FNijqZFyG1mi8Gogg==", "4352546f-3323-4a9a-8afe-65ba804f96d5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Persons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c0b58bd-653b-4e4b-9167-1b82e009c8a2", "AQAAAAIAAYagAAAAEMjsJ7zuGDfguz56zZGpjhNG+WDIbNAh0iZ0NhinHgywu6fE0dvcg0ri3NSR1XwgcQ==", "de57a0c3-c85e-4acf-b175-794c086b0327" });
        }
    }
}
