using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class addAbbToCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7217fbe3-ca80-4878-bfc0-cb0c1f57ba4e", "AQAAAAIAAYagAAAAEKu+ztTxyVk6ad84/9s0k0pPjZJrnsnxJY4z9AxCVl2OBMGtTYPugOC8SBG34l4Q+w==", "be42760f-0069-4b8f-974f-65223afde4f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4018e323-efe0-4a4f-aa2e-b7c38180fefb", "AQAAAAIAAYagAAAAEOf7WA6cnbVJ95awVsA+HkmLOMUMD+B6RE5DnjPvaLlflG31+AUuyLADZhNfxJHcxg==", "313553f2-b07f-4be9-8bd5-b5280ea89b4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b08d38bd-5a0e-4ec0-8a04-7cdb8fc81e2f", "AQAAAAIAAYagAAAAEBLIQbkHcX+7a9ZdWo7JNCx3SZHS7EQMJWXvYOgo/L0B2Fl2DK5flmHk9KLile40tg==", "5ddd21aa-9d60-4a4b-bf16-a03835c96e38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02311475-9998-45ce-9865-707241e6e8f0", "AQAAAAIAAYagAAAAEHDWrhikEcCRbTon3w7cOFSsRGjNk/24Txt+vGN2EEMNTYygJFIrD7l84Z02dPMDGg==", "c8ac003f-5e38-4da6-8733-919649c10e78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5005b9df-2aff-4031-b53e-7d55c47cf841", "AQAAAAIAAYagAAAAELyqIpFEUBPxUgm6l5tvprL1CDxJVAb51PdTwom3gChA45vk5hSJIRGTQ5gZzUoWWg==", "51c65d0e-8ca9-47e6-ac88-524b8e87f5db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb62fe6d-2339-475e-aabd-4e03d9aaa2b1", "AQAAAAIAAYagAAAAEAwBwB3j5dnntm0tKeooJSIONL1COUKQURaihyMixxee6lweLACuVQQPeU2/cSZVqA==", "e60d213b-1089-43d3-a6c4-ab8c75f9ca9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49381299-7c26-435d-bd12-f51f5f8d61ef", "AQAAAAIAAYagAAAAEIWqbpUJfTodhB0PXaNnKLI3yj4GsTDfatjsa/shV78OFhcdyHXKSOHZIjlQY/HnPw==", "170657d7-4f59-4620-b7b8-e02132235651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06d0a544-33ba-4fb5-9f37-2c613235d537", "AQAAAAIAAYagAAAAENX5peLLmr9yFpl+TwltZpZ2rD6ANhxpcjY6ZXiA0x1xPWaakdy3tQ8bcTGBUWKAXg==", "523e6548-174a-4eb7-938c-22c270a6d667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "990124f5-edf4-42b0-9d01-545e00078645", "AQAAAAIAAYagAAAAEITcHHH39H4uzrM3DLBA8P8L5kzvBEhOIe/5TeLSyXnkaPogvIbghGmdII68M+TNKQ==", "397424f2-b0c0-450e-b1de-5dbc4fc99bbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96ca4b5f-f221-48d2-8a05-cfe94914e067", "AQAAAAIAAYagAAAAENiWkHZJlg1HwMci2/zn/9K8G7/ifSZ+aXZNvG9W7sETcIEaJ4u1jO/TYNY+YoXDtg==", "0620cbfc-3302-4921-bb83-b35ebc843ece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b041a7-5514-4fe4-afff-8897422e89b0", "AQAAAAIAAYagAAAAEGofxJkgdCgpVlXUxr65RsC/iQpCiABICfecE3wkcBSUhmPIOH88Rb5U5kBePeHdpw==", "3c967616-8f0a-43ea-9592-a4a2d84034c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a30f2b2-a739-4977-b50d-73252021ab43", "AQAAAAIAAYagAAAAEEkJrEFNCWv0oHtaWJ5yiVZcHhoySWm0fVF1SHSzIh+rzBmAgNqlzda9l9yqTZh1lg==", "bfacebae-63cf-4220-99a6-f69635ddf148" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff976d6d-ccc7-4834-a146-3f52e26da16e", "AQAAAAIAAYagAAAAEOTtegM9CJXPshUxdJVDqHdvD0/syOb2CNQnLuLpli2TH/+vulyC2idE/vu4b88vjg==", "4ec0a62e-2e80-402d-91b0-2d6248ea258c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf99faf-77b4-4677-ac8f-1fffc3a3dd51", "AQAAAAIAAYagAAAAEPBM+oTi/zW8+t9Hf6qsL3IE96LzrYw+cq4TD2NamZdaCydg04nkYfDw6IaFbZ3/tg==", "3fcdab46-6802-46c9-91ad-8458fb033bcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef051a33-f48a-4e4c-b2f5-cf4f97de1de6", "AQAAAAIAAYagAAAAEGJ/8dli4q+A+hdwcMpNOkZJMRdCEMSw5VBtqviMt9GgmYF6nWjmdII0sssxKKbogA==", "0656e30c-6751-472a-bf13-b8faf3cbe29f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc2e0889-88e5-4ae8-8a0c-91af494a78bb", "AQAAAAIAAYagAAAAEDhOSOpb5FYXjeNgoQAerE79TgSAt3YvZmlhKDbucmuA7kquuPqk8PYxQPM+p5KjWg==", "655e966a-8890-4cd6-9df8-8d5fd4335d15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "389139bc-5067-4e44-b710-1df3cae611a7", "AQAAAAIAAYagAAAAEPQcUCEMIgZhyMc6MSIkNpsqs3NcqWJ1gGjca9+gNIK/3Ik8fSj7ap33kJGUWDmodg==", "67f54527-a7fd-4710-a680-11ee9ea633eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "351534d3-f621-4ddc-b0ff-b26e19811455", "AQAAAAIAAYagAAAAEFZ1Ib22p1pFP0a32c+1t5kX4couJyWQEpfykg7P5kLGb86idK0E8pu153oBKNjGnA==", "70bcc628-e8da-46b0-b398-53352142b7d6" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Abbreviation",
                value: "LCD");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Abbreviation",
                value: "LCL");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Abbreviation",
                value: "LCS");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Abbreviation",
                value: "LCS-JCE");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Abbreviation",
                value: "LCRES");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Abbreviation",
                value: "LCREA");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Abbreviation",
                value: "LC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Abbreviation",
                value: "LDTAG");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Abbreviation",
                value: "LEC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "Abbreviation",
                value: "LEEC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "Abbreviation",
                value: "LEI");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "Abbreviation",
                value: "LEM");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                column: "Abbreviation",
                value: "LEQB");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                column: "Abbreviation",
                value: "LF");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "Abbreviation",
                value: "LGTC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                column: "Abbreviation",
                value: "LGEO");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                column: "Abbreviation",
                value: "LGE");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                column: "Abbreviation",
                value: "LGRHCO");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                column: "Abbreviation",
                value: "LITM");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                column: "Abbreviation",
                value: "LTQ");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                column: "Abbreviation",
                value: "LTGPC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                column: "Abbreviation",
                value: "MAIO");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                column: "Abbreviation",
                value: "MAPHAR");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                column: "Abbreviation",
                value: "MAF");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                column: "Abbreviation",
                value: "MAGAI");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                column: "Abbreviation",
                value: "MCR");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                column: "Abbreviation",
                value: "MDPTC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                column: "Abbreviation",
                value: "MDE");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                column: "Abbreviation",
                value: "MEE");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                column: "Abbreviation",
                value: "MEI-IC");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                column: "Abbreviation",
                value: "MEM-PPM");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                column: "Abbreviation",
                value: "MG");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                column: "Abbreviation",
                value: "MGRH");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                column: "Abbreviation",
                value: "MRU");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                column: "Abbreviation",
                value: "MTQ");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                column: "Abbreviation",
                value: "MTA");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                column: "Abbreviation",
                value: "DPTT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d464403-4ab7-4cea-aa7e-5bbc90b803ea", "AQAAAAIAAYagAAAAEASGMf/8+RMf9qYBUfzs/xty3wCIVYtcIeflKGV8GknMhsQon1Qx0dAB8CR0s09Y2w==", "e5c436de-1d70-49b4-b825-009e6344bea1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c92f7944-74cb-4e42-8657-d5fe0b63d633", "AQAAAAIAAYagAAAAEADvw+/dDZt7GF7wBw36jOwkBmcKkb2g36X6By//d7HSWo5RQQp0Q+ptli5UqYat0A==", "b0626588-d0a9-4754-8688-f743d04a7da9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "052a16cc-92ff-46a8-a927-0c1682cd3922", "AQAAAAIAAYagAAAAEJveISYCEsOq4uRjzqgffNX6PUKON7uxx1YsRoO0Bxtr2t9doTYVVd5UBwVXu9HV7g==", "85c3be79-e784-40a0-8ef7-41eb48be5a0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fdeb613-c802-43d6-87c9-2f42ddad3f91", "AQAAAAIAAYagAAAAEGVZ4Z6LS22cpWRJ7GArThdRDN6d9y4QDUhzgv/mG8Wa4FC86IRo3LCCjNftbg0E7w==", "bd4e5725-77dc-4f14-b825-4010115fb2bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0eacc86-2038-4ae6-86d3-b5fd7ef95286", "AQAAAAIAAYagAAAAEEUo3QXZWhONNytVuddDfLJZsMSmgld9J6+eD0ldCESo6iZPLD+fkoScbXAr8GhtyA==", "651bfcd2-4521-45a8-9ad5-dfa2e9d32853" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9bb0d6a-0c27-40f2-8d92-1cfb8ccbb256", "AQAAAAIAAYagAAAAEK0BabIU/59/KJHNiByD41tKrmEcmx+ljCvd5/Eg9VNhOBzTRQPmbd2+SLuL7cG19w==", "b292b4f1-fe34-40a6-bd66-7394888e2c7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7179be66-1abd-46d9-b108-05d8a6da44d0", "AQAAAAIAAYagAAAAEMTQbKb1FE9aSqIbS/0axTBhQ1+SVYiVwcwFH4ZcfVwlOFnYaXJWl6hy7IHV+Z6ddQ==", "23dc1cf3-749b-4eb6-bca2-7fb244f875e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1f1630-dcd8-432f-b551-582a07868fad", "AQAAAAIAAYagAAAAEHGa4VGtDTjoOjpE1dAeXiKgIRB5erP5i17gKsekmxG6SeFPTwRf8lHylG9h816ZdA==", "81eba161-b247-493a-b5e5-dc2f98a36800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dd46253-745a-4116-aded-710628100720", "AQAAAAIAAYagAAAAEHwOFzxOn9cjJ3tNY7olSlh25hazNWVmL7L/4JdUmO5ic854lJkjmrPLX9uIhgbaQw==", "4ec2e1e5-74f1-4233-92eb-2fc67a334a1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "114c5431-cde1-4da3-8588-af59ba9ce6fb", "AQAAAAIAAYagAAAAEPKvFWrQVZfpCMp02i6BqEkkbytDGLCeV+z7V6ItE2KhXAPuu1WojaarkT1dqjPiPg==", "02c19769-7aaa-4df6-b070-ef1462e7ba24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "275e1b7f-21ac-45a8-b016-b90cefdee266", "AQAAAAIAAYagAAAAECUx2CtjPA6+K7Mh6yc87SiLx7sDXtaz/E0bOiiWQyVx3OpzQX5MLIVJXO6HzAevAA==", "61463ef6-8d2d-47dc-b456-6d2d5f4b0fd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6a0b40-732e-460c-8a75-2323530f9f61", "AQAAAAIAAYagAAAAENgtoSVxsZvXKIY7jewg2GwNcwwOuXI2HxosVgNyyJd1KlmWMdFqQttaY+xkIQmxzA==", "dd9c3fdd-46b0-49a7-ba6d-39740f7eb5ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66a7adc8-6fa7-45a4-a44c-74f7a8b0ec7a", "AQAAAAIAAYagAAAAEH3cpAwIrUagNjkwaCs9y14fyMBiKLhHqt0LcASlXvNu5S3/LbNOiXsliE0gwDEjaA==", "8b9e6c3a-d92e-4671-8ac7-7aa4189054dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "153a336d-4ff2-4ae5-8435-11f8fd3b7ac4", "AQAAAAIAAYagAAAAECOYx/MPubUpxI8ZC9irs00GHWmOP9BhDi2705fp4ypNC0JvQZQFGofGBrEVnHkSQQ==", "34aa9339-96c7-4a65-9857-78f16d0d1a46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c54c563-6269-4955-a45f-930f68db6f2b", "AQAAAAIAAYagAAAAEK4vEEC+A8v3IBphRkvkcMbWadsBRy4PVAu9yUjXLlEPrT10DRg2rbcBUUffnMMfLw==", "1b9fdfa2-187a-4833-9e89-66e30864b296" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45197faf-6d4e-4767-b33f-11e8f80f3e08", "AQAAAAIAAYagAAAAEDt/HLBuMKsxhP1Oy6d4Vf4jdZCk7gHhvdmN16Y0cur/oMnQDbgr1yxdIhj74g4hDQ==", "29e22551-b604-402f-978f-d966c172da3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff9de7ef-82f9-4e04-b48d-61f8c26424d8", "AQAAAAIAAYagAAAAEOU6wvf7kpHQ1Ux38H1stJfKaH+PyQ5C3oiBN2vj7G+ztc3ukDRnnH0Yaqwx1/3zNg==", "b4a4c824-af57-4eae-8fd5-bf1caf14f694" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92995b54-d68e-421a-b484-57cf3c0d8702", "AQAAAAIAAYagAAAAEKHv2HCEPkRSYkIEaqP7SkBJdszefqfeUcPjTb+m9+Bw6TBrrksDyG8nvTln+VbTyA==", "e65906ff-d9f5-41df-91f0-075065c01146" });
        }
    }
}
