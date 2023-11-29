using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddEnrollmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f46a9169-6ad9-493f-a7fb-0b7b4eb97458", "AQAAAAIAAYagAAAAEJEb9Nboa56X/YEa0evzW3dfvtPuTeT1wxIGkJNS+KpprCDVZeYjpMgcr24hh4A12g==", "18209b1c-e4b1-42c7-845d-524395f91ece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "491e6206-4275-427e-8b1f-fc125ca52e8d", "AQAAAAIAAYagAAAAEGqD30l4jhahOjEvUsp6FySr8mvF1fV28Xyd+uRoyNS0il5hnb4kwh8wXpeUx5y7Dg==", "252cedcf-11eb-4925-82ae-21dd68ba779e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74a7e6ce-3007-4983-aaf8-4886de007688", "AQAAAAIAAYagAAAAEGJWAFIZypIF/pRo0+xJLesoHhZKlUdz0VMVFaut4o+uS5zLt71V241KEcWQKICpXA==", "397ee7ee-9e42-4f2b-a49e-b858aa65ab82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c98a4b56-da92-43d5-a0e7-6ee31874ac9d", "AQAAAAIAAYagAAAAEDeSbij3Rfz3XM7HWkG1A24xdRM5/P5VinXC9fMUFKBviNToOwoc3aMyM6KmlitKGw==", "982bb696-566d-49c1-8d38-cf88895708f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa442c2b-ff43-4ee5-82a4-365beb084413", "AQAAAAIAAYagAAAAEMEovfJPA4kYmvUFxz6rw9YH9+JkoWHVSb2QTHKl6JlpYBrHfHvwPPbeegrZ+cwGOg==", "e003a153-0871-4890-9ea1-67f4819f5963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "948b2768-0177-46a5-a35b-9194359adf52", "AQAAAAIAAYagAAAAEI1po+FjL7G+nsm5GoGooYLeU4pbHjKTzFDKF8MVNaIZEIaqbKJQffYEdCUy4zWO+w==", "7d388721-0a11-42fc-953e-7cbf53dbc917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe36a30-fdc4-4716-b708-1557414c10f2", "AQAAAAIAAYagAAAAEGsjDdO6b/N6RFt1eQt8dTZVGwM7xhGb5Y/87yLn9zWumU6LkYVCkp0VtpFDxjF+8g==", "b63bf1ed-c691-4c66-9c2e-5e9aae448c1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7a49b7e-8c45-4ceb-b171-6d6083c9ab7e", "AQAAAAIAAYagAAAAEDkVzNRWrWP39dFe5WUFOFqrbDhVtHHXfm3zfJo3XRcO/IluiZ8H7LhYHcmaEEgpVg==", "8c318867-f1d1-40e9-b996-5594f1923602" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af07e05-5476-46ee-a10d-651f9b567f02", "AQAAAAIAAYagAAAAEC5OQulxRWP9Iwo7mcQg+FMH+mlgkIV5UQPvKw3+UWcx8I1yMEnXHQmjEXEYNd+VXg==", "2bead9ec-9553-4814-9daf-25acb107c71f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05030046-70b2-4b0b-bd0e-da6dfe221eea", "AQAAAAIAAYagAAAAEN+FCBKBC6JxTV81skRbub00foOGMSpRju11te5MmYmfaPpC97EOkf3ZkzvsDuw5IQ==", "6147af56-3846-4a6f-84cd-8a3ba7c36f9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ed4171-eb5b-4369-abf8-04e4b639de5d", "AQAAAAIAAYagAAAAEBNiPaIDPdIBBp/eLIFLxikrsqQoPIauzgCubQ96gUWxnH3Diu+4bpaET51TDcm9jA==", "b6488dbf-ceed-4ea2-992f-f96a15384264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d9acc16-6afe-4957-a837-671e3c664a7c", "AQAAAAIAAYagAAAAEK3ojRWGiP9ibBnfrn4/PhiY9maMn1mTj9YNmrWzPZwTVYmLayvO6DIAA/ZmcUeolw==", "f6a97a3b-f9aa-4d64-9714-4eead12dd57b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a1c22dd-61d1-4a69-9782-1dfc01c13eed", "AQAAAAIAAYagAAAAEDzEuR2gGWlbQHfSgay6c5MYDbauZQ5V/kLxBawsZPceSjfA+9EFo6rG/ndKLknEsg==", "ae6337f0-20ad-4a66-b564-2d055efeaae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "712a30b2-69d5-43b9-8d27-193a102c159d", "AQAAAAIAAYagAAAAEHeX7t1Rp+EQWdebRwQw3QRPjx3Mkfvi70bk7hW6xsI+exuFzy7Wg6/v7kM1rNAuXg==", "53419147-9a3a-4e56-85b6-9ff5ca986a57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "738f269e-7fe4-4519-8887-3d2bae49d6b1", "AQAAAAIAAYagAAAAEAWKyEm7+Wr/fhnUh3irXzwthn4Tl/xgCcovM1X3VbBraUsgkKtGGSyjgbV/u55zpA==", "797d7542-a47f-4c49-86ff-8aca313e4289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "741007f2-8e77-4582-a511-3de1e7f45c4f", "AQAAAAIAAYagAAAAECs+bN7yX+yTD1XA9m6va7FWpFDdBzlRXQ+EU+9AXJYnkZbRLWyidvIlz768u1WL+Q==", "406d3b98-213b-4d57-bbd1-7edeab73f359" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7db9ad4d-03ec-4221-8878-8e43dfafea04", "AQAAAAIAAYagAAAAEMAXx3P4l3YycAIaJ6iuYgobuT4AV1ceMUgKQ/ENIIFSiEQKc4guLAOj06pocWurMQ==", "a62215ff-9e86-4831-8dfd-de4856522057" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df34ad11-32e0-4880-9f5a-4a8198bd7e05", "AQAAAAIAAYagAAAAEPovfVBtiWc85mfW+IKSRtqJ7t6dpLY9vApN7FOzXvoxsF4WcVvXJ2RPtJW/FFaP3Q==", "b14627d0-d88b-4c03-ac54-3e0be1dcb9f1" });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseFK", "ECTS", "EnrollmentCompletedFK", "EnrollmentStartedFK", "EnrollmentStatus", "StudentFK" },
                values: new object[,]
                {
                    { 6, 11, 160, 3, 3, 0, 18 },
                    { 7, 11, 150, 3, 3, 0, 19 },
                    { 8, 11, 165, 3, 3, 0, 20 },
                    { 9, 11, 121, 3, 3, 0, 21 },
                    { 10, 11, 120, 3, 3, 0, 22 },
                    { 11, 11, 155, 3, 3, 0, 23 },
                    { 12, 11, 135, 3, 3, 0, 24 },
                    { 13, 11, 130, 3, 3, 0, 25 },
                    { 14, 11, 109, 3, 3, 0, 26 },
                    { 15, 11, 155, 3, 3, 0, 27 },
                    { 16, 11, 134, 3, 3, 0, 28 },
                    { 17, 11, 129, 3, 3, 0, 29 },
                    { 18, 11, 99, 3, 3, 0, 30 },
                    { 19, 11, 149, 3, 3, 0, 31 },
                    { 20, 11, 115, 3, 3, 0, 32 },
                    { 21, 11, 120, 3, 3, 0, 33 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0b2bfd-8ca5-4b47-b0e4-e44a1912bde2", "AQAAAAIAAYagAAAAELx89lHeiAXBClH/OHQQ0z/ybG1Pyau2rBW2JkC5dy6wXNHU8g0Odvh4ALvMuPyYZg==", "64542817-ca22-439d-a7fb-291772f91e96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6019ffa2-c8ab-47d4-bbfa-9e3228dabdd2", "AQAAAAIAAYagAAAAEL5RjjnhOHMd9+MMdQ7LZluGEEnRGH4fkfP5i2S2dia4LUB0/c/nTlFbD/4d/WKyAA==", "24db881a-006c-42d4-bb35-e89c085828ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3888031-c006-4e08-b0fd-5936d3492e3f", "AQAAAAIAAYagAAAAEMdNSKWqT0yqzSMX33toq0PTpuZ10XKw3Wav7Zo8FRsMO3S9OWdMxzLs5eHGrMlqKQ==", "7d465811-1f7b-43c1-a755-dfaab7001e9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa936455-9c7c-4022-bbcb-40dad69070e5", "AQAAAAIAAYagAAAAEJKau2GqeJ9YYQfVrUa/oKYBEiijmNbMEeLRI0yGCo8sq9JTw6di5jk6VDt/eTezxQ==", "371a85d2-4773-479a-b5ea-70772cabb96c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11071e21-b67a-42a0-8c8a-333504dfdc7e", "AQAAAAIAAYagAAAAEMrVEIUC+fHh6CVQWmrOMxamIJmk5C2Nd+pP5JPm3vJ2bOnXActpAKiL2tZKYdDfMA==", "b522fce8-113e-4bfb-a70b-f9e01aa7538c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd6ab0ff-6c95-4b39-a5b6-5a7d892e8288", "AQAAAAIAAYagAAAAEJGjLgrqeGYGJbS3sTvKxUVCHUOb8XTh+rS4J3SJ+7KeIYPqT+4CnR8u07qGjgFw9g==", "1b15d791-70a7-4c45-83cf-c46b7a55a2f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f03f1ce-9a11-4057-a1e8-b2873fc163e6", "AQAAAAIAAYagAAAAEFboGgJsgjnQTuNhFUsbYNx25IEdWLqUBYlgWRkGFDx007hcXahuFZKzhsGUwMyZ3g==", "32dec4ad-c9a9-43f2-9753-f1b935473a2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96d7e569-1ac2-4495-ba29-bf803d9f0885", "AQAAAAIAAYagAAAAELustAyvsU0PpeVlplXP5lCgPRzUZWO3HVo1iZ9+p2Dsk4p9Q55LWkZIWN63pZOdIQ==", "efbe0bb5-70c3-473b-9ae9-12a1d74aec4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f818c838-5f6e-4ae4-b8d4-5f4f088f658e", "AQAAAAIAAYagAAAAEGu88J/FIMjb6a2VdHMPllqj/CokGxxGJJpNKgAonOdQvhnWjlEScZXwabIBudp+8Q==", "894954ab-9bbe-4b86-a897-935f9b5dfbe9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d45ebc-2000-4328-8bb1-6d68b8cc3382", "AQAAAAIAAYagAAAAEP0/K3fnZoCsWC7kpWYmhrXzgJj8j63W/FeeNRXw/i+HVp30ivuPHxYKzTWJ7ldf/A==", "5e1580b4-c5eb-4f61-8de5-f8565aae9eca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0ec0e0b-a9a7-4e0f-8865-dc1781bb48aa", "AQAAAAIAAYagAAAAECPuRTq9KNoKMH5NVWWk+Bfd2+uO7Iu9USDzvYQzOmm85QSBZ3Y6kScSbhwPrCSMkw==", "d10a0208-856d-477f-98ed-31670751ce9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9353d96-f5ef-456a-9190-c53e6a4afd69", "AQAAAAIAAYagAAAAEAiBWWu8j4LLVX0BMnJCtIU10TrdAEBISsEOLjgW64/X0/mMB/76ja3+dbWNagV7Rw==", "ce31db19-9eaa-4c2f-959f-286d81eb4d8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32a09d0e-7d6e-4488-9506-b4981a91b150", "AQAAAAIAAYagAAAAEClVWhdgpgddzrLY8wpEy0sw4Pqmd9rE7AQ8FkskJacWtMfE5ZZdMuvCPCDO57cXJg==", "b7106653-c43d-4234-965f-f8f56abf8365" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0287a4cb-9484-41dc-9837-4394bcaccb5b", "AQAAAAIAAYagAAAAECxLuOvLuJGcOkBmz8ed9HdFiQ/XmLJ549t8TV4jba0P5hA5QaUXa4OYj8j0VB/Wxg==", "e966867a-957e-4ce1-90d8-6fdeb1c3ee9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ba34437-120a-46ad-bf5c-d3025f00cb3e", "AQAAAAIAAYagAAAAENs4lQDfYZRuVSAoC4bl27IyeTbQb69nJs/AbBbwcpUvY4+ue0o/DTmsWiZtyoeYBw==", "1196503f-e392-4994-8c87-a97b22ace06f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb4ee685-4d2c-4019-9522-3087b075e9ab", "AQAAAAIAAYagAAAAEB5azoR05X+oj3bD36LlvrZpa4Rpd+VOJbdebSn+qJbzXMhlqRscO570Y9YcJJBm6Q==", "28dd9a24-00ee-4bc6-a0f9-be8a3cf40e07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94cf1d54-a883-4342-bc13-767b792cf9ff", "AQAAAAIAAYagAAAAEMFAj6qapgvSySGQ7MEUmYS9dhtdnLl2tIg7uIxsXWR4iblLBJghyPmv+jeBzNqZ3Q==", "c786a142-2989-44e6-af1c-0cdd1e7eba3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f8e6b0b-a467-415b-9fb3-ab15632d5f06", "AQAAAAIAAYagAAAAEG14WVR0rx81d7MDqqRgQE6RvH5rreYohE7Fr4O4qRHjM8TVdHC7vJPT7FWERGslxg==", "1a9ca2b3-96a9-4945-b5f2-ddc1c44385ba" });
        }
    }
}
