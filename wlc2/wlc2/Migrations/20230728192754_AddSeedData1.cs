using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RcaapCode",
                table: "Licenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RcaapCode",
                table: "AccessTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AccessTypes",
                columns: new[] { "Id", "Name", "RcaapCode" },
                values: new object[,]
                {
                    { 1, "Acesso Aberto", "openAccess" },
                    { 2, "Acesso Restrito", "restrictedAccess" },
                    { 3, "Acesso Embargado", "embargoedAccess" },
                    { 4, "Acesso Fechado", "closedAccess" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f30b647-a441-40fd-a535-787af6ca3ffc", "AQAAAAIAAYagAAAAEFtQjYMSTdlZ4ro5UUZqo41xXyV+k6CL8M0J85/D0KD+/xVJeSCTnrlHXnBvdh0PUg==", "05df1b95-6707-47fd-a735-b316e8204df0" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Alpha2Code", "Name" },
                values: new object[,]
                {
                    { 1, "por", "Português" },
                    { 2, "eng", "Inglês" },
                    { 3, "spa", "Espanhol" },
                    { 4, "deu", "Alemão" },
                    { 5, "fra", "Francês" },
                    { 6, "ita", "Italiano" },
                    { 7, "mwl", "Mirandês" },
                    { 8, "jpn", "Japonês" },
                    { 9, "cmn", "Chinês" },
                    { 10, "other", "Outro" },
                    { 11, "N/A", "N/A" }
                });

            migrationBuilder.InsertData(
                table: "Licenses",
                columns: new[] { "Id", "Name", "RcaapCode" },
                values: new object[,]
                {
                    { 1, "Sem Licença", "N/A" },
                    { 2, "Atribuição (CC-BY)", "http://creativecommons.org/licenses/by/4.0/" },
                    { 3, "Atribuição, Sem Trabalhos Derivados (CC-BY-ND)", "http://creativecommons.org/licenses/by-nd/4.0/" },
                    { 4, "Atribuição, Partilha nos Termos da Mesma Licença (CC-BY-SA)", "http://creativecommons.org/licenses/by-sa/4.0/" },
                    { 5, "Atribuição, Uso Não Comercial (CC-BY-NC)", "http://creativecommons.org/licenses/by-nc/4.0/" },
                    { 6, "Atribuição, Não Comercial, Sem Derivações (CC-BY-NC-ND)", "http://creativecommons.org/licenses/by-nc-nd/4.0/" },
                    { 7, "Atribuição, Uso Não Comercial, Partilha nos Termos da Mesma Licença (CC-BY-NC-SA)", "http://creativecommons.org/licenses/by-nc-sa/4.0/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccessTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AccessTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AccessTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AccessTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "RcaapCode",
                table: "Licenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RcaapCode",
                table: "AccessTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee9945ac-477e-4209-9a4d-b373b5843ecf", "AQAAAAIAAYagAAAAEBN7KMLhikYhXtAPkTIOu0HdiaKGUuO2T9elKjraBgAw3cCt0FNijqZFyG1mi8Gogg==", "4352546f-3323-4a9a-8afe-65ba804f96d5" });
        }
    }
}
