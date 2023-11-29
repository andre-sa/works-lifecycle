using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddAdvisorsStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dd15492-00ba-4979-a382-6a2bb5b56d63", "AQAAAAIAAYagAAAAEMxwi3qmqDaYiy1dA6/1BlfcgelCSHVhZq0OZ8vbXQHkjZvHwvr/PeGaOA8Awik6Xg==", "a7e38b67-29ee-4b72-abc2-80642333ae2b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "40bac0b4-c7db-4388-a50d-046628fde9b3", "anacris@ipt.pt", true, false, null, "ANACRIS@IPT.PT", "ANACRIS@IPT.PT", "AQAAAAIAAYagAAAAEBsw758YjmcWba0em6K7kSiPjOFul8M1t2PInJhFE4xGsVzPIZHNs/aXsXJ3HMN8+A==", null, false, "4020d5d9-2696-43fc-a275-b63328d42030", false, "anacris@ipt.pt" },
                    { "10", 0, "50d69fd5-0f28-4e33-ab98-f4067664011e", "fmbarros@ipt.pt", true, false, null, "FMBARROS@IPT.PT", "FMBARROS@IPT.PT", "AQAAAAIAAYagAAAAED2dz5wR7ZpyHIR6Rb2k9fgnjEqI8skbDHW2JenBYdOC3juySyie0xxNd0yyyRmjUQ==", null, false, "9add7bd8-12dd-4b25-ae3e-ff8e199b0616", false, "fmbarros@ipt.pt" },
                    { "11", 0, "5daca108-ef24-4822-80a9-7a1cb31dafee", "gppires@ipt.pt", true, false, null, "GPPIRES@IPT.PT", "GPPIRES@IPT.PT", "AQAAAAIAAYagAAAAEO0zi2vvBTFl+vzHCLZgHhVjJUHCTyeBKCBsjgUyPURTuXJ18xJeUrhwk8RC7lDOcw==", null, false, "70257d26-d0f7-4195-a5a4-3259a721971b", false, "gppires@ipt.pt" },
                    { "12", 0, "87d493a3-9b5a-4442-9934-ecc72f076835", "renato.panda@ipt.pt", true, false, null, "RENATO.PANDA@IPT.PT", "RENATO.PANDA@IPT.PT", "AQAAAAIAAYagAAAAECrVv3L3mPo4QjFvZzI60zlRFFIb/PWBLpbpGuEbL/Ix2fO8im38QUvUZBuEAkwIhw==", null, false, "26d4b90a-86b0-421f-a346-5cdb5abc482b", false, "renato.panda@ipt.pt" },
                    { "13", 0, "002b627d-3ab7-446c-a5e0-7f29d8689bb8", "aluno15501@ipt.pt", true, false, null, "ALUNO15501@IPT.PT", "ALUNO15501@IPT.PT", "AQAAAAIAAYagAAAAEOzca6A4N+hUjfxsfYzA9JXjivzdAky+X6h3iAA0BS/a/oXEzCQ0XIlUGts7SOdKUA==", null, false, "4ec97bef-cb45-4da5-92dc-33a9fe2b2162", false, "aluno15501@ipt.pt" },
                    { "14", 0, "43313139-0a83-4e1e-a55f-8d0e3e681202", "aluno20568@ipt.pt", true, false, null, "ALUNO20568@IPT.PT", "ALUNO20568@IPT.PT", "AQAAAAIAAYagAAAAEBdNeC6Od0yoqjwXfgswBf8Tw9VJcsBr2juTqyjwGYZUtP7s9tRhjtbSUW2WI+VRdw==", null, false, "1dfbbf4e-e276-4171-86fb-d144ccd98bd7", false, "aluno20568@ipt.pt" },
                    { "15", 0, "436196aa-72ca-45d8-acfb-3a48fe964d14", "aluno20796@ipt.pt", true, false, null, "ALUNO20796@IPT.PT", "ALUNO20796@IPT.PT", "AQAAAAIAAYagAAAAEFkXUxf73tbo8QHe1zx1sbkY4dQ/JAemA1ZyqrfaU15Ik8MsPBPlsWbgzy/NeCW4gQ==", null, false, "3f462310-d606-46e8-b874-e846cd9887e1", false, "aluno20796@ipt.pt" },
                    { "16", 0, "efd7d373-0b62-4b8a-9ae5-61249f979a30", "aluno21876@ipt.pt", true, false, null, "ALUNO21876@IPT.PT", "ALUNO21876@IPT.PT", "AQAAAAIAAYagAAAAEFuJxdd+PePw5ElNIvIwexEb4+CtUitI7yqk867Ca/V8qOEoAZ6Pz51tCyttz9Az7g==", null, false, "a900f765-3ed9-4ba8-b1c4-ad0c73f59394", false, "aluno21876@ipt.pt" },
                    { "17", 0, "831de29e-e912-4bd2-b9ef-783081d645f5", "aluno21296@ipt.pt", true, false, null, "ALUNO21296@IPT.PT", "ALUNO21296@IPT.PT", "AQAAAAIAAYagAAAAEKtrMCUfPdpU+zBFdENcUbewVgMUUr9ttq9VPk+X+rD370QMDEfh4Aq8/ctTXkLEKA==", null, false, "36f500cb-25ef-4590-88eb-ffd3b4889c3a", false, "aluno21296@ipt.pt" },
                    { "2", 0, "623abd85-c93b-4d4f-831a-d8fe54111400", "cbatista@ipt.pt", true, false, null, "CBATISTA@IPT.PT", "CBATISTA@IPT.PT", "AQAAAAIAAYagAAAAELRCk+2USIf2GK9slNpZYd2v5MDpXA1Bc5kZjbCuVeKR0mDn+LdFK06AWSYfRCLvbA==", null, false, "4d777b48-c0e8-427b-b016-115fdb2cc9d7", false, "cbatista@ipt.pt" },
                    { "3", 0, "cc49c7d5-7cae-4ad5-bb94-4afacd2c0a12", "manso@ipt.pt", true, false, null, "MANSO@IPT.PT", "MANSO@IPT.PT", "AQAAAAIAAYagAAAAELt0nbJy7fyXdC94Jb5fyxFrXkjP49C89kTguezPd+7ro5aPpSWULJCTffBlQ21+gQ==", null, false, "6a7ed278-5fe5-4309-8f66-acedd90a91d4", false, "manso@ipt.pt" },
                    { "4", 0, "c4488e2d-a889-4e2a-81cd-9d83f5d6105f", "bruno.almeida@ipt.pt", true, false, null, "BRUNO.ALMEIDA@IPT.PT", "BRUNO.ALMEIDA@IPT.PT", "AQAAAAIAAYagAAAAEFODfxFhIVGG2MqqOCous3tMlxgBrSls0VJ8teFFhbKMRriDT86FfbknrHu4uIXp1w==", null, false, "068ac1d1-2402-457d-8b65-c1affd1d75df", false, "bruno.almeida@ipt.pt" },
                    { "5", 0, "5e062c82-0fc5-4463-9cad-2e7607dfa839", "carloqrz@ipt.pt", true, false, null, "CARLOQRZ@IPT.PT", "CARLOQRZ@IPT.PT", "AQAAAAIAAYagAAAAEJsOATW04pj14iNY242nkJqyNCm1MFUhaNhhHOixfq+7CzCZgxtjA3MaMxGUtmHcuQ==", null, false, "50a6186f-5ec2-41b1-9ebe-c30542e1fb57", false, "carloqrz@ipt.pt" },
                    { "6", 0, "12ab646d-95d6-44d5-85e9-3dd37db19eb1", "carlos.perquilhas@ipt.pt", true, false, null, "CARLOS.PERQUILHAS@IPT.PT", "CARLOS.PERQUILHAS@IPT.PT", "AQAAAAIAAYagAAAAEFkgMyoMPlyVPdpXPrNgU6TFlywn8JHvrYE0LFRggWmX7T1xQx9su1iAYIDJ9ejl/Q==", null, false, "b6f0ab0b-1c69-4d09-90cd-4ac18d0abe1d", false, "carlos.perquilhas@ipt.pt" },
                    { "7", 0, "ef56689d-bb86-44de-9626-c5794b1b3ac4", "fnunes@ipt.pt", true, false, null, "FNUNES@IPT.PT", "FNUNES@IPT.PT", "AQAAAAIAAYagAAAAEOSkj8L4O+HoEdASbbmwHtE0jbFBasQrHMd0g2hpqzcH9ljKolVPW/IDugb4BKn42g==", null, false, "afd1602e-0b99-44f4-8fc1-44e6eee7dead", false, "fnunes@ipt.pt" },
                    { "8", 0, "743cceca-4703-49be-941a-287350f05cb7", "casimiro@ipt.pt", true, false, null, "CASIMIRO@IPT.PT", "CASIMIRO@IPT.PT", "AQAAAAIAAYagAAAAEIZ1Vuxe84TuAVDoFSGaWRSsrVNcYFP+wnjiWa2rRT4fRoqhZ29YLSQl+Dm8rQFreg==", null, false, "96a21a69-04b2-4592-aea7-4449dbc71d18", false, "casimiro@ipt.pt" },
                    { "9", 0, "0fbf184e-6b94-41b3-b422-50096224dd21", "loliveira@ipt.pt", true, false, null, "LOLIVEIRA@IPT.PT", "LOLIVEIRA@IPT.PT", "AQAAAAIAAYagAAAAEOH5ZEAaa++FXPUwCGsjmGSah7XRiVZmmwAn3TxtcweNOxCxcuI1Jw8PUdnrIbnwhw==", null, false, "a1638a2b-963f-4abe-b03a-21bc3f7abf2b", false, "loliveira@ipt.pt" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Discriminator", "Email", "External", "IdentificationNumber", "IdentificationTypeFK", "Name", "NationalityFK", "ORCID", "PhD", "Specialist", "UserId" },
                values: new object[,]
                {
                    { 1, "Advisor", "anacris@ipt.pt", false, "225630605", 1, "Ana Cristina Barata Pires Lopes", 188, null, false, false, "1" },
                    { 2, "Advisor", "cbatista@ipt.pt", true, "252394020", 1, "António Casimiro Teixeira Batista", 188, null, false, false, "2" },
                    { 3, "Advisor", "manso@ipt.pt", true, "215755812", 1, "António Manuel Rodrigues Manso", 188, null, false, false, "3" },
                    { 4, "Advisor", "bruno.almeida@ipt.pt", false, "246221933", 1, "Bruno Manuel de Almeida Santos", 188, null, false, false, "4" },
                    { 5, "Advisor", "carloqrz@ipt.pt", true, "266415369", 1, "Carlos David Magalhães Queiroz", 188, null, false, false, "5" },
                    { 6, "Advisor", "carlos.perquilhas@ipt.pt", true, "213937042", 1, "Carlos Filipe Perquilhas Baptista", 188, null, false, false, "6" },
                    { 7, "Advisor", "fnunes@ipt.pt", true, "233018131", 1, "Francisco José Alexandre Nunes", 188, null, true, false, "7" },
                    { 8, "Advisor", "casimiro@ipt.pt", true, "248716093", 1, "José Casimiro Nunes Pereira", 188, null, true, false, "8" },
                    { 9, "Advisor", "loliveira@ipt.pt", true, "223054321", 1, "Luís Miguel Lopes de Oliveira", 188, null, true, false, "9" },
                    { 10, "Advisor", "fmbarros@ipt.pt", true, "291610072", 1, "Manuel Fernando Martins de Barros", 188, null, true, false, "10" },
                    { 11, "Advisor", "gppires@ipt.pt", true, "209630108", 1, "Gabriel Pereira Pires", 188, null, true, false, "11" },
                    { 12, "Advisor", "renato.panda@ipt.pt", false, "266266568", 1, "Renato Eduardo Silva Panda", 188, null, true, false, "12" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "Email", "IdentificationNumber", "IdentificationTypeFK", "Name", "NationalityFK", "ORCID", "PostalCode", "Sex", "StudentId", "UserId" },
                values: new object[,]
                {
                    { 13, "R Germana Tânger 75", "Student", "aluno15501@ipt.pt", "289985692", 1, "Joni Correia", 188, null, "2720-428 AMADORA", 0, "15501", "13" },
                    { 14, "R Gago Coutinho 82", "Student", "aluno20568@ipt.pt", "202553205", 1, "Gonçalo Nunes", 188, null, "3885-467 ESMORIZ", 0, "20568", "14" },
                    { 15, "R Figueiras 112", "Student", "aluno20796@ipt.pt", "213517051", 1, "José Fernando Silva", 188, null, "4515-323 LOMBA", 0, "20796", "15" },
                    { 16, "R Irene Lisboa 99", "Student", "aluno21876@ipt.pt", "203512421", 1, "João Franscisco", 188, null, "2680-088 CAMARATE", 0, "21876", "16" },
                    { 17, "Travessa Vale da Loura 11", "Student", "aluno21296@ipt.pt", "296435511", 1, "André Duarte de Sá", 188, null, "2260-027 ATALAIA VNB", 0, "21296", "17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Persons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03393444-71a2-4d5b-bfab-3f73e044d23d", "AQAAAAIAAYagAAAAEAtTCL2sC8BaKqOZdKQf0Gjo+gc1Al/MRzdT4ubSdym6hf3l03BKlxKxntI3IG2D2w==", "d8f166f3-06a5-4df8-a50b-cecffe3a4c75" });
        }
    }
}
