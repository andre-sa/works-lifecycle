using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseListToStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dd15492-00ba-4979-a382-6a2bb5b56d63", "AQAAAAIAAYagAAAAEMxwi3qmqDaYiy1dA6/1BlfcgelCSHVhZq0OZ8vbXQHkjZvHwvr/PeGaOA8Awik6Xg==", "a7e38b67-29ee-4b72-abc2-80642333ae2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40bac0b4-c7db-4388-a50d-046628fde9b3", "AQAAAAIAAYagAAAAEBsw758YjmcWba0em6K7kSiPjOFul8M1t2PInJhFE4xGsVzPIZHNs/aXsXJ3HMN8+A==", "4020d5d9-2696-43fc-a275-b63328d42030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d69fd5-0f28-4e33-ab98-f4067664011e", "AQAAAAIAAYagAAAAED2dz5wR7ZpyHIR6Rb2k9fgnjEqI8skbDHW2JenBYdOC3juySyie0xxNd0yyyRmjUQ==", "9add7bd8-12dd-4b25-ae3e-ff8e199b0616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5daca108-ef24-4822-80a9-7a1cb31dafee", "AQAAAAIAAYagAAAAEO0zi2vvBTFl+vzHCLZgHhVjJUHCTyeBKCBsjgUyPURTuXJ18xJeUrhwk8RC7lDOcw==", "70257d26-d0f7-4195-a5a4-3259a721971b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87d493a3-9b5a-4442-9934-ecc72f076835", "AQAAAAIAAYagAAAAECrVv3L3mPo4QjFvZzI60zlRFFIb/PWBLpbpGuEbL/Ix2fO8im38QUvUZBuEAkwIhw==", "26d4b90a-86b0-421f-a346-5cdb5abc482b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "002b627d-3ab7-446c-a5e0-7f29d8689bb8", "AQAAAAIAAYagAAAAEOzca6A4N+hUjfxsfYzA9JXjivzdAky+X6h3iAA0BS/a/oXEzCQ0XIlUGts7SOdKUA==", "4ec97bef-cb45-4da5-92dc-33a9fe2b2162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43313139-0a83-4e1e-a55f-8d0e3e681202", "AQAAAAIAAYagAAAAEBdNeC6Od0yoqjwXfgswBf8Tw9VJcsBr2juTqyjwGYZUtP7s9tRhjtbSUW2WI+VRdw==", "1dfbbf4e-e276-4171-86fb-d144ccd98bd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436196aa-72ca-45d8-acfb-3a48fe964d14", "AQAAAAIAAYagAAAAEFkXUxf73tbo8QHe1zx1sbkY4dQ/JAemA1ZyqrfaU15Ik8MsPBPlsWbgzy/NeCW4gQ==", "3f462310-d606-46e8-b874-e846cd9887e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd7d373-0b62-4b8a-9ae5-61249f979a30", "AQAAAAIAAYagAAAAEFuJxdd+PePw5ElNIvIwexEb4+CtUitI7yqk867Ca/V8qOEoAZ6Pz51tCyttz9Az7g==", "a900f765-3ed9-4ba8-b1c4-ad0c73f59394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831de29e-e912-4bd2-b9ef-783081d645f5", "AQAAAAIAAYagAAAAEKtrMCUfPdpU+zBFdENcUbewVgMUUr9ttq9VPk+X+rD370QMDEfh4Aq8/ctTXkLEKA==", "36f500cb-25ef-4590-88eb-ffd3b4889c3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "623abd85-c93b-4d4f-831a-d8fe54111400", "AQAAAAIAAYagAAAAELRCk+2USIf2GK9slNpZYd2v5MDpXA1Bc5kZjbCuVeKR0mDn+LdFK06AWSYfRCLvbA==", "4d777b48-c0e8-427b-b016-115fdb2cc9d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc49c7d5-7cae-4ad5-bb94-4afacd2c0a12", "AQAAAAIAAYagAAAAELt0nbJy7fyXdC94Jb5fyxFrXkjP49C89kTguezPd+7ro5aPpSWULJCTffBlQ21+gQ==", "6a7ed278-5fe5-4309-8f66-acedd90a91d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4488e2d-a889-4e2a-81cd-9d83f5d6105f", "AQAAAAIAAYagAAAAEFODfxFhIVGG2MqqOCous3tMlxgBrSls0VJ8teFFhbKMRriDT86FfbknrHu4uIXp1w==", "068ac1d1-2402-457d-8b65-c1affd1d75df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e062c82-0fc5-4463-9cad-2e7607dfa839", "AQAAAAIAAYagAAAAEJsOATW04pj14iNY242nkJqyNCm1MFUhaNhhHOixfq+7CzCZgxtjA3MaMxGUtmHcuQ==", "50a6186f-5ec2-41b1-9ebe-c30542e1fb57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12ab646d-95d6-44d5-85e9-3dd37db19eb1", "AQAAAAIAAYagAAAAEFkgMyoMPlyVPdpXPrNgU6TFlywn8JHvrYE0LFRggWmX7T1xQx9su1iAYIDJ9ejl/Q==", "b6f0ab0b-1c69-4d09-90cd-4ac18d0abe1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef56689d-bb86-44de-9626-c5794b1b3ac4", "AQAAAAIAAYagAAAAEOSkj8L4O+HoEdASbbmwHtE0jbFBasQrHMd0g2hpqzcH9ljKolVPW/IDugb4BKn42g==", "afd1602e-0b99-44f4-8fc1-44e6eee7dead" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "743cceca-4703-49be-941a-287350f05cb7", "AQAAAAIAAYagAAAAEIZ1Vuxe84TuAVDoFSGaWRSsrVNcYFP+wnjiWa2rRT4fRoqhZ29YLSQl+Dm8rQFreg==", "96a21a69-04b2-4592-aea7-4449dbc71d18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fbf184e-6b94-41b3-b422-50096224dd21", "AQAAAAIAAYagAAAAEOH5ZEAaa++FXPUwCGsjmGSah7XRiVZmmwAn3TxtcweNOxCxcuI1Jw8PUdnrIbnwhw==", "a1638a2b-963f-4abe-b03a-21bc3f7abf2b" });
        }
    }
}
