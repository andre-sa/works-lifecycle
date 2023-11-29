using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Courses_CourseId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CourseId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "CourseFK",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15c79cf9-26cd-48bb-b628-830e8096a65f", "AQAAAAIAAYagAAAAEJT1vNDmkSp+O7Kw7o7vrkIDuMORriGd8GMkGP1w4SmFlTkKq7kgvL/sjlhKPcazOQ==", "251cd98c-abdb-4641-ade2-ad482f284454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c29d0a70-7b8e-42ae-8119-ca6b36d3a2e4", "AQAAAAIAAYagAAAAEKIa+MoMWDKKVS0CHMV3DkQjjU3tRplI42LUZJVqN3FKocKRmU67kr07d+g+zHrolA==", "f537bd3d-f5d1-4183-9952-0c2af9af22ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b707909-0a7c-492c-9918-263754732ff9", "AQAAAAIAAYagAAAAEDBJzLMR9m8JAAlhrr57ZuxfD9gV0g12fll9/+A8c6HN2a2Xucfn4toqVIB+lWueHw==", "7ccb1743-496f-4406-a0f9-6f0051dfc720" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e884a386-b213-4162-8e99-b45d73190a08", "AQAAAAIAAYagAAAAEIFaMhaQYrqpGde8H9FfZyxFv7TliP6bObFApUuE9FKaQ/lO/o+EdCqJu4LrlD2pxw==", "7ee19073-6dc6-4be9-a99c-09a2202073ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f923d034-e733-4b3d-a9a1-4d86b71712dd", "AQAAAAIAAYagAAAAEKc3l/zazQaoWGFP641kYoS53LB4XVjcZ4H1EaAKPhSZYgZCuEzBD/zge9sfDZYBRA==", "74fec151-c00a-450b-9616-f31cdbfdfc1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8efba12b-58b8-4abe-8ca9-28a17172c40e", "AQAAAAIAAYagAAAAEIO71zMqd7QQncItdOxUO96hodVZlpoVlvcELoCr5LWN5wxmSKlZx1d8/z3ie9YHdg==", "571ac900-c27c-496d-9207-00300cb8c317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdbaf7b9-0e4e-434b-809d-d8fb7fbabdc7", "AQAAAAIAAYagAAAAEMNlHU1PFgkSRtj4sJUiW6y/yYUD7aNyNrdHuUezy1hT5XhqWn1cBZJFu2x7bYU/2g==", "1d7a38a1-2f29-42ef-b2b8-8df14bdb0d35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e6ed7a1-7040-4cb6-aa29-f57b7e60699c", "AQAAAAIAAYagAAAAEKee2guCzs/V+8YR3MhsD4OhlvirFhwHXI9Ki6eOdB3tD1WmT0rdoYkuH4e76AlsLg==", "c3045a28-ac7f-4df1-97ea-18983fdd2b14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b908e258-882a-4e90-aa65-ce47e09e35c8", "AQAAAAIAAYagAAAAEAetmxSTiP1n86VEIWefxbuBBHFInSPMrvxZJNMjv78JytBcShbGhFxlldIJ0uUV/Q==", "b794d049-0215-45c2-9b50-38701651a7f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2440c71-1676-4032-9a34-73ebb101d4cb", "AQAAAAIAAYagAAAAEIclP/+ATS8z5xLPRXizL3nAiCWcFc+EZKakvAOFB8hlXCdMHBM3dRbYhsY2gPLRPA==", "1b053198-6f56-4e72-8062-72b0ea0e0684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "429111cb-3abd-4c24-84c4-7160dae1e8cc", "AQAAAAIAAYagAAAAEFeBHzOFZ3pzmFOUBwU6rtfXG748NgZjTtz+i7qMKQTQd4UhurX40vlrqFTUbrOM9A==", "db4cde46-f277-4924-b0b9-8c1334e15eb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c3224aa-0ba3-4148-8a36-db36deb6cd3c", "AQAAAAIAAYagAAAAEHyIBM/O/dtl8tFObHaulmB0G4VoX7BO7YnA4sCPDM35hfy/WJghH+OQJilatjVT7A==", "39c98268-5a2b-4559-b45f-6a69aa1dcf34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad6fc147-9954-4bfc-9844-b3973e3f6999", "AQAAAAIAAYagAAAAEKnpm95wEOyQThqGeXm4Inzwa6DPNyfgMLyl0q1hSTHvFWZpVEvEHGhfI4RMqHZGFQ==", "f9a557c8-98fc-4cc4-8670-f019406608c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4c360f-8981-4350-9d6b-e55bc3ed07d4", "AQAAAAIAAYagAAAAEIMXIsbgHkLMYplAKPwJAVuQdTvFmaZRUkWK32Y9NCWvxMoXdbmj4WPlnWXluq50qw==", "8a53eece-5092-48e6-be65-f3f114232188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ba393b8-77e4-49d5-99dd-8bb41ebde143", "AQAAAAIAAYagAAAAEF5dZnJDBrdfQZqycoywFN6cCD77A1/WANCv6oyRoPEYotq1jF0rymQh41jiQ8lpOg==", "b558fe30-dea0-42e2-acc9-0d70a8a7ddbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e9a097e-e726-4391-b42b-dbc0fca10221", "AQAAAAIAAYagAAAAEFfzmG1HHL6R4xil82kGzl3LMVuq/ci9TdtDSc+eN9Kv9ik/Q9+VPmd9a6t0ilCiww==", "571d8b59-d345-4a32-934f-9783014233c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f56b964-1cb1-40ba-9b58-ce4a2c4da1c8", "AQAAAAIAAYagAAAAECddzQBQyFkyPJxX0reIieyp30ZzdX0/wKq7hT5rJK07o3kJ/zcUNulYQFyILCINcQ==", "87a99d09-5fd5-41df-852d-870d0fe1f0eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07fb5850-53a5-4950-b94f-b6e06ab781c8", "AQAAAAIAAYagAAAAEIW88mPJ67MG5FPrGGW/WxEGS4yJnd/UMGhaJeLAp+WLxvzFTdg/Syn5VpzSXyuG9Q==", "f11c3a88-2050-41a2-b275-3643b2b66df2" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CourseFK",
                table: "Projects",
                column: "CourseFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Courses_CourseFK",
                table: "Projects",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Courses_CourseFK",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CourseFK",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CourseFK",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aac99f5-a0d4-47a5-be61-6f19b89552a6", "AQAAAAIAAYagAAAAEOkEBD7fLlJn0K661mjQXsilbOmUc9eTa2neShDDeLsk0kGsZd0d3nwhRtLZ7opnCw==", "4cea9512-4992-4370-b85f-edaab180f694" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "987b7178-a158-4ab4-8fa3-1a41cb5f3be0", "AQAAAAIAAYagAAAAEFqbU1ZZjnXYxe3oR4DDkDwDwbY+/3fMFsFx0ktn+bM2ojhWAYhgELd7YoFz3eJUnA==", "6a69e69a-b53b-4c5a-ae57-126579bd1382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215e5411-f5a0-47e1-aafc-03a9612d608d", "AQAAAAIAAYagAAAAEMkTvwl9Mx1DqmVxTnZ4xN2qjLpvmc4/Zc24ytnPJDA9NBBlJDMzgDKCwJpCLE7Sww==", "3dc01bd8-d884-467b-89be-9f8efda96325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52df83dd-8432-407e-9a67-888184798c29", "AQAAAAIAAYagAAAAEIYjA0PvAmzBw+ajMGAu1NRdB5NaX7YqRbVGkf7mrRyvA+edIA3Cu1SaTINpY+VyUQ==", "2f2d0b30-9b2c-4dfd-a58b-4ff3cd094a26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c6638d5-3b77-49bc-8262-334d8d390c54", "AQAAAAIAAYagAAAAEF6P86NzRxyi0MdxAt/ZwG8V3Zg+Y8MEvNF1Nblhme+eH7g1ixlHJWbUG3zgc98uDw==", "0a98544b-eda5-4276-bdc1-98e3f951d577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3233f07-d1e0-444f-9ed3-49cdbe9dfd0f", "AQAAAAIAAYagAAAAEGGQ26D61KmoHpahaFSxTnXFe4PJpGm9fZRTHcWcxPNJy1lktVF4IRFxsIF+uaz6zQ==", "8c37e91d-ecde-483a-adf7-eb68b0948e7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0ac1428-af8c-4388-98b6-4f508dc2da4f", "AQAAAAIAAYagAAAAEFEK9QKkEjg78sMvjb5Iu+mfFemIB0GhDz2dHS5lMGYSu3BMErdBOE+TEtgGImkyEw==", "87a40b33-51ec-4982-be95-0bdd0aa9e59f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dbfdff8-e925-4f8a-88ec-4a29dfeb8ee5", "AQAAAAIAAYagAAAAEBfMfF8+aeT8qTYGgEK4EwwX4pcjZBTcxd2pJj4Q7Ar6GBwam4RaX6gV6HmbvxSkyQ==", "c9ae89ce-3d0c-45c9-bf18-53d03d38ed31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d22ac2a-cb49-4d9e-9d7f-4ef104513f91", "AQAAAAIAAYagAAAAEINx1jvhvA/v0YSCw4H5d+7s4Z6FOGmC9S1VOpsJAzyu9MMyimCcZHga7d+rXznVHg==", "fcb63a18-e7d7-4647-85fe-5c2378a28251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69939d99-70fd-40ad-a276-031b809bcf1c", "AQAAAAIAAYagAAAAEPmWEhfS2/Dc6D7fzciUTcX6sCk4MJAWrE89TzSYPzNQdPlj2dUTvFbjBygprbcg/Q==", "461f0056-59e5-4cbc-9591-813b4210b7a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5972499d-4cde-426f-a624-b4da35a4b8fe", "AQAAAAIAAYagAAAAEPCVIZjSYsJlrUhwV1+26SSOk/amSlMNBgu7O3wXra0RfTdx7ZEooMD2GrkdqrVdjg==", "2692d232-3840-48e5-b99c-905e910c802d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a7d7b14-802b-43a2-891c-aa8fd37a5a49", "AQAAAAIAAYagAAAAECRQOkar0P0Z9MNwBYNm56UpQcS3a9AGdy/opljGy6aRrZmPq2PwMPiuIM5oW1Vp5A==", "497bda2b-165e-4f77-a75d-b7489460741c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5084ec9-659e-4ed0-9317-ea9c6a7eedb1", "AQAAAAIAAYagAAAAELBtNmGdpOY6jcOD/R+08S15GUKkzS9Uej/1pT2YPTKpBb2Hw71nr+So4zPZ0goEwg==", "5124983f-8999-4c93-97e4-56a2086bc858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98151af4-cf4b-4cc5-a636-1e604540ecac", "AQAAAAIAAYagAAAAEBcxEsKwvktDH4TO2tAQONL0Q1AWD4jSX4NidGGsIFkJ+EkjSLjpu+Fvck8EIXczrg==", "e3f7ba5f-1425-4d05-bfae-b40649297327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee7f1a6-047c-4695-8967-0c24bb606ef0", "AQAAAAIAAYagAAAAEHK3z4P2DEzcK6xhsqk3U3n1r7dbK8snhxiMWXETx5LZvLJjq+7K7Ce9f3+SdgoPyg==", "d11244da-55e4-4385-b972-cea1933de842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2368b5-7d67-4090-9124-2bbde377ca5a", "AQAAAAIAAYagAAAAEMFXSjZuvcRAZn3GQmUeZQML+2yM0p7zMcOGPq6hdYR4Ri/vVAB83A6xO1iYqrMrzw==", "5a57e6e2-b082-4cfb-a54c-e86225f65f23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5476472c-d926-4472-911e-fadb1b18b6f3", "AQAAAAIAAYagAAAAEKWrLktruzdWinZ9d1s+k/X2e2IJppQdLmuaSLP4a7RPKvxk4d/wniAZe06VSkpaow==", "b36eb803-68b9-43b2-883b-76d0540ea86f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b9625e6-40bf-401b-a119-13853e8d5c51", "AQAAAAIAAYagAAAAEP/evfP1v8d26O3v/VwDlvmx9nwt48nRpjQSYo2MYxpfnGxj8vWvOiSg24LCupJgCg==", "22c0dfac-2295-4aa6-a48b-84a1a6efd53a" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CourseId",
                table: "Projects",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Courses_CourseId",
                table: "Projects",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
