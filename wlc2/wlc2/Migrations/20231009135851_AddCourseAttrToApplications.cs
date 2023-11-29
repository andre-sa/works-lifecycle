using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseAttrToApplications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseFK",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aacdfd5f-2829-4369-9d37-072bde79cc56", "AQAAAAIAAYagAAAAEGuE5vcuDJsdTdDqhmiEr04rnD4IboIohVhxPNuarFbjdNuL0TM+SrjOB2cTaoqlXw==", "a140d4c3-bf24-4584-9137-33295ba61494" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0fb3cd-8a5b-4040-8ace-2fd7063bae0e", "AQAAAAIAAYagAAAAELpw3Ru+9HoFvoDzmGEZtyOa6fMTnMKmPi/iR07q8s+xDHlje5Bw51t7KAb8s0DEPw==", "ea6bfa13-abf0-40df-bf89-1d3db85160ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5522ae65-40c3-4ace-b116-ff244ed20a5c", "AQAAAAIAAYagAAAAEBy7BWaFQnzvpnyzJTBuVBF9Lo11BzTQ7Ve6iOByHNHNCjQfZcm3uSOK+Fh3vAmGMw==", "4073f984-e421-4871-9bde-dc1a6ec80e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f59387f-5923-486f-8948-458e99709202", "AQAAAAIAAYagAAAAEBE9nYETWEXevG7WGTDc/BJM11l01kyC6GvRZ3XcHYS/s5+n1bUkpQ3TqtAAGGta3A==", "477ad60f-1bc7-410b-9a6b-37c0d67a252f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d3e9095-89ca-40e7-a5d2-f7ed86985b17", "AQAAAAIAAYagAAAAEISz2Xwcgyub8P947WG/qPM8Fi4xsDaZ4/To+QpDTrKugvb6f0R6VhTkm4F/Kb5wxw==", "05f5aa4a-6813-4f75-9fc1-8d0eb0ff2834" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64c343b4-9ec6-4414-825b-8e3e8c86cd92", "AQAAAAIAAYagAAAAEI2u7cEYy12QC6BlV95Uq1QXUQN9kviNg3FKJO1dkeuYhQkZpAOrvbq5z4Cn7Pd8zw==", "0d284050-2a97-41c5-b5c8-0b44b9871773" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "274a8a3c-3c48-410d-bc2e-6f0be5a718ca", "AQAAAAIAAYagAAAAECGyefK5fYB2hqWzFUJxGlAkzf/M7IVmcDd2P7AoYLTg+id62rOBH65tL/vUB8ahSw==", "dd7210d3-c2a5-4632-8e65-61cf1690ba09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467738ad-4a5e-4a42-b9d9-a86d5083e36c", "AQAAAAIAAYagAAAAEIa/WdtKGhgeJGyWqGpDnSQ8tzAIbLsD4faHSKgoHCRSFCmgP95ikfqD3ovxyspV0g==", "17a994d9-5405-42a9-83e9-17961ecf97cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9524688-49db-4a40-b80f-7520e3995b10", "AQAAAAIAAYagAAAAELuyCQBLf14ORUMAs7hvv2TP1Tg1H6Z1Y3oth6GEx3XeqKuXMs+ADqUiUYzBqv4c7w==", "f969a6ca-91e6-4a75-b41d-5fde815f6c00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc292038-f1d4-4a7e-94f7-a694c61b7a3f", "AQAAAAIAAYagAAAAEEIbtLaHNyz/WUtgzUbVrgZ02lClAiJxdwkLO5AHyaRva6sCzwZ0W4Z0YA1DKXvJow==", "78c3f048-65e2-4c12-9b12-47424c29eefa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "216a3a72-b3b8-462a-b1b0-45b3c155655e", "AQAAAAIAAYagAAAAEC2jwuy6pL4r5N3bNKyBXCoCKXgpq5IBdO3sWRNQ6hFNYajYX5+gzpTKnFBc9R7xAQ==", "a080ccfc-eec5-4d2a-8842-d01c2e007f5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e367b4e-7c1b-4d79-a942-8662a54c941c", "AQAAAAIAAYagAAAAEB70KrXNGN1Z5igXwzOcqnIcxxmXcE8xPgUI+7lnuIIM0P2HcvnC4mXjn/XlQp+fLA==", "07b9c14f-ab98-45b5-8d80-d411e75cd504" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "473712bb-a100-43f3-9f7b-5e877506bec3", "AQAAAAIAAYagAAAAEMIN5sHO166WBJ5g+t5OJs4n8jcBYfYsGjK2ft/WP4ibr13C4sphZqH5tf7lkQaeUA==", "f5366018-8e1e-48a3-88dc-a05cb2b9a8fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b1fd50e-2252-4a3d-bce0-88721b783bdc", "AQAAAAIAAYagAAAAEDYIY/V8fU4oaCArsoJP1YZ6R6rqHHvPxVlAgliExFv77Z25uAbvShGeIzQjiNfDfA==", "45fc66c7-082b-4958-aeb3-c9798295681f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0952105-2cf6-4c2a-abdc-eef927587a2a", "AQAAAAIAAYagAAAAEGFKoGEhl6Fz8o7JvJ96dZrvJC47aCyajFx0qz1C8NO7v/Zfy5fRrQIwrW8UV5zLBg==", "7484fdfa-e3c8-422b-8836-8a3bc8bd1e86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e2da717-1217-4a96-afca-b6e42d6f1b63", "AQAAAAIAAYagAAAAEFoAUHfo7zv9XlP3r+nRCyJGWeiNMiRExynH8qdsV1x3z4zK/2+JUBI09RAIeWOYRg==", "3d2ac6da-5dfb-42f7-993e-9ca9515a9061" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77260ef8-abf9-4a0f-825c-5d365ab8cb08", "AQAAAAIAAYagAAAAEM3Vs8DNy3bYiaZhHA+1MqzjlirHBsknj8mgiD5oa9qWKoSBOiyfUPifgvul03hR/w==", "59be8655-bb73-4ece-b758-76556ae9393a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7624ee19-2520-4c64-a134-275e6d2557a2", "AQAAAAIAAYagAAAAEOJtUrVdAWZXphRrCK/JcMyrxDGjORQIkTMd3N+gQt7ucBY62ojcYAfgG2Vzqswx8g==", "9168105a-3573-4bf6-bdd7-e72307ce65ca" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CourseFK",
                table: "Applications",
                column: "CourseFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Courses_CourseFK",
                table: "Applications",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Courses_CourseFK",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_CourseFK",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "CourseFK",
                table: "Applications");

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
        }
    }
}
