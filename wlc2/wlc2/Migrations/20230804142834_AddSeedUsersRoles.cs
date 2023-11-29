using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedUsersRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "advisor", "1" },
                    { "advisor", "10" },
                    { "advisor", "11" },
                    { "advisor", "12" },
                    { "student", "13" },
                    { "student", "14" },
                    { "student", "15" },
                    { "student", "16" },
                    { "student", "17" },
                    { "advisor", "2" },
                    { "advisor", "3" },
                    { "advisor", "4" },
                    { "advisor", "5" },
                    { "advisor", "6" },
                    { "advisor", "7" },
                    { "advisor", "8" },
                    { "advisor", "9" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "709e164e-6e11-43df-9961-118c885263ab", "AQAAAAIAAYagAAAAEIgDta7es7TUFFmJ2YjlQCZqmDpSe4iYHHHQLsOl5Zv7qGP1rcPwgPb6Ao7qPfWyTA==", "9d97ff77-26c8-4f29-a85e-1f521d38aafe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe512c00-a42f-4ef6-8a1b-f901b228e541", "AQAAAAIAAYagAAAAEIUQvyLoYeTbyvk+I0/YsFimkSYx9hDjmm+dlmZcsl7sAX4ZH4zYR8TsIFKRGaVOJQ==", "b03ef7dd-4604-449b-b350-4effd9284f64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69efb9b0-11f3-406b-95b5-30ea36eaac2a", "AQAAAAIAAYagAAAAEOamtLviGwruyju6bQS9GChlP0fN5KYipQ6QtZa2yPUwMUGYVA/glYrD+2TLDuTH2Q==", "29ce44c2-be4e-48db-a5f4-87d413589dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54a1c320-a75e-4568-802e-3dae31877ce1", "AQAAAAIAAYagAAAAEK6NZgCSKGxzJyW/qQhC87LOc1GOovQsj0cwN56by92FBt/7OtbRc45pTGXvgOzl2Q==", "4351cc00-4697-438c-ad3b-ebb2d145c7fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "962efe66-bdaa-4181-bdbf-321233484f12", "AQAAAAIAAYagAAAAEBbLLrauNVfKMlkT+6tjsELh/vw0RpF3akST0F73VKOAt9FvFTQVxpV93DKA+owJ7Q==", "6c97a472-5807-4e9d-97db-3b68c063bf10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a1efa45-1958-45a5-b8f6-056949cc2500", "AQAAAAIAAYagAAAAEP4WDP/a6ROVDm3EOrtRI9WJDATO8Aa+lpDc4WI0whFklHH4X/vsxWuZwswPQKd4kQ==", "720dd867-ce02-41da-9a00-350e54f38c71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25716d81-2682-496b-8c0d-c3759bf832e4", "AQAAAAIAAYagAAAAEMoS6gdjX1CKkhk4CwPiBSfUi+eyoNouo0IMlvAFMVwlozY08bnXPbXu6x5IykoIBg==", "5ea501ad-ce49-4d9f-b15b-7071a87ef28c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a19552-1a6d-416f-999d-9568875fdd73", "AQAAAAIAAYagAAAAEG3ScIc7Lf2KGatG+HRSRlzQBzmi9luFl7aAk6w7B7EQ8DNnH+LvpuMI+33Ra5Sm1w==", "a7dced0b-0c9e-4e13-abbd-5e26aa810c49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d9104e7-d158-465e-9f6d-417c5f9d92f9", "AQAAAAIAAYagAAAAEJIcXuW2H5GBxIDP5jhXEIlc68byjkf/v0D7b/E8Hpe1duf81MywzadYFMDMR6GKKQ==", "44d60e49-ae30-409a-bb84-f773f5bd5aec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b216f16-7263-4205-b9a0-b39f820dca4d", "AQAAAAIAAYagAAAAECSiA7q/o406iq/FnrNNZVz98OhGL5dZDzU+FgOFmppGw121Djn0Afju+BINRQSnIw==", "d67fa652-e579-4086-9660-671616bcebec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ffadadc-9c82-4b35-acd3-9e5812b80426", "AQAAAAIAAYagAAAAEOTmYTfnExl1eHxkiQnRH+K+zUBjbYvo2AMp9+I5NWEW5PZds7DS2hJNkG3fzpE89A==", "fc12e36d-e24b-4b30-848d-7c62624a8536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67b1723c-0d8f-438a-be9b-13525b2624e4", "AQAAAAIAAYagAAAAELNmTydZVCn6kG+R98Fe9fjlQJAmrphkbIobQhaAp1+BAMT/ibQFKRdu/iG/AbVB6A==", "c13fb9de-4316-4b79-9613-f3750f7e2d7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d64d747-cd14-42e2-8036-c593a822f055", "AQAAAAIAAYagAAAAENGo6lRu8LIdZH55mbd7QEdQvk0lQecPRMTGGspnLYGukJJPt/0X83ZX0uusMwMJXA==", "40bca098-6d65-4f64-8032-4cd8be2d7a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65d686ee-6ae4-4af8-8b0d-8642d716b9bc", "AQAAAAIAAYagAAAAEOULqLSoypkXoLKDOSiLVgskuAtKdS3jybwpfapyDu+0TxOboxl3Hvz4cF0ujjawag==", "ac569cd5-5c65-452f-96fa-6b6c6e891d05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6854645-b457-45ad-8cab-3b7aa354a109", "AQAAAAIAAYagAAAAELr8/QDpdUK0qJaDp3LyFIvPNN3RfLpBn/drMdzP2psa4Sk4GDmdz8ySnztyQLw65A==", "1c757ee3-bab5-4029-8226-2ada1fc09915" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb53ad8-5af5-4760-a32c-9ec5a27fee11", "AQAAAAIAAYagAAAAEAB60fdhubHq/XCqRUpChnaxHblOiZ2fkix+4HUs1n+aFmavmwS7zixaGRAFw/8Yhw==", "106fca24-36db-4dec-a571-ae9f94b46950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75794c8a-81c6-4a2f-8395-feef76a53117", "AQAAAAIAAYagAAAAECv6eHe78FECzsCvWx9uoRV1CCNYHXZJp3Gkq1ohu9FvIXDryz0z2MEyZfSVLuR+6w==", "21fd89b0-27de-4fe6-b707-3bda8f920a5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74f95a06-1570-4ff5-a5b8-d95c6b5e1baf", "AQAAAAIAAYagAAAAEGwephYUVqSvtiIHbQAd7RTcShTwkOAeMa1y8tLmqsMJOGwkKFeUQ9kcM3BPXa8PNQ==", "363b8417-e0ea-4af1-9efa-efd4c82d7470" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "student", "13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "student", "14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "student", "15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "student", "16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "student", "17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "advisor", "9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "985afa65-e12b-41ce-ad91-d7b6d0929146", "AQAAAAIAAYagAAAAEI2TdAHMnR/+1dLO2DaMDV+eGZdCGX0jSPLm5pK9HEjsvpwN7Wp2yNpb7QHsxrqN/w==", "94800fdf-7c6c-4c20-8e04-45feb3eef097" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9b18817-8bbf-46c5-954f-0f4eb655c044", "AQAAAAIAAYagAAAAEFT6F4BPguaLhadzB/7E8L50eDNq2V0p8Agv/xir/ug/OoYKCHgbOKkiR6hqEXK0qQ==", "568b7f83-4d71-4ab2-a221-d905bcd2d9b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ba0e99-6ae5-479b-b2ac-28d67ad899eb", "AQAAAAIAAYagAAAAEIOBw3T9CLTEHI5CqJrOGqyVJficm+NL5FGQ48g1sHt+MV/vBXmg7PWRCQJKcBTyfA==", "4c2e2cfc-8107-4fcb-9356-867f12b1793c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe37a8ab-30e2-40d9-a222-b60c20139877", "AQAAAAIAAYagAAAAECur501eQtrFZy/N7dCZwKQQxO7+dZ3ZkMHEhDNsEeTH1T4sJb2We2wdmlGnnvt+/w==", "8c887554-8a0c-409a-ba46-e004f2fd3615" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aae8defe-37d1-4219-bf8a-2ebb2b1e176a", "AQAAAAIAAYagAAAAEJLH95+e3COmP0yZNolRff9mxdYYpSc8I+PkiUck62vyzg3i7lCfR80IFySZuTbYvQ==", "cc61ca61-fc25-4a86-a487-24aeecb91aef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3998c471-4f6b-4e8c-9695-41b8a1192cbe", "AQAAAAIAAYagAAAAEMtiM5QeeAt2205LZkoqvC4nHJyMFMfsX/Pw8qX5BF23JARn+vN0KOa4Tn+Zuoa3Eg==", "894be148-13e6-4e1b-a9ad-6694e9fee8b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9c36439-6bbe-4342-8b18-e00aee7b43ec", "AQAAAAIAAYagAAAAENQ5Hqq1F4Ah5OI2tGDBC9y3Xdb4KmI29ZNXVHzc64x2fbMSEkiFrvfRozcUhl/2vQ==", "4790b85b-8fb7-4502-bde2-71a656226cf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29324bb8-3601-4c1b-8ab1-b24c26cb1285", "AQAAAAIAAYagAAAAEN/T7YAgxyrMGEBj2unytMyYg+2GSji3XZLw+4VeAPPZWPy6t4PYnaL4mtxoNtQA+A==", "f87cae46-6697-4adf-9b5f-1ebbab034082" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e0e30e9-357f-4a77-a108-7d15ec2723ea", "AQAAAAIAAYagAAAAENd9RnoDYNscbltNVoLeQ0HOAuSrNIbcn+Se85gN6tNwQLC/trMpnsJ5p1kAMSLRGw==", "e0400e07-b730-459f-87e0-91d4536903c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb3149e-3116-4d0c-ad98-3e8fc97f41fa", "AQAAAAIAAYagAAAAEKaGf17xi8CXBnP12pYsk8FyrztECELbYq+JQQONLaZWTP8x1R7CrMR5boybA1851A==", "9f882a3e-3909-4f3f-a1a6-ba1ef1760665" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5486d267-a05d-4e46-a77a-21011ee03915", "AQAAAAIAAYagAAAAEHo9X4lRmptjbUIwGhQIIPfkmN1sH284MbwoHZCDIu0MtiW4DBUMDsa+NkqdJyC/mw==", "4ec17894-514b-4830-a1d5-a36c7340b013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11263551-159d-4cba-84bb-31c610ede08f", "AQAAAAIAAYagAAAAEBAqPBx6280SSU1qrocffrdNdIMAP4Jo0cNtKPXEG1oMuTCu2xkBFZ5Z4xhX7OAdzQ==", "af73d480-9bb4-4e8c-b02d-f3a29f429ec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d93a159-3cce-4e6e-b0b1-294b2890a443", "AQAAAAIAAYagAAAAEAn/iOKAHR1HMfF1nd2InsBB++hmBlqLOluxF7JjJH9NzeTjU+OtOYOa8VUkPblhsg==", "993618ea-41aa-478b-a53d-3c74884b6b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5678dc0-664f-4b5b-b489-fa2d21861d1f", "AQAAAAIAAYagAAAAEEfl34c2FJmSaQu/gau7A94M+mEFYWT+EzHJhx5ORg/T93crMvAP4PELpwRy50Xj5w==", "3e3cfe96-6156-45c8-bd52-77edd5d60ca1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e845920e-6465-4f39-8d8b-db2595a08105", "AQAAAAIAAYagAAAAEHPGz9yfrX8ES/2deUoqKLvPpjpBi+rgUuaY8zQdGGhpHS/6G3NVdotbmi3uW5OSFg==", "cf4d3cbb-86f1-46a3-b1ba-66a4ea6a24f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06f80fd3-a7a0-4a66-bbd7-cbc8107dfde0", "AQAAAAIAAYagAAAAEHUkkw56QL86ciLj4Uv1m3+l2Vb8JG2RzK7+WOwmDVix3cK7hIDD8OClwtlucmYmnw==", "72a015ef-12de-45fb-9f2b-35ecb309ea24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c3fc0e7-3f7a-4afd-a5b0-9e7b842c7ad0", "AQAAAAIAAYagAAAAEKSR2HQ/HT9MFGdVpOULdRO+w5BGVC1rgfuhXFn1ED1JPLGgKsrj8vW2/hJk4t4jSg==", "8dbda47e-5dd7-4589-8901-89b79786b1d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f983dc-61b9-4692-a928-c6e0f614e5dd", "AQAAAAIAAYagAAAAED9mZXTsB+XG/XdvN6/HmUh/agDU+lGQsXul/w8tZSAkzKmqBRtqht7Fifw5RhqB5g==", "2204c690-bd80-4bdf-9800-cad393b2052d" });
        }
    }
}
