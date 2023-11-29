using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddedTblCourseAdvisors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursePerson");

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
                values: new object[] { "e4b18fb5-aeae-4cc1-bf97-7bf9a1aef1dd", "AQAAAAIAAYagAAAAEHQvNgJfULjsmDBI6NVuqenvppEp0GmNZ+FuraY/KFt7ZEvLIb+Bu2WOU5BIdFhx7A==", "a9cffda1-a6e5-42c1-a7e6-51b17a7df81e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06427248-e6c9-452d-9c62-fa4a13cb47ae", "AQAAAAIAAYagAAAAEO0pEgyCZfqXkJEvefXHBZaCzZDYziTdgRaKjAwYFUwSzrf1Xahs2ad9I0HaGlF3LA==", "d2b7aa19-9948-417f-b740-950f11fe0fea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "657c9642-0559-46b0-904b-d9c2f70aacf0", "AQAAAAIAAYagAAAAEMFQhhIGiMmh4kLPh3JRwj71Oa0gHk68v6D9yDYrkaaxQ753Cpu8RSIIt9mqga36tQ==", "b37c710c-46ba-4a09-ad6f-abdd11fb4bf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee4182ff-32cc-43de-8c6a-c19fd5705e4f", "AQAAAAIAAYagAAAAECY5GfBFYMDUe8JXOikdnB+Ri7jtZxcGlpne+GGIzyZ0JptfCVlRqADRxa5I0/S3lw==", "283ffa6d-5880-4acc-8846-f67e3b39b9ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "033bb991-6a1d-4b64-ad78-453c9e215770", "AQAAAAIAAYagAAAAEFGfOGiX+bHqrZO9GlzhiN/MWRe0ArlVS8BjjPtKzdsaY24pYrNQekQt9nnf9Ro1OA==", "902578ab-6dd8-46d0-8afd-a6a719ea8d76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc81763-3607-4b48-bc40-11ac22b11178", "AQAAAAIAAYagAAAAEJCPzXiaDvM4m9WEmevYXpNYBMeuSFp+WZ/mTTw/cCAMSYVKiFVEklb/WLNz3nbKfA==", "192180fc-2416-4cb1-b33b-c9a5c792a8ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75c43266-19e6-4605-b5e1-7f8431984171", "AQAAAAIAAYagAAAAEPfLf93KqhqcCZT8QNHEkclMTzxxkcLugk8aKL4DiOruZ+zOc2BQffyACsGtAJ01SQ==", "d23b30da-2013-4f8e-9a03-fe3c91c425b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86d740e7-ca79-476d-ada8-3b863897717e", "AQAAAAIAAYagAAAAEI5LL7vtI608kTTzVkRde1BKTPDgOq5ZCB3zePg3BX815nDMhM94GrEH3LAXOYzMgQ==", "749bf334-da57-4013-a826-e9157cccb352" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2039e589-ed62-4d45-98f5-5020d3b11430", "AQAAAAIAAYagAAAAEG7XdPm6QtuGswoKPXghs+uKF/26MAXLz6vR7/b8MPVcfE9xmyedimpfzidbuLnfMQ==", "d32ac783-dc90-4e17-8307-84ca32a0281a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dabbbce-0cbb-4f81-b284-10b2b8038780", "AQAAAAIAAYagAAAAENNEOjAp8rB3E/vOxdV7GccEiggReinTEpFzAcPPHqLA31x59cwouctJ0A1PxCxvFQ==", "0deebf5e-5b3d-484f-8bed-6eca9ab1f45a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b050b82-3ef2-43da-a17b-57bcb7369162", "AQAAAAIAAYagAAAAEIkNcDPTXDjalkvBMUFK6yiE847k3VRqSopeMTBLN+t3EbRzJzGQ0Y1fzTfA4PCAwg==", "8e874865-192d-492c-9e8c-dfbef15fb23f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "239c2fab-234a-4aea-8654-559348ff1135", "AQAAAAIAAYagAAAAEPaJRBb3+luKWaSNASeBoF62pKi8bEsngvOUBOzw7NbNjzJU0Zjixb/9xa50/08oeg==", "21efa3fb-5db7-4b16-94a1-4f827dd1ec31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512367eb-6f0a-478b-9ff2-60f8a35b3c8b", "AQAAAAIAAYagAAAAEBQS76tiC2KP+ctNU7KTvjdNtle981w1TmHW169ctzGb8a3xludqQX0aM9fkHkFjvQ==", "8f703fba-6eb7-4f90-9f80-ecfebc400d7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0eb7b1-7c0d-4787-bae8-62f25b79c247", "AQAAAAIAAYagAAAAEFoQmvy66AlFTCu9CoyToGb6T1EghakdCmYYDHkxLQU59Mgdfc6JRS4rm27KuXiF4A==", "631ec4b9-0a62-4b40-8a64-80d837adc6ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f671ad56-ade8-4fbb-9a1d-f7dda552374a", "AQAAAAIAAYagAAAAEMtSVn+hAgUbHccBRBcgEvJLjsTdkUZxUZqO0/r61hRbStmuRsXmUJl7whzUYk0exQ==", "22dff0f1-21e7-450f-82ea-ec9527247ab7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35b7a14e-b7fe-4dfc-b83b-768d399efaa2", "AQAAAAIAAYagAAAAENm3OAyZhDEFn17lLNb2jf+JSEOhxAwboOnUWE0D52p84SlZO99T3A1KTR1kgea0Hw==", "30978e5c-6c5e-47b4-a3ae-b442ba693027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a01c043d-df44-4371-967c-a00b0ada6c34", "AQAAAAIAAYagAAAAEJLqlnR5ZyT8lrWTcdN/A2VFsZOi8HrcQK2GxxV49Je9Otl+Ff21bgpP3LrbZ7I+AQ==", "b3defe09-1197-4953-aeb6-8c97364f8b61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46977084-ff3c-4897-8720-6b56935719e5", "AQAAAAIAAYagAAAAEJQ1w83aTWpibOqdaGYcyK3tjiqFhlYLlBXC5f/iYvMtiVLKtToVz3wAnibVP7fzTQ==", "029cd7fc-4a10-4b7f-9e44-437b6f4f27cc" });

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

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseFK", "ECTS", "EnrollmentCompletedFK", "EnrollmentStartedFK", "EnrollmentStatus", "StudentFK" },
                values: new object[,]
                {
                    { 1, 11, 162, 3, 3, 0, 13 },
                    { 2, 11, 156, 3, 3, 0, 14 },
                    { 3, 11, 162, 3, 3, 0, 15 },
                    { 4, 11, 116, 3, 3, 0, 16 },
                    { 5, 11, 168, 3, 3, 0, 17 }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Persons_PersonId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_PersonId",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5);

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
                values: new object[] { "05dd8057-d7bc-4ce7-b412-15d6bf5177c3", "AQAAAAIAAYagAAAAEPcv5mSdd2CtLpvWNPNKohB1HMPEb1HnnQsf+/XzhtqwMUvyNqAMKalQH3+JYwXrqw==", "c966f5ec-ed2b-4605-af1f-8c17751d65a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cccb90e0-b4ae-4612-91f3-5f8377c667a1", "AQAAAAIAAYagAAAAEJHXYGu7ikQ4+kA0OVC6E5DJ/L2NqL+Ns+pALZ55cgnVm1RbT1PP+FfDHyYnG63BGg==", "050fc30d-289b-42f8-90f6-e122f027804e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e2e56c9-0b67-49bd-90cb-9027e2844559", "AQAAAAIAAYagAAAAEOt3PkyDuzJF/bSo7QuShO0GfVwJ9DEuSiHfmAkSGsDZSZL8GgoLHYhZb/4BBsqp5g==", "680ac7b2-7493-45c9-8486-f2c76f7ec785" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d03588-8844-4529-8e1e-569c1ef1e55f", "AQAAAAIAAYagAAAAEHzgagCwcDvYIcXpsc1UoF3zrthV6Y1Zb8vv/nVQpWsOPGntgU+lHWk2ZOboxG3E/Q==", "f84396c6-bd0f-4718-ab89-0b951b97cc0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f69d403a-12a0-4aa6-b432-b09042ab09f5", "AQAAAAIAAYagAAAAECaBDcjkLjyj2evmyJeHu54X8meqZsRIRsK9gLMIwYvVeF+mDslgFvc5wgFspycdFQ==", "6849d0ac-585f-49ff-848a-3216eceffb7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6330cf5-d3bb-4677-b2e1-99e967601141", "AQAAAAIAAYagAAAAEIJ/U2E9JipdLC8LQrIOX5c8+vfQ0ATd3cqqUfhFVOe3/1MmnRiDRmrr11ootvuF8A==", "a8fc574b-5ecc-4159-b3e3-f484185253a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb26195b-4ed2-4e2e-8da4-12cdcc70ddb2", "AQAAAAIAAYagAAAAECRJPR8UybW4UZrNWHVF/kjGw/E5o5tvbl7+hS6JNmO/4NluCs+dE99vwO8rXPnmWQ==", "7575ca88-00e9-4e5f-b9a4-ec3131c15d44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "821c1fa3-eb09-42fe-bf49-ff108477737c", "AQAAAAIAAYagAAAAEFU6EGudyc2mhuM7GuVOdtjgwQrw0zAhnr5T/aiR9HoThTeL23enknQGgd3GlQN2eA==", "fadcc17d-3a83-4370-9ab7-852fe18516bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5674924f-4559-4b2d-bce4-d8f695476bbd", "AQAAAAIAAYagAAAAEI+oK2xS6w8WCM1Rqqq6bmBdDSqv7dwskcvypVgNWD8JKXnZgDGYBQEjneymnDg8nA==", "3546c997-7d0e-44e7-a685-1c6b72fe1c56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89c36d18-1406-4069-8197-5d80cf5a059b", "AQAAAAIAAYagAAAAED5+sJ/jnonrvmaN8W0EfUu4ArZngSjtc0Qv4AHMDDC/UCFHV6gb3J3VA2FUaSLGcQ==", "e1a3ca8a-a871-48bd-a26f-53166781bc5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b07eec3-a84d-46a0-9f68-e964483d99af", "AQAAAAIAAYagAAAAEBPfBEMKqrJijIbDlmzlYRkSRPIFA3pDjY6aoJfrQTN+L/nUPzFEvLZGFlUgoupqXQ==", "f43df650-684c-4419-be6e-070fef5d4744" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89b21a6-7919-4105-b400-790fbb5b5a2a", "AQAAAAIAAYagAAAAELekaEaJpxvIpFj2592OQbVxDvHeuWtMIgHr0MP0E3JT85N+bazqsjMUCcQAOt0/9Q==", "bfda7594-2c10-437d-99c7-e63a0057cc80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6390a300-1f9f-49fd-88ab-a940dfe4007a", "AQAAAAIAAYagAAAAENBrN1FTJE3VpjIKG0iENqysHIlNvYuf1A5bQJvmpyo9Yb+G6NuJ3S2kSk94h40QHA==", "4afa907f-373b-491c-80be-cf0ebfbbce4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeda2a2b-ead5-4b04-af6a-9160e2fcf510", "AQAAAAIAAYagAAAAEDwnp9Q9RCqYCjGZMu93iWNgXUdQkni/orlIp5qKf2wE0xpOylychl59KRXuHcI4Rg==", "86acf8ba-5e81-4551-afc4-8f274e931447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9047666b-0a6e-4f94-a61a-13dbd7f0b9d9", "AQAAAAIAAYagAAAAEFvbQg4LRvM0eaX5rIiI9SzsfBc2d437g5l6CSdsk0OXv8OJcwa3VuriztndefVWZA==", "7680982a-a37e-4cdd-9dde-188e4f24fd14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24297b97-6cb0-4b05-b508-eb72f79c18a4", "AQAAAAIAAYagAAAAEJJDG5Hwi2XHNCJWpAjI2ZoXuwi2x9DwSTwyaB5eaPwkexcJOaDLEPzI9UW2yoECBg==", "ff4b45f7-2492-4483-aa35-962b10e7edea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f91e119a-1b91-46af-a8d0-d52bc36a6854", "AQAAAAIAAYagAAAAEEw2IfhcZFu5QvGmSIjXSoRbhIxqKVidGVzYCufVLY1ZW7h1T7jTYHqFxKUJMYK++Q==", "40b713e3-68f1-46fe-9aa6-bfef4749c883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55689b97-b89f-4c02-a684-c2cf1fc4b417", "AQAAAAIAAYagAAAAEN1tUU3obLX3eDbRmNBrj1GhIvpRi5eCw8/h2B4kM2dHwRZRxamTio0V+1ecpiIW0g==", "9784dded-e7e9-4781-b42d-845e3f44b103" });

            migrationBuilder.CreateIndex(
                name: "IX_CoursePerson_PersonsId",
                table: "CoursePerson",
                column: "PersonsId");
        }
    }
}
