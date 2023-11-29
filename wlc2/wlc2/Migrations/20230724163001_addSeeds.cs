using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class addSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c0b58bd-653b-4e4b-9167-1b82e009c8a2", "AQAAAAIAAYagAAAAEMjsJ7zuGDfguz56zZGpjhNG+WDIbNAh0iZ0NhinHgywu6fE0dvcg0ri3NSR1XwgcQ==", "de57a0c3-c85e-4acf-b175-794c086b0327" });

            migrationBuilder.InsertData(
                table: "OrganicUnits",
                columns: new[] { "Id", "Abbreviation", "ExternalCode", "Name" },
                values: new object[,]
                {
                    { 1, "ESGT", "3241", "Escola Superior de Gestão de Tomar" },
                    { 2, "ESTA", "3243", "Escola Superior de Tecnologia de Abrantes" },
                    { 3, "ESTT", "3242", "Escola Superior de Tecnologia de Tomar" }
                });

            migrationBuilder.InsertData(
                table: "ResearchProjects",
                columns: new[] { "Id", "Name", "Reference" },
                values: new object[,]
                {
                    { 1, "OMRisk", "UIDB/05567/2020/04" },
                    { 2, "Cognition", "UIDB/05567/2020/01" },
                    { 3, "MoSBurn", "UIDB/05567/2020/03" },
                    { 4, "Solar", "UIDB/05567/2020/05" },
                    { 5, "EcoModZHC", "CENTRO-01-0145-FEDER-179932" },
                    { 6, "BREUCA", "POCI-01-0247-FEDER-048257" },
                    { 7, "CRASH", "POCI-01-0247-FEDER-070315" },
                    { 8, "GePISCal", "UIDB/05567/2020 " },
                    { 9, "SmarterCW", "UIDP/05567/2020/03" },
                    { 10, "SmartBASE", "UIDB/05567/2020/00" },
                    { 11, "H2-REnWaste", "UIDP/05567/2020/01" },
                    { 12, "Dragonfly", "UIDP/05567/2020/02" },
                    { 13, "B-RELIABLE", "SAICT/30935/2017" },
                    { 14, "HTPDIR", "POCI-01-0247-FEDER-017644" },
                    { 15, "INFANTE", "CENTRO-01-0246-FEDER-000017" },
                    { 16, "INDuGRID", "ERANETLAC/0006/2014" },
                    { 17, "VITASENIOR-MT", "CENTRO-01-0145-FEDER-023659" },
                    { 18, "EXOBIKE", "CENTRO-01-0145-FEDER-24013" },
                    { 19, "AGA@4life", "CENTRO-01-0145-FEDER-023369" },
                    { 20, "MOVTOUR", "POCI-01-0145-FEDER-024068" },
                    { 21, "LIBÉLULA", "CENTRO-01-0145-FEDER-024052" },
                    { 22, "MOVIDA", "CENTRO-01-0145-FEDER-023878" },
                    { 23, "GEDITEC", "POCI-01-0145-FEDER-023723" },
                    { 24, "VALORBIO", "POCI-01-0145-FEDER-23314" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrganicUnits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrganicUnits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrganicUnits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ResearchProjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5076b4b-2619-4e9f-a348-28022a684f51", "AQAAAAIAAYagAAAAEGj/o4o5dIOYwV+EkJHc2ohqxVazW8fi8OZOnRA9TMX2RNPEe0ogyVm50t0WCGWyIw==", "127066d8-46ea-42f9-b6c6-a2c4be7d9de3" });
        }
    }
}
