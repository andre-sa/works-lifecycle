using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wlc2.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "Id", "Current", "Name" },
                values: new object[,]
                {
                    { 1, false, "2020-2021" },
                    { 2, false, "2021-2022" },
                    { 3, true, "2022-2023" }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "Name", "RenatesCode" },
                values: new object[,]
                {
                    { 1, "Programas Gerais", "0.." },
                    { 2, "Programas de Base", "0.1.0" },
                    { 3, "Alfabetização", "0.8.0" },
                    { 4, "Desenvolvimento pessoal", "0.9.0" },
                    { 5, "Educação", "1.0.0" },
                    { 6, "Formação de Professores / Formadores e Ciências da Educação", "1.4.0" },
                    { 7, "Ciências da Educação", "1.4.2" },
                    { 8, "Formação de Educadores de Infância", "1.4.3" },
                    { 9, "Formação de Professores do Ensino Básico (1.o e 2.o Ciclos)", "1.4.4" },
                    { 10, "Formação de Professores de Áreas Disciplinares Específicas", "1.4.5" },
                    { 11, "Formação de Professores e Formadores de Áreas Tecnológicas", "1.4.6" },
                    { 12, "Formação de Professores/formadores e ciências da educação - programas não classificados noutra área de formação.", "1.4.9" },
                    { 13, "Artes e Humanidades", "2.." },
                    { 14, "Belas-Artes", "2.1.1" },
                    { 15, "Artes do Espectáculo", "2.1.2" },
                    { 16, "Áudio-Visuais e Produção dos Media", "2.1.3" },
                    { 17, "Design", "2.1.4" },
                    { 18, "Artesanato", "2.1.5" },
                    { 19, "Artes - Programas não classificados noutra área de formação", "2.1.9" },
                    { 20, "Humanidades", "2.2.." },
                    { 21, "Religião e Teologia", "2.2.1" },
                    { 22, "Línguas e Literaturas Estrangeiras", "2.2.2" },
                    { 23, "Língua e Literatura Materna", "2.2.3" },
                    { 24, "História e Arqueologia", "2.2.5" },
                    { 25, "Filosofia e Ética", "2.2.6" },
                    { 26, "Humanidades - Programas não classificados noutra área de formação", "2.2.9" },
                    { 27, "Ciências Sociais, Comércio e Direito", "3.." },
                    { 28, "Psicologia", "3.1.1" },
                    { 29, "Sociologia e Outros Estudos", "3.1.2" },
                    { 30, "Ciência Política e Cidadania", "3.1.3" },
                    { 31, "Economia", "3.1.4" },
                    { 32, "Ciências Sociais e do Comportamento - programas não classificados noutra área de formação", "3.1.9" },
                    { 33, "Informação e Jornalismo", "3.2.." },
                    { 34, "Jornalismo e Reportagem", "3.2.1" },
                    { 35, "Biblioteconomia, Arquivo e Documentação (BAD)", "3.2.2" },
                    { 36, "Informação e Jornalismo - programas não classificados noutra área de formação", "3.2.9" },
                    { 37, "Ciências Empresariais", "3.4.." },
                    { 38, "Comércio", "3.4.1" },
                    { 39, "Marketing e Publicidade", "3.4.2" },
                    { 40, "Finanças, Banca e Seguros", "3.4.3" },
                    { 41, "Contabilidade e Fiscalidade", "3.4.4" },
                    { 42, "Gestão e Administração", "3.4.5" },
                    { 43, "Secretariado e Trabalho Administrativo", "3.4.6" },
                    { 44, "Enquadramento na Organização/Empresa", "3.4.7" },
                    { 45, "Ciências Empresariais - programas não classificados noutra área de formação", "3.4.9" },
                    { 46, "Direito", "3.8.0" },
                    { 47, "Ciências, Matemática e Informática", "4.." },
                    { 48, "Biologia e Bioquímica", "4.2.1" },
                    { 49, "Ciências do Ambiente", "4.2.2" },
                    { 50, "Ciências da Vida - programas não classificados noutra área de formação", "4.2.9" },
                    { 51, "Ciências Físicas", "4.4.." },
                    { 52, "Física", "4.4.1" },
                    { 53, "Química", "4.4.2" },
                    { 54, "Ciências da Terra", "4.4.3" },
                    { 55, "Ciências Físicas - programas não classificados noutra área de formação", "4.4.9" },
                    { 56, "Matemática e Estatística", "4.6.." },
                    { 57, "Matemática", "4.6.1" },
                    { 58, "Estatística", "4.6.2" },
                    { 59, "Matemática e Estatística - programas não classificados noutra área de formação", "4.6.9" },
                    { 60, "Informática", "4.8.." },
                    { 61, "Ciências Informáticas", "4.8.1" },
                    { 62, "Informática na Óptica do Utilizador", "4.8.2" },
                    { 63, "Informática - programas não classificados noutra área de formação", "4.8.9" },
                    { 64, "Engenharia, Indústrias Transformadoras e Construção", "5.." },
                    { 65, "Metalurgia e Metalomecânica", "5.2.1" },
                    { 66, "Electricidade e Energia", "5.2.2" },
                    { 67, "Electrónica e Automação", "5.2.3" },
                    { 68, "Tecnologia dos Processos Químicos", "5.2.4" },
                    { 69, "Construção e Reparação de Veículos a Motor", "5.2.5" },
                    { 70, "Engenharia e Técnicas Afins - programas não classificados noutra área de formação", "5.2.9" },
                    { 71, "Indústrias Transformadoras", "5.4.." },
                    { 72, "Indústrias Alimentares", "5.4.1" },
                    { 73, "Indústrias do Têxtil, Vestuário, Calçado e Couro", "5.4.2" },
                    { 74, "Materiais (Indústrias da Madeira, Cortiça, Papel, Plástico, Vidro e outros)", "5.4.3" },
                    { 75, "Indústrias Extractivas", "5.4.4" },
                    { 76, "Indústrias Transformadoras - programas não classificados noutra área de formação", "5.4.9" },
                    { 77, "Arquitectura e Construção", "5.8.." },
                    { 78, "Arquitectura e Urbanismo", "5.8.1" },
                    { 79, "Construção Civil e Engenharia Civil", "5.8.2" },
                    { 80, "Arquitectura e Construção - programas não classificados noutra área de formação", "5.8.9" },
                    { 81, "Agricultura", "6.." },
                    { 82, "Produção Agrícola e Animal", "6.2.1" },
                    { 83, "Floricultura e Jardinagem", "6.2.2" },
                    { 84, "Silvicultura e Caça", "6.2.3" },
                    { 85, "Pescas", "6.2.4" },
                    { 86, "Agricultura, Silvicultura e Pescas - programas não classificados noutra área de formação", "6.2.9" },
                    { 87, "Saúde e Protecção Social", "7.." },
                    { 88, "Medicina", "7.2.1" },
                    { 89, "Enfermagem", "7.2.3" },
                    { 90, "Ciências Dentárias", "7.2.4" },
                    { 91, "Tecnologias de Diagnóstico e Terapêutica", "7.2.5" },
                    { 92, "Terapia e Reabilitação", "7.2.6" },
                    { 93, "Ciências Farmacêuticas", "7.2.7" },
                    { 94, "Saúde - programas não classificados noutra área de formação", "7.2.9" },
                    { 95, "Serviços Sociais", "7.6.." },
                    { 96, "Serviços de Apoio a Crianças e Jovens", "7.6.1" },
                    { 97, "Trabalho Social e Orientação", "7.6.2" },
                    { 98, "Serviços Sociais - programas não classificados noutra área de formação", "7.6.9" },
                    { 99, "Serviços Pessoais", "8.1.." },
                    { 100, "Hotelaria e Restauração", "8.1.1" },
                    { 101, "Turismo e Lazer", "8.1.2" },
                    { 102, "Desporto", "8.1.3" },
                    { 103, "Serviços Domésticos", "8.1.4" },
                    { 104, "Cuidados de beleza", "8.1.5" },
                    { 105, "Serviços Pessoais - programas não classificados noutra área de formação", "8.1.9" },
                    { 106, "Serviços de Transporte", "8.4.." },
                    { 107, "Protecção do Ambiente", "8.5.." },
                    { 108, "Tecnologia de Protecção do Ambiente", "8.5.1" },
                    { 109, "Ambientes Naturais e Vida Selvagem", "8.5.2" },
                    { 110, "Serviços de Saúde Pública", "8.5.3" },
                    { 111, "Protecção do Ambiente - programas não classificados noutra área de formação", "8.5.9" },
                    { 112, "Serviços de Segurança", "8.6.." },
                    { 113, "Protecção de Pessoas e Bens", "8.6.1" },
                    { 114, "Segurança e Higiene no Trabalho", "8.6.2" },
                    { 115, "Segurança Militar", "8.6.3" },
                    { 116, "Serviços de Segurança - programas não classificados noutra área de formação", "8.6.9" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03393444-71a2-4d5b-bfab-3f73e044d23d", "AQAAAAIAAYagAAAAEAtTCL2sC8BaKqOZdKQf0Gjo+gc1Al/MRzdT4ubSdym6hf3l03BKlxKxntI3IG2D2w==", "d8f166f3-06a5-4df8-a50b-cecffe3a4c75" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AreaFK", "Code", "Degree", "Name", "OrganicUnitFK" },
                values: new object[,]
                {
                    { 1, 1, "L177", 0, "Cinema Documental", 2 },
                    { 2, 1, "L211", 0, "Computação e Logística", 2 },
                    { 3, 1, "9054", 0, "Comunicação Social", 2 },
                    { 4, 1, "L297", 0, "Comunicação Social: Jornalismo e Comunicação Empresarial", 2 },
                    { 5, 1, "9380", 0, "Conservação e Restauro", 3 },
                    { 6, 1, "L106", 0, "Construção e Reabilitação", 3 },
                    { 7, 1, "9056", 0, "Contabilidade", 1 },
                    { 8, 1, "9644", 0, "Design e Tecnologia das Artes Gráficas", 3 },
                    { 9, 1, "9089", 0, "Engenharia Civil", 3 },
                    { 10, 1, "9112", 0, "Engenharia Electrotécnica e de Computadores", 3 },
                    { 11, 1, "9119", 0, "Engenharia Informática", 3 },
                    { 12, 1, "9123", 0, "Engenharia Mecânica", 2 },
                    { 13, 1, "9184", 0, "Engenharia Química e Bioquímica", 3 },
                    { 14, 1, "9645", 0, "Fotografia", 3 },
                    { 15, 1, "9641", 0, "Gestão Turística e Cultural", 1 },
                    { 16, 1, "L186", 0, "Gestão da Edificação e Obras", 3 },
                    { 17, 1, "9152", 0, "Gestão de Empresas", 1 },
                    { 18, 1, "9640", 0, "Gestão de Recursos Humanos e Comportamento Organizacional", 1 },
                    { 19, 1, "L143", 0, "Informática e Tecnologias Multimédia", 2 },
                    { 20, 1, "L142", 0, "Tecnologia Química", 3 },
                    { 21, 1, "L207", 0, "Turismo e Gestão do Património Cultural", 1 },
                    { 22, 1, "M932", 1, "Analítica e Inteligência Organizacional", 3 },
                    { 23, 1, "6498", 1, "Arqueologia Pré-Histórica e Arte Rupestre", 3 },
                    { 24, 1, "M925", 1, "Auditoria e Finanças", 1 },
                    { 25, 1, "MB41", 1, "Avaliação e Gestão de Ativos Imobiliários", 3 },
                    { 26, 1, "9405", 1, "Conservação e Restauro", 3 },
                    { 27, 1, "M013", 1, "Desenvolvimento de Produtos de Turismo Cultural", 1 },
                    { 28, 1, "M474", 1, "Design Editorial", 3 },
                    { 29, 1, "M778", 1, "Engenharia Eletrotécnica", 3 },
                    { 30, 1, "M909", 1, "Engenharia Informática-Internet das Coisas", 3 },
                    { 31, 1, "M746", 1, "Engenharia Mecânica - Projecto e Produção Mecânica", 2 },
                    { 32, 1, "9295", 1, "Gestão", 1 },
                    { 33, 1, "9299", 1, "Gestão de Recursos Humanos", 1 },
                    { 34, 1, "M199", 1, "Reabilitação Urbana", 3 },
                    { 35, 1, "M079", 1, "Tecnologia Química", 3 },
                    { 36, 1, "M197", 1, "Técnicas de Arqueologia", 3 },
                    { 37, 1, "PA58", 2, "Património, Tecnologia e Território", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Courses");

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
                values: new object[] { "dfab2e3c-c7d4-48d7-9287-b21adfc1ca2c", "AQAAAAIAAYagAAAAEBW92VG40Brs2TEF7xDrQQ8kKeeBua7iHg3n6MD8qhhxfFyOmbQGhaewIWOCt4CilA==", "3955c076-e855-4a21-9101-1e9f2f458aac" });
        }
    }
}
