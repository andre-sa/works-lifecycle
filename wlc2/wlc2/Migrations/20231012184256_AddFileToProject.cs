using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddFileToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectReport",
                table: "Projects",
                type: "nvarchar(max)",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectReport",
                table: "Projects");

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
        }
    }
}
