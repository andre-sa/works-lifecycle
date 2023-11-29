using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddedTableCADV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseAdvisors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    AdvisorFK = table.Column<int>(type: "int", nullable: false),
                    CourseFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAdvisors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseAdvisors_Courses_CourseFK",
                        column: x => x.CourseFK,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAdvisors_Persons_AdvisorFK",
                        column: x => x.AdvisorFK,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37921a59-60f4-4c61-9018-f5cad7ff2121", "AQAAAAIAAYagAAAAEP+ZNQpVBMVI07K1gOrYWtCPTzF/3zKD629+bQNa18Uoi1tN+3vfQ3D5pjIgAcLLQw==", "143a5df0-f7e5-41b5-802e-d9dc91caed9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e6a8f3b-2bd2-479f-bffe-e5e8e46ad04e", "AQAAAAIAAYagAAAAEJz3xpVvZs317wLA8J31B5IJmRt4/CS0SnCTkLFsX4rQ0IvKU39sPAm01EFwYVet1w==", "92209b51-5d30-4d55-a837-84bb0bc4722d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d5d5209-e8e3-4c68-8282-77b5f3d24389", "AQAAAAIAAYagAAAAENgiUT8sYvZA0jSdEcWJQS/H0ZNkxzw5rRlPFfw58tMvk6UeiXzEHTzN87667JghVA==", "4c496048-56fd-440c-a51a-2961f87c5148" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71eed49b-ad0b-46f7-84b9-70a564d3af24", "AQAAAAIAAYagAAAAEPiZjQVkVbv9mf5vOr8qFtyla2w7mS27iYcODwSrpL4E9/cMDQeqYioFz2L9ZQk6xg==", "b5554b73-ce46-4423-9774-f3f9431a9377" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a76f8e-0ad6-4e62-accd-c30b6e530dbe", "AQAAAAIAAYagAAAAEHqK7klPd7hbLu5sEJYeaVxZwSou5sXu2/ERumoHdJFFmNeHLK19kuIHYj5SQljOGw==", "09ce3eee-6307-4974-93d0-cb370db20675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3572e77-9aeb-45d8-8a3c-4d74f594ec2b", "AQAAAAIAAYagAAAAEEMUJ8NoY1R3pJFlHtIyf6ZPCOdtk2DD0KMtnBadTM1bWkIQGw6ir1VhWoUAmW+YJw==", "b2467c26-76e7-43d1-ba67-e8726a6df159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "156b91cf-1c4e-457c-b569-e4b18c5fd59f", "AQAAAAIAAYagAAAAEDOsHqbnEiDN0TW7P1/Ow8obEI3nrb1ssYu1ZBNKgKPSZnztojIiPn4Q4wfa2m5s3A==", "877669ff-83a6-4534-b9ed-34058cc9470f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b21923af-b33f-4925-83e0-d255be200ed4", "AQAAAAIAAYagAAAAEGkI2doZ2DqyA+ASKG2T1ou6kXDKo10Pr60oPAiGFRx1AGuuxdnfx1M5RFU2PEjzaQ==", "b68d337c-5614-4950-b627-6514aee7392f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b11a8aa-8cdc-4a82-8f05-dd97c8958552", "AQAAAAIAAYagAAAAEKZWsHEY2c/cuJ4e89rCCcOM80S9YSLSgByqMtlzj3OSPmUpbDpLjEnPqvx8q0r8Bg==", "d9fd8693-0293-46f0-84ad-d923aea2b8de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "952626ad-1c72-457b-b4f5-990b2a070d8c", "AQAAAAIAAYagAAAAELTZl4e0QpmZehGxEeQM/7n3m2jstW7O3RKdl3Vh+SRdujSPhtBbvf9cYtWHZsHFxA==", "20bc37a3-5967-40ef-86b4-daf4038b3542" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b80f823f-dc9f-4dbe-a0e5-a789ec3e70c7", "AQAAAAIAAYagAAAAEJgb5GOSzRLaePxWu0tSSbqYujKFY5Mq2PKFoyQ/0MNwhcI2Fn/LaW2mUBgevyj0IQ==", "ecc89d91-78ee-4e26-99a1-def8b2861529" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b8c1cff-a3b0-44da-8984-a891c5aa75c9", "AQAAAAIAAYagAAAAEAJ0OrMtkB4BDK/dBXNaNO05/+Q5DXu/JM2Lbh475OdEZywIrj7OZzaWfHMA0EUzYQ==", "4102231d-a89f-4e26-b4cc-02efb47257a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f67f6cee-3ef6-4b3c-8fe4-15d7dd6a96a9", "AQAAAAIAAYagAAAAEHZ/D23h9SnPHISolf1bkdV3t505Mqx4o7PiSE4opLblA4BGmQBqJE/Ycd2QAYWZBA==", "e2f289d9-00b7-4945-aab5-d21117e78a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecc57d4a-d622-449f-825f-8fac523fa498", "AQAAAAIAAYagAAAAENL/0injg6jJ4WmMHEpXo04nTJoL17xPJpn3gNu77oZoxN83WlVNkcUl48txXEUEeA==", "37ce5b54-d7db-443d-803b-cfe76dceef64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24456eb-3150-47d1-b1d3-5ccf45b3919e", "AQAAAAIAAYagAAAAEEZaj360oT502WJ3YrXFLMa72LKKS6uM8RDObLi3S3gF8BrW9TsWniK7CmGGevnutQ==", "3fc7b027-b977-45bb-a99b-0d5795ffd528" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36eb5869-1fdf-4ee1-9395-79a89ceccc30", "AQAAAAIAAYagAAAAEDcjXFln2vvRdZ6N9EPNSTrQ+N/6CRG9h5lDyhgp3XWw6EXCbpuZOYmrkjr6C4oBuw==", "3b8458ab-277e-431b-9143-c1ef39c924d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90a9ff37-d9a8-4508-8709-e03343932e15", "AQAAAAIAAYagAAAAEHOBsUC/+fIWp0jBas7yHwFTrDUJ7pIfNdhFrCW0iI3V+zK/zYOH7AUIzcQWvi6x4g==", "742c1ccd-264f-47cc-a09b-72087dc346c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf37072-8ebe-43a7-8d78-cc85bc534d5b", "AQAAAAIAAYagAAAAEJW5w6UoZSP5TDtrXTFbvSaZPw8BIPFqAKQ0oLyJ9VOV2MPKyjS2vc0sktXGxvcsDA==", "4ce507ac-6b73-4f4e-8d9c-a96c98f886b1" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAdvisors_AdvisorFK",
                table: "CourseAdvisors",
                column: "AdvisorFK");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAdvisors_CourseFK",
                table: "CourseAdvisors",
                column: "CourseFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseAdvisors");

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
        }
    }
}
