using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class CourseLstToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvisorCourse");

            migrationBuilder.DropTable(
                name: "CourseStudent");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "AdvisorCourse",
                columns: table => new
                {
                    AdvisorsId = table.Column<int>(type: "int", nullable: false),
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvisorCourse", x => new { x.AdvisorsId, x.CoursesId });
                    table.ForeignKey(
                        name: "FK_AdvisorCourse_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvisorCourse_Persons_AdvisorsId",
                        column: x => x.AdvisorsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d95f4a3-5f7c-4da7-bb43-77205a17c421", "AQAAAAIAAYagAAAAEC4RGKCM+ls7VaD5gvtxg0tdQgksji7SjqwKc6cgytq0LMlSXUF/J/YaGA5vNcO+Iw==", "7447023e-fb3f-4025-8ba9-7f3d5476cbbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60dee561-5db0-43b0-ba7b-6d2b6fc41297", "AQAAAAIAAYagAAAAEASshgv5d2tcH7TB/gK3PRRzeOid1J9fHmBXeuB9moBnW2/7SNxKAibRa4ZyyhpuFg==", "4cd1ccdc-640f-4cc6-9452-203bd51bed79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0f1ee2-3a06-417b-a631-573ca2747987", "AQAAAAIAAYagAAAAEAvw8J2rHtf0x86mgbOadeSVB2T5MT+IoeH8SU61Jun89exLnHY8iNnyJXVTc7mYxw==", "6af68458-3530-4042-9816-533bd86a9d7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17bf8539-35f5-4bde-ba86-615fd04bf955", "AQAAAAIAAYagAAAAEOwabLLmh9zM3WiNLHFZpQSpRZIsxrSIoH1aP+VvznAZQU4q8heMH/OeBOWOcYYjaA==", "27d50e02-ea54-4619-b8f7-c3f4678e74bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3731b82d-aec8-4571-a23f-04a8668ef611", "AQAAAAIAAYagAAAAEO3wuXHgNq6qhX3DSP/i1kufSSJAPBtJF2gK9RU8/5pbX9MGW/advCH0qbj/jZ5KBw==", "d12764a0-cdf5-483c-86dd-b989510d37a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f727586-39df-490b-90d2-f6e41565cdb4", "AQAAAAIAAYagAAAAEPM7SM4FzIRrdapmBN9yY3uKZwZH2jA1qWP12BtJiMEf6rloAiacPDXS1L7iU1Sx5Q==", "c9b1e159-e887-40a8-abc1-8899c623a017" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43637099-8ea6-455c-bde2-c45120b5e5f9", "AQAAAAIAAYagAAAAEKbYiU/RWaJqdZtLqLNhfy4Rsf7AOltMRnHtKxEpDeSMQ62j4L/d71ygmPArbMeT+Q==", "31029fc1-38f4-47cf-ba4f-ebaf4330b9cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3722d3c3-d1da-4521-b63e-a4a22896267d", "AQAAAAIAAYagAAAAELjt4zzMVpRSC67MH1qFu0qpGDYyDQnd0zf678+v4vi9MesbUOMiDJdAMnxkvD60CQ==", "e800a3ba-11fd-4eeb-b51c-9d123ce91357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3cff96a-7938-4dd5-bb1a-909d5ae92408", "AQAAAAIAAYagAAAAEFjJIRePcvZqBHDnkoU7/XS03l8m0OgiQIHFmfggVBvbugfx5aOAxDedxuyFKqqYOQ==", "20779451-87f3-4fb9-8644-fc2d82d6f92b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de02a474-726a-4ce1-8737-fc640690ec05", "AQAAAAIAAYagAAAAEOLrhg+xFnxBFoYlLO58jtCD/TLM9kBY89mQcRhAEvCTdzf6YKSy03r67aZwUp6VLQ==", "b5f68e86-3d9f-4b0c-a4ca-5f9f8213227c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82586511-3657-4c9d-b34c-82c3ec65c7b9", "AQAAAAIAAYagAAAAEH8C6kUKxA+fdvsuq+QkEAaPw0WW6k9VdD1Xz0Z364GVv5wdu4HpFPkuC0R4iaa5ww==", "6b7050b4-9513-40c4-a866-65191ef672be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388c9cc9-6913-4252-af00-42eeefe5335a", "AQAAAAIAAYagAAAAEL5yy+/o8LJ3CIWg7jyqRtF43yoskRSMSovvmZS31D93OtYw9TQAmqzvOpnxpAPwNw==", "6f6ae637-664d-4571-bbc3-40ba59013367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e983375f-e63c-4c6d-b4d9-9d03a65572a2", "AQAAAAIAAYagAAAAEILKkJkVslrUOMLsYa5O8Xttxr1G4S7MrTKjQU8L9DpF3mzRgJd6QuQe95CqBzumuw==", "38cfda94-d17b-4870-904a-ea2f36052e87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2ee3475-5e5a-4569-89b2-b78a53f606a4", "AQAAAAIAAYagAAAAEPZ63/8ivuW9het+LpMcGqQdPgOUHxcgcK+4em6aiubFxW8/Sb/Ygrh3/QMNwb6ICg==", "4d159f84-2f2b-4bf0-9aaf-e24c5407810f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d6528f6-5894-4ba5-8ff8-b2e488a8bfab", "AQAAAAIAAYagAAAAEKVAtbYmacnOGjW9FGmrmudBBBj2c3Ddh0dBdc4K/EoPnE1MBFCFQ6+lAaeyk7pnTw==", "1b46c227-2651-413c-8105-c586f228b61a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c756b2fe-7e80-43bf-a9c4-d3e74f75c4cb", "AQAAAAIAAYagAAAAEIqG1FwAdX8pRB8U9DhOl7mjdCjTgXcJgRUwjb4BSdFTEpmUJSQWLHjm5ZFWqaDd3g==", "4d2bf3cc-925b-4532-8679-3c9b5024ad22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff7af46-30e2-4e73-a86a-b6cb2be85b53", "AQAAAAIAAYagAAAAEAZczOWx6CwbZPnVQIGZlmq3Nmnbvgil4aRiXWVJRb4RVMac6y0S1Jwa/6nTZuWfZw==", "715984c0-bd6e-431b-b188-7fcc73e728cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fc70158-0b02-44c4-b16d-80a54ffc45b3", "AQAAAAIAAYagAAAAEOhqY7NTiVXs9EZGeJzE25rTErdUatnJlsK+rcYUMAjpS7Mq3eiAiqjhji2SPY1B2g==", "b4a18d10-a2b9-4b7e-a1e3-e675342b19dd" });

            migrationBuilder.CreateIndex(
                name: "IX_AdvisorCourse_CoursesId",
                table: "AdvisorCourse",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }
    }
}
