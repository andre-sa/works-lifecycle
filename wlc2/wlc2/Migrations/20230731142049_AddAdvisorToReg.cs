using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddAdvisorToReg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db83ab19-e2f2-4bd1-b8c6-680bdb6c5551", "AQAAAAIAAYagAAAAEN1402g2tPxQRP/BycE+llo3fnG27PevuW/8CpCoL8pcoqFW3LSb0AW/mhk/QNMsog==", "72966723-8b3e-427f-8a98-a899ebbb3b0d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f30b647-a441-40fd-a535-787af6ca3ffc", "AQAAAAIAAYagAAAAEFtQjYMSTdlZ4ro5UUZqo41xXyV+k6CL8M0J85/D0KD+/xVJeSCTnrlHXnBvdh0PUg==", "05df1b95-6707-47fd-a735-b316e8204df0" });
        }
    }
}
