using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AreaRENCODEtoSTR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RenatesCode",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfab2e3c-c7d4-48d7-9287-b21adfc1ca2c", "AQAAAAIAAYagAAAAEBW92VG40Brs2TEF7xDrQQ8kKeeBua7iHg3n6MD8qhhxfFyOmbQGhaewIWOCt4CilA==", "3955c076-e855-4a21-9101-1e9f2f458aac" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RenatesCode",
                table: "Areas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db83ab19-e2f2-4bd1-b8c6-680bdb6c5551", "AQAAAAIAAYagAAAAEN1402g2tPxQRP/BycE+llo3fnG27PevuW/8CpCoL8pcoqFW3LSb0AW/mhk/QNMsog==", "72966723-8b3e-427f-8a98-a899ebbb3b0d" });
        }
    }
}
