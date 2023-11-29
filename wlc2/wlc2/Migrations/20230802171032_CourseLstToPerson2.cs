using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class CourseLstToPerson2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Persons_PersonId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Courses_CourseId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Courses_Student_CourseId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CourseId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_Student_CourseId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Courses_PersonId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Student_CourseId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "CoursePerson",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    PersonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePerson", x => new { x.CoursesId, x.PersonsId });
                    table.ForeignKey(
                        name: "FK_CoursePerson_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursePerson_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a809b4a-4bc2-4806-bb13-1c39e1c7af42", "AQAAAAIAAYagAAAAELv78RwLmAKoMODHl+fQG+2qtUUq6E37B+DQ/mZ1Enh1k3ZhTFajtFYVNyI2EKkChA==", "9a0b05cf-685c-42a7-9b5e-4ef8d81eb6ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30091858-2ed3-4bdf-9d78-7a9e65bbdd0b", "AQAAAAIAAYagAAAAEMGJp2C5OJKt5AcPhizCYoGst42j0HlKfcIBp12tUJ/V3lZj+sJF7Cs4zyN2zlIULg==", "5d39092d-13ac-4268-84c6-6aeddb30373b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97992725-9d26-4782-bac5-477b7ddd8333", "AQAAAAIAAYagAAAAELdmnYPQbf0lXVs3ycq0UOtTRC9KYhbO0FtSHIAVX+OeJZzN2SFymJKXrbZ1kJXgSA==", "c7e0f234-9e8d-4267-96e1-db2021226622" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16a63d3f-599d-45bc-bd15-3af7d30e6ca4", "AQAAAAIAAYagAAAAEHity5oSVE8q49QXhgqZaWNR2cgnyrcZ+cgC2FZyi1jGWAF2Pzexal0ujIY9fGpXbw==", "f02b443d-aced-4e7b-a70a-633c987ea200" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8a06d0-0517-4183-a441-f12f3e11bed0", "AQAAAAIAAYagAAAAEOYL2A+T6JDGtm+Q0np5qX9PyNHa3vrJ6IRnRzwIvx2Ge9GxZO2faQ98Q67+8PhoHA==", "c1d7433d-2ec7-493a-8d9d-26c8a392dd3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad567ba6-c8f3-4e79-ab5c-61cab3f0866f", "AQAAAAIAAYagAAAAELzQkDNLfrWVSsXWVvBsrCQLhMnlwGLOp7l/IoSDQmuIqDmjFBWJHxBrKdm65AORlA==", "30c5536d-b22a-4ee4-81b8-d8e6a7eec12d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1859bb-5e63-4f41-ae14-b727366e06f0", "AQAAAAIAAYagAAAAEKuKOgA43xj68peasRlyZx6v6eoP9YalbpLHz1VODhpYwnWrsaqAuSi0+SJt6Kua0Q==", "5d171a53-87d0-423c-b689-6ee8a684ef9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0312764f-bcb5-43be-b118-51ff4a292642", "AQAAAAIAAYagAAAAEKjMFoqgafcNq3dyvEp35/yzy4RbzavUERuIRnNncqUz0i05EixXJbFIJxRk14hbug==", "fac8aab9-87ab-49da-9eda-cea1159c8a1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21e3957e-2fe4-4cb0-a00d-560e2f91f6ee", "AQAAAAIAAYagAAAAEK2SDcArKJIHUa6xYiqc6Q9aDA3zzbBmWVBL/tpu0yOGiFA7EF4bYMzrqvJ8ZYV/Ug==", "45a2dcd1-8e8e-4807-94ce-6e756b46cd17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9acdc78c-21c5-43e2-b0d3-1e6a9ef706fb", "AQAAAAIAAYagAAAAEHsMA5O7Yr0BhIFrE8pAijimIOOoHZatHFhhSYpNIzehSi+JzfjW421gpRzugabfdQ==", "2d148a32-0a38-472f-a2ee-ac1093efde59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f385e3c5-de61-4cc8-8ab7-20637164fc1e", "AQAAAAIAAYagAAAAEOJRTibWwhD95nOfc4fEGQ9xKW87C4XOlem4HKQ66sNc/DDqNidG2UiHFafbK8zEXQ==", "f65736c8-97e3-404c-8476-da7a176ad573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c20d57-1797-4f45-a9ee-e1c0bfdecca5", "AQAAAAIAAYagAAAAEEdKbaXnTnHwJsRXwPxIbtHYLjvNPXsC0vxu2xF3r5wz0gOsrsawMe01bCjUaaY9JQ==", "36890d03-3b51-4b0b-9155-505427076269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "827cb7ab-92b8-4c46-bc45-816ea90a0351", "AQAAAAIAAYagAAAAEBy+/ol5IBAj+P7OilDf8pIaFPjz9J5J+PMoAfREPMFC2Dxarz3wdfuJRcuvafIz/g==", "6fec3b98-d179-4348-b02a-ecbace6a2961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdb0d915-e510-43f0-bb0f-c4d802b53322", "AQAAAAIAAYagAAAAEPX2j38Y8mhqziR8yJy87QZoRPxSSuc2lu8ew2YuRgF+4eh3QRnPpzW1NiunU87MLQ==", "9ef4fc18-36d8-4a74-a9e1-fdce0d98d280" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77e8a598-96e2-406b-8e28-06421b2d95cb", "AQAAAAIAAYagAAAAEGdSsTlz6kLvTM4kwykUuLx1LCGIdpgM74MvR2LMsMPWaMUaneCESIcr21tMgSUfJQ==", "4c530fe3-e8e1-4394-9340-82f067410161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "449d39fc-33f4-4130-ae95-e76818eb35e4", "AQAAAAIAAYagAAAAEAszHe8R9z6jSbSEOOLIZNULnHLSgvWNKPGUStV7Au6o7PTbPX1Fn1grNLRzAyIfVw==", "cc438a04-efd3-4f8e-b2fa-8ea8a3ab4698" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e13d43ed-51ed-418c-bf8f-82dc2f3e3234", "AQAAAAIAAYagAAAAENp5/wTe3By7l4rDVvnfKCtmXviZ0EgeTFNNHoUnYzaefN5ISnKognHrA9VBwZXC6w==", "47d5a636-eb9a-4f06-806a-72a4c1a5e8b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2c9af8-d8dd-4183-a1d1-2db98797034e", "AQAAAAIAAYagAAAAEOeE371Kk3741xXZWLNELlXQ78qa2F/aJVSYau0P3wp1CPyqiglLEWwZMPs4Wky97Q==", "daf1ae24-7151-4739-af8c-ce3390d03a99" });

            migrationBuilder.CreateIndex(
                name: "IX_CoursePerson_PersonsId",
                table: "CoursePerson",
                column: "PersonsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursePerson");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Student_CourseId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73cc3dfb-2ba8-42d2-bf71-d3a084a1abc4", "AQAAAAIAAYagAAAAEMJU6syBnOT//UmrXPBNR7mFR7AAFfEHjPYb5NeEJdEG5a7BwINq+dck6L5rnHvc7g==", "1a8a5824-91a8-4cbf-b933-d3c970fff635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c373f38-83d1-4d65-81ab-08bc55016034", "AQAAAAIAAYagAAAAECUnU+JeSqRehCpYJOGUvi6wUuQ3xEBATN5FjCFvUq3UjTPx8WLos/LagfguubmZmg==", "0664f79b-249a-4485-9503-c5340a128a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ca4cc65-8cdf-4505-a9e5-e2d5e1aafa61", "AQAAAAIAAYagAAAAEIyk4/JBgimRKqX/JgiiRCc2KVUpDfkvTcKXmSr11Nu/1tfa3OEFqpQlHseMMyioEQ==", "e06db372-d664-49de-bfb8-c91ff8fac1bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "347f2c12-2798-4330-91d3-122f0e8cec4f", "AQAAAAIAAYagAAAAEHVMe/ihWWCufC+Cq//u7FZNuUv9U7QQWXKQRyEOZlXJv8l5Hq7ptEQr8wgALmPgJg==", "36009e96-934c-41c6-9ecc-48aa6ff41b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73c78113-ac87-4b06-9fe7-671079c1fbf8", "AQAAAAIAAYagAAAAEIp2Q1OgAaHlQOOLXtPwb4dsSAZYl6AbrQrdI43KBCXWUZm5XA6VP6iShnXUxOfwtg==", "f86e50db-7239-4643-b8e5-5b66767a13ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a6889ac-cdc4-49cc-9ab0-8c4a968eef4e", "AQAAAAIAAYagAAAAECZSF36eK0i5bqLV1pMDliysowd87f68GN3vPDjZgqeZTIOhz3iU8Ht/fegEcAKs4A==", "625bd6c7-01ed-4c4c-8e77-7789fbe52044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b729119f-6a75-4083-a667-6600c85c39d4", "AQAAAAIAAYagAAAAEK78fkYNI9gp3wQSeDLVPgn9ebDNct0ZJZRgPNa9aEUEiKG32bqAL6bTpA/BJbwhVg==", "1d187449-f7da-4174-8385-40bb2c30fd17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3f5b2a0-d8ea-41e6-aa1f-265cc5180466", "AQAAAAIAAYagAAAAEBzF/eNuYQDmc+Vj8ImCZCyw8fKCecCi0Z3UlvzWxOGkq45ti+OYDT6S82WgqQWCDQ==", "25cf0007-afd2-4048-8835-999c32a62a9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c40eb27-d172-400f-b721-e7c6ca775380", "AQAAAAIAAYagAAAAELw5JcsHAKxZN6bgr52KyeGWh97XT2uKVJURBvg9QI3ZDBENJa1orLDUB9GT9XIfWQ==", "15999713-e4ca-4d2d-8a91-77fb55e5aeb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3335c102-a850-4f1d-948b-41962c6ef2c5", "AQAAAAIAAYagAAAAEJpAonkPA/IstwZJI2teOzAML4PHxdo51/va1SwCkhPuPWcHG47IisfKw1ErecRRmA==", "cb657411-27af-4bd1-8720-e3150bacf67e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba80ee7f-a0e6-4d32-94eb-544b8c82eeb6", "AQAAAAIAAYagAAAAEKT8Ojt1n8kNSKnvvmvsGcrcf2uGTaGTsi7PtAaF/hmgbJMyiARZAIILVfAi6Ft7/g==", "0d4bd8ad-ea81-40c7-bd11-8a2e66ffe70d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c55b3c2e-8075-4400-ac14-77a750e8808a", "AQAAAAIAAYagAAAAEOqNkYVR1b3KW6aizThj8s/TiSuAiniXgFL96QidWlA5cgLKStOVizgoxEOugVGqkQ==", "b307a893-bcf6-46aa-8ff7-abd5d2781936" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7311c343-395e-4343-950c-6b1704b0c93e", "AQAAAAIAAYagAAAAEJ+jW6cizh+2PdgHrfK7tb6z5QEm7BjFEnTew/K9dNaHHNFmyFvAXCjB3d48tpxWxw==", "b01edb9e-de4f-451e-bea7-425d80e7d735" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b827318c-32e0-4d15-bab2-85f87eb5eb6f", "AQAAAAIAAYagAAAAEIFUKdk6YBOTr0qOJlARuU2TGqk6JKU8ydcwkiAqFQGKzgyDPwMBeSY5xJy+zCGMXg==", "67391ec7-96f4-4ca5-8219-d8c04a652e4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b1d33af-38b6-4d32-9a1c-5e7fd0c3f224", "AQAAAAIAAYagAAAAELF0ccNM60KZeeWyTUk0jDFRU/la4UpxYf+Ga/S3tNy/jBKDZpdfPGPjI++DMlHkVQ==", "2840a260-9fda-4773-b1a8-8c8f600024fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "367efa5c-3e2c-49eb-9f7e-52f07ca1c512", "AQAAAAIAAYagAAAAEFcBZsAp0DqPdXeIoF2jES+NAg5s5WgLtxN3gsqyCmNGHspP+YUHceXZV2JkNNBjMQ==", "bafc940e-ac1a-4f63-a7d1-166b395cd170" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75fea0f6-2821-47c6-a061-191bf2d59e15", "AQAAAAIAAYagAAAAEBFDj/m49soS/C4/0oSE7irqZv6DDbmS4FeGCPuITAeBM1oBg98I+IkG+vroGogc5Q==", "923f2e75-9562-4b04-9203-62b4c5649020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e6ada1a-49b6-4773-97c9-7d480e587020", "AQAAAAIAAYagAAAAECfY+v6kVIWQ7urWggQaszV23QAYqk7AAgdR0NWlr/ISIbUaZ+h4ggEW5QapfovKqg==", "ba89a6e3-0a18-44bf-89a0-4edec3668e26" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "Student_CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "Student_CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "Student_CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "Student_CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "Student_CourseId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CourseId",
                table: "Persons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Student_CourseId",
                table: "Persons",
                column: "Student_CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PersonId",
                table: "Courses",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Persons_PersonId",
                table: "Courses",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Courses_CourseId",
                table: "Persons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Courses_Student_CourseId",
                table: "Persons",
                column: "Student_CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
