using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using wlc2.Models;

namespace wlc2.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        /// <summary>
        /// This code is executed on model creation.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // Imports the last execution of this method.
            base.OnModelCreating(modelBuilder);

            // Seed data for system roles.
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "admin", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "employee", Name = "Employee", NormalizedName = "EMPLOYEE" },
                new IdentityRole { Id = "advisor", Name = "Advisor", NormalizedName = "ADVISOR" },
                new IdentityRole { Id = "student", Name = "Student", NormalizedName = "STUDENT" }
                );

            // Seed admin user data.
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser {
                    Id = "0",
                    Email = "admin@ipt.pt", NormalizedEmail = "ADMIN@IPT.PT", EmailConfirmed = true,
                    UserName = "admin@ipt.pt", NormalizedUserName = "ADMIN@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, "Admin123.")
                });

            // Give admin role to the admin user.
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "admin", UserId = "0" }
                );

            // Seed data for the table 'AcademicYears'.
            modelBuilder.Entity<AcademicYear>().HasData(
                new AcademicYear { Id = 1, Name = "2020-2021", Current = false },
                new AcademicYear { Id = 2, Name = "2021-2022", Current = false },
                new AcademicYear { Id = 3, Name = "2022-2023", Current = true }
                );

            // Seed data for the table 'Areas'.
            modelBuilder.Entity<Area>().HasData(
                new Area { Id = 1, Name = "Programas Gerais", RenatesCode = "0.." },
                new Area { Id = 2, Name = "Programas de Base", RenatesCode = "0.1.0" },
                new Area { Id = 3, Name = "Alfabetização", RenatesCode = "0.8.0" },
                new Area { Id = 4, Name = "Desenvolvimento pessoal", RenatesCode = "0.9.0" },
                new Area { Id = 5, Name = "Educação", RenatesCode = "1.0.0" },
                new Area { Id = 6, Name = "Formação de Professores / Formadores e Ciências da Educação", RenatesCode = "1.4.0" },
                new Area { Id = 7, Name = "Ciências da Educação", RenatesCode = "1.4.2" },
                new Area { Id = 8, Name = "Formação de Educadores de Infância", RenatesCode = "1.4.3" },
                new Area { Id = 9, Name = "Formação de Professores do Ensino Básico (1.o e 2.o Ciclos)", RenatesCode = "1.4.4" },
                new Area { Id = 10, Name = "Formação de Professores de Áreas Disciplinares Específicas", RenatesCode = "1.4.5" },
                new Area { Id = 11, Name = "Formação de Professores e Formadores de Áreas Tecnológicas", RenatesCode = "1.4.6" },
                new Area { Id = 12, Name = "Formação de Professores/formadores e ciências da educação - programas não classificados noutra área de formação.", RenatesCode = "1.4.9" },
                new Area { Id = 13, Name = "Artes e Humanidades", RenatesCode = "2.." },
                new Area { Id = 14, Name = "Belas-Artes", RenatesCode = "2.1.1" },
                new Area { Id = 15, Name = "Artes do Espectáculo", RenatesCode = "2.1.2" },
                new Area { Id = 16, Name = "Áudio-Visuais e Produção dos Media", RenatesCode = "2.1.3" },
                new Area { Id = 17, Name = "Design", RenatesCode = "2.1.4" },
                new Area { Id = 18, Name = "Artesanato", RenatesCode = "2.1.5" },
                new Area { Id = 19, Name = "Artes - Programas não classificados noutra área de formação", RenatesCode = "2.1.9" },
                new Area { Id = 20, Name = "Humanidades", RenatesCode = "2.2.." },
                new Area { Id = 21, Name = "Religião e Teologia", RenatesCode = "2.2.1" },
                new Area { Id = 22, Name = "Línguas e Literaturas Estrangeiras", RenatesCode = "2.2.2" },
                new Area { Id = 23, Name = "Língua e Literatura Materna", RenatesCode = "2.2.3" },
                new Area { Id = 24, Name = "História e Arqueologia", RenatesCode = "2.2.5" },
                new Area { Id = 25, Name = "Filosofia e Ética", RenatesCode = "2.2.6" },
                new Area { Id = 26, Name = "Humanidades - Programas não classificados noutra área de formação", RenatesCode = "2.2.9" },
                new Area { Id = 27, Name = "Ciências Sociais, Comércio e Direito", RenatesCode = "3.." },
                new Area { Id = 28, Name = "Psicologia", RenatesCode = "3.1.1" },
                new Area { Id = 29, Name = "Sociologia e Outros Estudos", RenatesCode = "3.1.2" },
                new Area { Id = 30, Name = "Ciência Política e Cidadania", RenatesCode = "3.1.3" },
                new Area { Id = 31, Name = "Economia", RenatesCode = "3.1.4" },
                new Area { Id = 32, Name = "Ciências Sociais e do Comportamento - programas não classificados noutra área de formação", RenatesCode = "3.1.9" },
                new Area { Id = 33, Name = "Informação e Jornalismo", RenatesCode = "3.2.." },
                new Area { Id = 34, Name = "Jornalismo e Reportagem", RenatesCode = "3.2.1" },
                new Area { Id = 35, Name = "Biblioteconomia, Arquivo e Documentação (BAD)", RenatesCode = "3.2.2" },
                new Area { Id = 36, Name = "Informação e Jornalismo - programas não classificados noutra área de formação", RenatesCode = "3.2.9" },
                new Area { Id = 37, Name = "Ciências Empresariais", RenatesCode = "3.4.." },
                new Area { Id = 38, Name = "Comércio", RenatesCode = "3.4.1" },
                new Area { Id = 39, Name = "Marketing e Publicidade", RenatesCode = "3.4.2" },
                new Area { Id = 40, Name = "Finanças, Banca e Seguros", RenatesCode = "3.4.3" },
                new Area { Id = 41, Name = "Contabilidade e Fiscalidade", RenatesCode = "3.4.4" },
                new Area { Id = 42, Name = "Gestão e Administração", RenatesCode = "3.4.5" },
                new Area { Id = 43, Name = "Secretariado e Trabalho Administrativo", RenatesCode = "3.4.6" },
                new Area { Id = 44, Name = "Enquadramento na Organização/Empresa", RenatesCode = "3.4.7" },
                new Area { Id = 45, Name = "Ciências Empresariais - programas não classificados noutra área de formação", RenatesCode = "3.4.9" },
                new Area { Id = 46, Name = "Direito", RenatesCode = "3.8.0" },
                new Area { Id = 47, Name = "Ciências, Matemática e Informática", RenatesCode = "4.." },
                new Area { Id = 48, Name = "Biologia e Bioquímica", RenatesCode = "4.2.1" },
                new Area { Id = 49, Name = "Ciências do Ambiente", RenatesCode = "4.2.2" },
                new Area { Id = 50, Name = "Ciências da Vida - programas não classificados noutra área de formação", RenatesCode = "4.2.9" },
                new Area { Id = 51, Name = "Ciências Físicas", RenatesCode = "4.4.." },
                new Area { Id = 52, Name = "Física", RenatesCode = "4.4.1" },
                new Area { Id = 53, Name = "Química", RenatesCode = "4.4.2" },
                new Area { Id = 54, Name = "Ciências da Terra", RenatesCode = "4.4.3" },
                new Area { Id = 55, Name = "Ciências Físicas - programas não classificados noutra área de formação", RenatesCode = "4.4.9" },
                new Area { Id = 56, Name = "Matemática e Estatística", RenatesCode = "4.6.." },
                new Area { Id = 57, Name = "Matemática", RenatesCode = "4.6.1" },
                new Area { Id = 58, Name = "Estatística", RenatesCode = "4.6.2" },
                new Area { Id = 59, Name = "Matemática e Estatística - programas não classificados noutra área de formação", RenatesCode = "4.6.9" },
                new Area { Id = 60, Name = "Informática", RenatesCode = "4.8.." },
                new Area { Id = 61, Name = "Ciências Informáticas", RenatesCode = "4.8.1" },
                new Area { Id = 62, Name = "Informática na Óptica do Utilizador", RenatesCode = "4.8.2" },
                new Area { Id = 63, Name = "Informática - programas não classificados noutra área de formação", RenatesCode = "4.8.9" },
                new Area { Id = 64, Name = "Engenharia, Indústrias Transformadoras e Construção", RenatesCode = "5.." },
                new Area { Id = 65, Name = "Metalurgia e Metalomecânica", RenatesCode = "5.2.1" },
                new Area { Id = 66, Name = "Electricidade e Energia", RenatesCode = "5.2.2" },
                new Area { Id = 67, Name = "Electrónica e Automação", RenatesCode = "5.2.3" },
                new Area { Id = 68, Name = "Tecnologia dos Processos Químicos", RenatesCode = "5.2.4" },
                new Area { Id = 69, Name = "Construção e Reparação de Veículos a Motor", RenatesCode = "5.2.5" },
                new Area { Id = 70, Name = "Engenharia e Técnicas Afins - programas não classificados noutra área de formação", RenatesCode = "5.2.9" },
                new Area { Id = 71, Name = "Indústrias Transformadoras", RenatesCode = "5.4.." },
                new Area { Id = 72, Name = "Indústrias Alimentares", RenatesCode = "5.4.1" },
                new Area { Id = 73, Name = "Indústrias do Têxtil, Vestuário, Calçado e Couro", RenatesCode = "5.4.2" },
                new Area { Id = 74, Name = "Materiais (Indústrias da Madeira, Cortiça, Papel, Plástico, Vidro e outros)", RenatesCode = "5.4.3" },
                new Area { Id = 75, Name = "Indústrias Extractivas", RenatesCode = "5.4.4" },
                new Area { Id = 76, Name = "Indústrias Transformadoras - programas não classificados noutra área de formação", RenatesCode = "5.4.9" },
                new Area { Id = 77, Name = "Arquitectura e Construção", RenatesCode = "5.8.." },
                new Area { Id = 78, Name = "Arquitectura e Urbanismo", RenatesCode = "5.8.1" },
                new Area { Id = 79, Name = "Construção Civil e Engenharia Civil", RenatesCode = "5.8.2" },
                new Area { Id = 80, Name = "Arquitectura e Construção - programas não classificados noutra área de formação", RenatesCode = "5.8.9" },
                new Area { Id = 81, Name = "Agricultura", RenatesCode = "6.." },
                new Area { Id = 82, Name = "Produção Agrícola e Animal", RenatesCode = "6.2.1" },
                new Area { Id = 83, Name = "Floricultura e Jardinagem", RenatesCode = "6.2.2" },
                new Area { Id = 84, Name = "Silvicultura e Caça", RenatesCode = "6.2.3" },
                new Area { Id = 85, Name = "Pescas", RenatesCode = "6.2.4" },
                new Area { Id = 86, Name = "Agricultura, Silvicultura e Pescas - programas não classificados noutra área de formação", RenatesCode = "6.2.9" },
                new Area { Id = 87, Name = "Saúde e Protecção Social", RenatesCode = "7.." },
                new Area { Id = 88, Name = "Medicina", RenatesCode = "7.2.1" },
                new Area { Id = 89, Name = "Enfermagem", RenatesCode = "7.2.3" },
                new Area { Id = 90, Name = "Ciências Dentárias", RenatesCode = "7.2.4" },
                new Area { Id = 91, Name = "Tecnologias de Diagnóstico e Terapêutica", RenatesCode = "7.2.5" },
                new Area { Id = 92, Name = "Terapia e Reabilitação", RenatesCode = "7.2.6" },
                new Area { Id = 93, Name = "Ciências Farmacêuticas", RenatesCode = "7.2.7" },
                new Area { Id = 94, Name = "Saúde - programas não classificados noutra área de formação", RenatesCode = "7.2.9" },
                new Area { Id = 95, Name = "Serviços Sociais", RenatesCode = "7.6.." },
                new Area { Id = 96, Name = "Serviços de Apoio a Crianças e Jovens", RenatesCode = "7.6.1" },
                new Area { Id = 97, Name = "Trabalho Social e Orientação", RenatesCode = "7.6.2" },
                new Area { Id = 98, Name = "Serviços Sociais - programas não classificados noutra área de formação", RenatesCode = "7.6.9" },
                new Area { Id = 99, Name = "Serviços Pessoais", RenatesCode = "8.1.." },
                new Area { Id = 100, Name = "Hotelaria e Restauração", RenatesCode = "8.1.1" },
                new Area { Id = 101, Name = "Turismo e Lazer", RenatesCode = "8.1.2" },
                new Area { Id = 102, Name = "Desporto", RenatesCode = "8.1.3" },
                new Area { Id = 103, Name = "Serviços Domésticos", RenatesCode = "8.1.4" },
                new Area { Id = 104, Name = "Cuidados de beleza", RenatesCode = "8.1.5" },
                new Area { Id = 105, Name = "Serviços Pessoais - programas não classificados noutra área de formação", RenatesCode = "8.1.9" },
                new Area { Id = 106, Name = "Serviços de Transporte", RenatesCode = "8.4.." },
                new Area { Id = 107, Name = "Protecção do Ambiente", RenatesCode = "8.5.." },
                new Area { Id = 108, Name = "Tecnologia de Protecção do Ambiente", RenatesCode = "8.5.1" },
                new Area { Id = 109, Name = "Ambientes Naturais e Vida Selvagem", RenatesCode = "8.5.2" },
                new Area { Id = 110, Name = "Serviços de Saúde Pública", RenatesCode = "8.5.3" },
                new Area { Id = 111, Name = "Protecção do Ambiente - programas não classificados noutra área de formação", RenatesCode = "8.5.9" },
                new Area { Id = 112, Name = "Serviços de Segurança", RenatesCode = "8.6.." },
                new Area { Id = 113, Name = "Protecção de Pessoas e Bens", RenatesCode = "8.6.1" },
                new Area { Id = 114, Name = "Segurança e Higiene no Trabalho", RenatesCode = "8.6.2" },
                new Area { Id = 115, Name = "Segurança Militar", RenatesCode = "8.6.3" },
                new Area { Id = 116, Name = "Serviços de Segurança - programas não classificados noutra área de formação", RenatesCode = "8.6.9" }
            );

            // Seed data for the table 'Courses'.
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, AreaFK = 16, Code = "L177", Abbreviation = "LCD", Name = "Cinema Documental", Degree = Degree.bachelor, OrganicUnitFK = 2 },
                new Course { Id = 2, AreaFK = 61, Code = "L211", Abbreviation = "LCL", Name = "Computação e Logística", Degree = Degree.bachelor, OrganicUnitFK = 2 },
                new Course { Id = 3, AreaFK = 34, Code = "9054", Abbreviation = "LCS", Name = "Comunicação Social", Degree = Degree.bachelor, OrganicUnitFK = 2 },
                new Course { Id = 4, AreaFK = 34, Code = "L297", Abbreviation = "LCS-JCE", Name = "Comunicação Social: Jornalismo e Comunicação Empresarial", Degree = Degree.bachelor, OrganicUnitFK = 2 },
                new Course { Id = 5, AreaFK = 18, Code = "9380", Abbreviation = "LCRES", Name = "Conservação e Restauro", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 6, AreaFK = 79, Code = "L106", Abbreviation = "LCREA", Name = "Construção e Reabilitação", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 7, AreaFK = 41, Code = "9056", Abbreviation = "LC", Name = "Contabilidade", Degree = Degree.bachelor, OrganicUnitFK = 1 },
                new Course { Id = 8, AreaFK = 16, Code = "9644", Abbreviation = "LDTAG", Name = "Design e Tecnologia das Artes Gráficas", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 9, AreaFK = 79, Code = "9089", Abbreviation = "LEC", Name = "Engenharia Civil", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 10, AreaFK = 67, Code = "9112", Abbreviation = "LEEC", Name = "Engenharia Electrotécnica e de Computadores", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 11, AreaFK = 67, Code = "9119", Abbreviation = "LEI", Name = "Engenharia Informática", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 12, AreaFK = 65, Code = "9123", Abbreviation = "LEM", Name = "Engenharia Mecânica", Degree = Degree.bachelor, OrganicUnitFK = 2 },
                new Course { Id = 13, AreaFK = 68, Code = "9184", Abbreviation = "LEQB", Name = "Engenharia Química e Bioquímica", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 14, AreaFK = 16, Code = "9645", Abbreviation = "LF", Name = "Fotografia", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 15, AreaFK = 101, Code = "9641", Abbreviation = "LGTC", Name = "Gestão Turística e Cultural", Degree = Degree.bachelor, OrganicUnitFK = 1 },
                new Course { Id = 16, AreaFK = 79, Code = "L186", Abbreviation = "LGEO", Name = "Gestão da Edificação e Obras", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 17, AreaFK = 42, Code = "9152", Abbreviation = "LGE", Name = "Gestão de Empresas", Degree = Degree.bachelor, OrganicUnitFK = 1 },
                new Course { Id = 18, AreaFK = 42, Code = "9640", Abbreviation = "LGRHCO", Name = "Gestão de Recursos Humanos e Comportamento Organizacional", Degree = Degree.bachelor, OrganicUnitFK = 1 },
                new Course { Id = 19, AreaFK = 61, Code = "L143", Abbreviation = "LITM", Name = "Informática e Tecnologias Multimédia", Degree = Degree.bachelor, OrganicUnitFK = 2 },
                new Course { Id = 20, AreaFK = 68, Code = "L142", Abbreviation = "LTQ", Name = "Tecnologia Química", Degree = Degree.bachelor, OrganicUnitFK = 3 },
                new Course { Id = 21, AreaFK = 101, Code = "L207", Abbreviation = "LTGPC", Name = "Turismo e Gestão do Património Cultural", Degree = Degree.bachelor, OrganicUnitFK = 1 },
                new Course { Id = 22, AreaFK = 61, Code = "M932", Abbreviation = "MAIO", Name = "Analítica e Inteligência Organizacional", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 23, AreaFK = 24, Code = "6498", Abbreviation = "MAPHAR", Name = "Arqueologia Pré-Histórica e Arte Rupestre", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 24, AreaFK = 40, Code = "M925", Abbreviation = "MAF", Name = "Auditoria e Finanças", Degree = Degree.master, OrganicUnitFK = 1 },
                new Course { Id = 25, AreaFK = 42, Code = "MB41", Abbreviation = "MAGAI", Name = "Avaliação e Gestão de Ativos Imobiliários", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 26, AreaFK = 18, Code = "9405", Abbreviation = "MCR", Name = "Conservação e Restauro", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 27, AreaFK = 101, Code = "M013", Abbreviation = "MDPTC", Name = "Desenvolvimento de Produtos de Turismo Cultural", Degree = Degree.master, OrganicUnitFK = 1 },
                new Course { Id = 28, AreaFK = 17, Code = "M474", Abbreviation = "MDE", Name = "Design Editorial", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 29, AreaFK = 67, Code = "M778", Abbreviation = "MEE", Name = "Engenharia Eletrotécnica", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 30, AreaFK = 61, Code = "M909", Abbreviation = "MEI-IC", Name = "Engenharia Informática-Internet das Coisas", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 31, AreaFK = 65, Code = "M746", Abbreviation = "MEM-PPM", Name = "Engenharia Mecânica - Projecto e Produção Mecânica", Degree = Degree.master, OrganicUnitFK = 2 },
                new Course { Id = 32, AreaFK = 42, Code = "9295", Abbreviation = "MG", Name = "Gestão", Degree = Degree.master, OrganicUnitFK = 1 },
                new Course { Id = 33, AreaFK = 42, Code = "9299", Abbreviation = "MGRH", Name = "Gestão de Recursos Humanos", Degree = Degree.master, OrganicUnitFK = 1 },
                new Course { Id = 34, AreaFK = 78, Code = "M199", Abbreviation = "MRU", Name = "Reabilitação Urbana", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 35, AreaFK = 68, Code = "M079", Abbreviation = "MTQ", Name = "Tecnologia Química", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 36, AreaFK = 24, Code = "M197", Abbreviation = "MTA", Name = "Técnicas de Arqueologia", Degree = Degree.master, OrganicUnitFK = 3 },
                new Course { Id = 37, AreaFK = 24, Code = "PA58", Abbreviation = "DPTT", Name = "Património, Tecnologia e Território", Degree = Degree.doctorate, OrganicUnitFK = 3 }
            );

            // Seed data for the table 'IdentificationTypes'.
            modelBuilder.Entity<IdentificationType>().HasData(
                new IdentificationType { Id = 1, Name = "Cartão de Cidadão ou Bilhete de Identidade Nacional", Code = "1" },
                new IdentificationType { Id = 2, Name = "Passaporte", Code = "2" },
                new IdentificationType { Id = 3, Name = "Autorização de Residência", Code = "3" },
                new IdentificationType { Id = 4, Name = "Bilhete de Identidade Estrangeiro", Code = "4" },
                new IdentificationType { Id = 5, Name = "Certificado de Registo de Cidadão da União Europeia", Code = "7" },
                new IdentificationType { Id = 6, Name = "Cartão de Residência Permanente de Cidadão da União Europeia", Code = "8" },
                new IdentificationType { Id = 7, Name = "Outro", Code = "9" }
                );

            // Seed data for the table 'OrganicUnits'.
            modelBuilder.Entity<OrganicUnit>().HasData(
                new OrganicUnit { Id = 1, Name = "Escola Superior de Gestão de Tomar", Abbreviation = "ESGT", ExternalCode = "3241" },
                new OrganicUnit { Id = 2, Name = "Escola Superior de Tecnologia de Abrantes", Abbreviation = "ESTA", ExternalCode = "3243" },
                new OrganicUnit { Id = 3, Name = "Escola Superior de Tecnologia de Tomar", Abbreviation = "ESTT", ExternalCode = "3242" }
                );

            // Seed data for the table 'AccessTypes'.
            modelBuilder.Entity<AccessType>().HasData(
                new AccessType { Id = 1, Name = "Acesso Aberto", RcaapCode = "openAccess" },
                new AccessType { Id = 2, Name = "Acesso Restrito", RcaapCode = "restrictedAccess" },
                new AccessType { Id = 3, Name = "Acesso Embargado", RcaapCode = "embargoedAccess" },
                new AccessType { Id = 4, Name = "Acesso Fechado", RcaapCode = "closedAccess" }
                );

            // Seed data for the table 'Licenses'.
            modelBuilder.Entity<License>().HasData(
                new License { Id = 1, Name = "Sem Licença", RcaapCode = "N/A" },
                new License { Id = 2, Name = "Atribuição (CC-BY)", RcaapCode = "http://creativecommons.org/licenses/by/4.0/" },
                new License { Id = 3, Name = "Atribuição, Sem Trabalhos Derivados (CC-BY-ND)", RcaapCode = "http://creativecommons.org/licenses/by-nd/4.0/" },
                new License { Id = 4, Name = "Atribuição, Partilha nos Termos da Mesma Licença (CC-BY-SA)", RcaapCode = "http://creativecommons.org/licenses/by-sa/4.0/" },
                new License { Id = 5, Name = "Atribuição, Uso Não Comercial (CC-BY-NC)", RcaapCode = "http://creativecommons.org/licenses/by-nc/4.0/" },
                new License { Id = 6, Name = "Atribuição, Não Comercial, Sem Derivações (CC-BY-NC-ND)", RcaapCode = "http://creativecommons.org/licenses/by-nc-nd/4.0/" },
                new License { Id = 7, Name = "Atribuição, Uso Não Comercial, Partilha nos Termos da Mesma Licença (CC-BY-NC-SA)", RcaapCode = "http://creativecommons.org/licenses/by-nc-sa/4.0/" }
                );

            // Seed data for the table 'Language'.
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Name = "Português", Alpha2Code = "por" },
                new Language { Id = 2, Name = "Inglês", Alpha2Code = "eng" },
                new Language { Id = 3, Name = "Espanhol", Alpha2Code = "spa" },
                new Language { Id = 4, Name = "Alemão", Alpha2Code = "deu" },
                new Language { Id = 5, Name = "Francês", Alpha2Code = "fra" },
                new Language { Id = 6, Name = "Italiano", Alpha2Code = "ita" },
                new Language { Id = 7, Name = "Mirandês", Alpha2Code = "mwl" },
                new Language { Id = 8, Name = "Japonês", Alpha2Code = "jpn" },
                new Language { Id = 9, Name = "Chinês", Alpha2Code = "cmn" },
                new Language { Id = 10, Name = "Outro", Alpha2Code = "other" },
                new Language { Id = 11, Name = "N/A", Alpha2Code = "N/A" }
                );

            // Seed data for table 'ResearchProjects'.
            modelBuilder.Entity<ResearchProject>().HasData(
                new ResearchProject { Id = 1, Name = "OMRisk", Reference = "UIDB/05567/2020/04" },
                new ResearchProject { Id = 2, Name = "Cognition", Reference = "UIDB/05567/2020/01" },
                new ResearchProject { Id = 3, Name = "MoSBurn", Reference = "UIDB/05567/2020/03" },
                new ResearchProject { Id = 4, Name = "Solar", Reference = "UIDB/05567/2020/05" },
                new ResearchProject { Id = 5, Name = "EcoModZHC", Reference = "CENTRO-01-0145-FEDER-179932" },
                new ResearchProject { Id = 6, Name = "BREUCA", Reference = "POCI-01-0247-FEDER-048257" },
                new ResearchProject { Id = 7, Name = "CRASH", Reference = "POCI-01-0247-FEDER-070315" },
                new ResearchProject { Id = 8, Name = "GePISCal", Reference = "UIDB/05567/2020 " },
                new ResearchProject { Id = 9, Name = "SmarterCW", Reference = "UIDP/05567/2020/03" },
                new ResearchProject { Id = 10, Name = "SmartBASE", Reference = "UIDB/05567/2020/00" },
                new ResearchProject { Id = 11, Name = "H2-REnWaste", Reference = "UIDP/05567/2020/01" },
                new ResearchProject { Id = 12, Name = "Dragonfly", Reference = "UIDP/05567/2020/02" },
                new ResearchProject { Id = 13, Name = "B-RELIABLE", Reference = "SAICT/30935/2017" },
                new ResearchProject { Id = 14, Name = "HTPDIR", Reference = "POCI-01-0247-FEDER-017644" },
                new ResearchProject { Id = 15, Name = "INFANTE", Reference = "CENTRO-01-0246-FEDER-000017" },
                new ResearchProject { Id = 16, Name = "INDuGRID", Reference = "ERANETLAC/0006/2014" },
                new ResearchProject { Id = 17, Name = "VITASENIOR-MT", Reference = "CENTRO-01-0145-FEDER-023659" },
                new ResearchProject { Id = 18, Name = "EXOBIKE", Reference = "CENTRO-01-0145-FEDER-24013" },
                new ResearchProject { Id = 19, Name = "AGA@4life", Reference = "CENTRO-01-0145-FEDER-023369" },
                new ResearchProject { Id = 20, Name = "MOVTOUR", Reference = "POCI-01-0145-FEDER-024068" },
                new ResearchProject { Id = 21, Name = "LIBÉLULA", Reference = "CENTRO-01-0145-FEDER-024052" },
                new ResearchProject { Id = 22, Name = "MOVIDA", Reference = "CENTRO-01-0145-FEDER-023878" },
                new ResearchProject { Id = 23, Name = "GEDITEC", Reference = "POCI-01-0145-FEDER-023723" },
                new ResearchProject { Id = 24, Name = "VALORBIO", Reference = "POCI-01-0145-FEDER-23314" }
                );

            // Seed data for the table 'Nationalities'.
            modelBuilder.Entity<Nationality>().HasData(
                new Nationality { Id = 1, Alpha2Code = "AF", Name = "Afeganistão" },
                new Nationality { Id = 2, Alpha2Code = "ZA", Name = "África do Sul" },
                new Nationality { Id = 3, Alpha2Code = "AL", Name = "Albânia" },
                new Nationality { Id = 4, Alpha2Code = "DE", Name = "Alemanha" },
                new Nationality { Id = 5, Alpha2Code = "AD", Name = "Andorra" },
                new Nationality { Id = 6, Alpha2Code = "AO", Name = "Angola" },
                new Nationality { Id = 7, Alpha2Code = "AI", Name = "Anguila" },
                new Nationality { Id = 8, Alpha2Code = "AQ", Name = "Antárctica" },
                new Nationality { Id = 9, Alpha2Code = "AG", Name = "Antígua e Barbuda" },
                new Nationality { Id = 10, Alpha2Code = "AN", Name = "Antilhas Holandesas" },
                new Nationality { Id = 11, Alpha2Code = "SA", Name = "Arábia Saudita" },
                new Nationality { Id = 12, Alpha2Code = "DZ", Name = "Argélia" },
                new Nationality { Id = 13, Alpha2Code = "AR", Name = "Argentina" },
                new Nationality { Id = 14, Alpha2Code = "AM", Name = "Arménia" },
                new Nationality { Id = 15, Alpha2Code = "AW", Name = "Aruba" },
                new Nationality { Id = 16, Alpha2Code = "AU", Name = "Austrália" },
                new Nationality { Id = 17, Alpha2Code = "AT", Name = "Áustria" },
                new Nationality { Id = 18, Alpha2Code = "AZ", Name = "Azerbaijão" },
                new Nationality { Id = 19, Alpha2Code = "BS", Name = "Bahamas" },
                new Nationality { Id = 20, Alpha2Code = "BD", Name = "Bangladesh" },
                new Nationality { Id = 21, Alpha2Code = "BB", Name = "Barbados" },
                new Nationality { Id = 22, Alpha2Code = "BH", Name = "Barém" },
                new Nationality { Id = 23, Alpha2Code = "BE", Name = "Bélgica" },
                new Nationality { Id = 24, Alpha2Code = "BZ", Name = "Belize" },
                new Nationality { Id = 25, Alpha2Code = "BJ", Name = "Benim" },
                new Nationality { Id = 26, Alpha2Code = "BM", Name = "Bermudas" },
                new Nationality { Id = 27, Alpha2Code = "BY", Name = "Bielorrússia" },
                new Nationality { Id = 28, Alpha2Code = "BO", Name = "Bolívia, Estado Plurinacional da" },
                new Nationality { Id = 29, Alpha2Code = "BQ", Name = "Bonaire, Santo Eustáquio e Saba" },
                new Nationality { Id = 30, Alpha2Code = "BA", Name = "Bósnia-Herzegovina" },
                new Nationality { Id = 31, Alpha2Code = "BW", Name = "Botswana" },
                new Nationality { Id = 32, Alpha2Code = "BR", Name = "Brasil" },
                new Nationality { Id = 33, Alpha2Code = "BN", Name = "Brunei Darussalam" },
                new Nationality { Id = 34, Alpha2Code = "BG", Name = "Bulgária" },
                new Nationality { Id = 35, Alpha2Code = "BF", Name = "Burkina Faso" },
                new Nationality { Id = 36, Alpha2Code = "BI", Name = "Burundi" },
                new Nationality { Id = 37, Alpha2Code = "BT", Name = "Butão" },
                new Nationality { Id = 38, Alpha2Code = "CV", Name = "Cabo Verde" },
                new Nationality { Id = 39, Alpha2Code = "CM", Name = "Camarões" },
                new Nationality { Id = 40, Alpha2Code = "KH", Name = "Camboja" },
                new Nationality { Id = 41, Alpha2Code = "CA", Name = "Canadá" },
                new Nationality { Id = 42, Alpha2Code = "QA", Name = "Catar" },
                new Nationality { Id = 43, Alpha2Code = "KZ", Name = "Cazaquistão" },
                new Nationality { Id = 44, Alpha2Code = "CF", Name = "Centro-Africana (República)" },
                new Nationality { Id = 45, Alpha2Code = "TD", Name = "Chade" },
                new Nationality { Id = 46, Alpha2Code = "CL", Name = "Chile" },
                new Nationality { Id = 47, Alpha2Code = "CN", Name = "China" },
                new Nationality { Id = 48, Alpha2Code = "CY", Name = "Chipre" },
                new Nationality { Id = 49, Alpha2Code = "CO", Name = "Colômbia" },
                new Nationality { Id = 50, Alpha2Code = "KM", Name = "Comores" },
                new Nationality { Id = 51, Alpha2Code = "CG", Name = "Congo" },
                new Nationality { Id = 52, Alpha2Code = "CD", Name = "Congo (República Democrática do)" },
                new Nationality { Id = 53, Alpha2Code = "KR", Name = "Coreia (República da)" },
                new Nationality { Id = 54, Alpha2Code = "KP", Name = "Coreia (República Popular Democrática da)" },
                new Nationality { Id = 55, Alpha2Code = "CI", Name = "Costa do Marfim" },
                new Nationality { Id = 56, Alpha2Code = "CR", Name = "Costa Rica" },
                new Nationality { Id = 57, Alpha2Code = "HR", Name = "Croácia" },
                new Nationality { Id = 58, Alpha2Code = "CU", Name = "Cuba" },
                new Nationality { Id = 59, Alpha2Code = "CW", Name = "Curaçau" },
                new Nationality { Id = 60, Alpha2Code = "DK", Name = "Dinamarca" },
                new Nationality { Id = 61, Alpha2Code = "DM", Name = "Domínica" },
                new Nationality { Id = 62, Alpha2Code = "EG", Name = "Egipto" },
                new Nationality { Id = 63, Alpha2Code = "SV", Name = "El Salvador" },
                new Nationality { Id = 64, Alpha2Code = "AE", Name = "Emiratos Árabes Unidos" },
                new Nationality { Id = 65, Alpha2Code = "EC", Name = "Equador" },
                new Nationality { Id = 66, Alpha2Code = "ER", Name = "Eritreia" },
                new Nationality { Id = 67, Alpha2Code = "SK", Name = "Eslováquia" },
                new Nationality { Id = 68, Alpha2Code = "SI", Name = "Eslovénia" },
                new Nationality { Id = 69, Alpha2Code = "ES", Name = "Espanha" },
                new Nationality { Id = 70, Alpha2Code = "US", Name = "Estados Unidos" },
                new Nationality { Id = 71, Alpha2Code = "EE", Name = "Estónia" },
                new Nationality { Id = 72, Alpha2Code = "ET", Name = "Etiópia" },
                new Nationality { Id = 73, Alpha2Code = "PH", Name = "Filipinas" },
                new Nationality { Id = 74, Alpha2Code = "FI", Name = "Finlândia" },
                new Nationality { Id = 75, Alpha2Code = "FR", Name = "França" },
                new Nationality { Id = 76, Alpha2Code = "GA", Name = "Gabão" },
                new Nationality { Id = 77, Alpha2Code = "GM", Name = "Gâmbia" },
                new Nationality { Id = 78, Alpha2Code = "GH", Name = "Gana" },
                new Nationality { Id = 79, Alpha2Code = "GE", Name = "Geórgia" },
                new Nationality { Id = 80, Alpha2Code = "GS", Name = "Geórgia do Sul e Ilhas Sandwich" },
                new Nationality { Id = 81, Alpha2Code = "GI", Name = "Gibraltar" },
                new Nationality { Id = 82, Alpha2Code = "GD", Name = "Granada" },
                new Nationality { Id = 83, Alpha2Code = "GR", Name = "Grécia" },
                new Nationality { Id = 84, Alpha2Code = "GL", Name = "Gronelândia" },
                new Nationality { Id = 85, Alpha2Code = "GP", Name = "Guadalupe" },
                new Nationality { Id = 86, Alpha2Code = "GU", Name = "Guam" },
                new Nationality { Id = 87, Alpha2Code = "GT", Name = "Guatemala" },
                new Nationality { Id = 88, Alpha2Code = "GG", Name = "Guernsey" },
                new Nationality { Id = 89, Alpha2Code = "GY", Name = "Guiana" },
                new Nationality { Id = 90, Alpha2Code = "GF", Name = "Guiana Francesa" },
                new Nationality { Id = 91, Alpha2Code = "GN", Name = "Guiné" },
                new Nationality { Id = 92, Alpha2Code = "GQ", Name = "Guiné Equatorial" },
                new Nationality { Id = 93, Alpha2Code = "GW", Name = "Guiné-Bissau" },
                new Nationality { Id = 94, Alpha2Code = "HT", Name = "Haiti" },
                new Nationality { Id = 95, Alpha2Code = "HN", Name = "Honduras" },
                new Nationality { Id = 96, Alpha2Code = "HK", Name = "Hong Kong" },
                new Nationality { Id = 97, Alpha2Code = "HU", Name = "Hungria" },
                new Nationality { Id = 98, Alpha2Code = "YE", Name = "Iémen" },
                new Nationality { Id = 99, Alpha2Code = "BV", Name = "Ilha Bouvet" },
                new Nationality { Id = 100, Alpha2Code = "CX", Name = "Ilha Christmas" },
                new Nationality { Id = 101, Alpha2Code = "IM", Name = "Ilha de Man" },
                new Nationality { Id = 102, Alpha2Code = "HM", Name = "Ilha Heard e Ilhas McDonald" },
                new Nationality { Id = 103, Alpha2Code = "NF", Name = "Ilha Norfolk" },
                new Nationality { Id = 104, Alpha2Code = "AX", Name = "Ilhas Aland" },
                new Nationality { Id = 105, Alpha2Code = "KY", Name = "Ilhas Caimão" },
                new Nationality { Id = 106, Alpha2Code = "CC", Name = "Ilhas Cocos (Keeling)" },
                new Nationality { Id = 107, Alpha2Code = "CK", Name = "Ilhas Cook" },
                new Nationality { Id = 108, Alpha2Code = "FK", Name = "Ilhas Falkland (Malvinas)" },
                new Nationality { Id = 109, Alpha2Code = "FO", Name = "Ilhas Faroé" },
                new Nationality { Id = 110, Alpha2Code = "FJ", Name = "Ilhas Fiji" },
                new Nationality { Id = 111, Alpha2Code = "MP", Name = "Ilhas Marianas do Norte" },
                new Nationality { Id = 112, Alpha2Code = "MH", Name = "Ilhas Marshall" },
                new Nationality { Id = 113, Alpha2Code = "UM", Name = "Ilhas Menores Distantes dos Estados Unidos" },
                new Nationality { Id = 114, Alpha2Code = "SB", Name = "Ilhas Salomão" },
                new Nationality { Id = 115, Alpha2Code = "TC", Name = "Ilhas Turcas e Caicos" },
                new Nationality { Id = 116, Alpha2Code = "VG", Name = "Ilhas Virgens (Britânicas)" },
                new Nationality { Id = 117, Alpha2Code = "VI", Name = "Ilhas Virgens (Estados Unidos)" },
                new Nationality { Id = 118, Alpha2Code = "IN", Name = "Índia" },
                new Nationality { Id = 119, Alpha2Code = "ID", Name = "Indonésia" },
                new Nationality { Id = 120, Alpha2Code = "IR", Name = "Irão (República Islâmica)" },
                new Nationality { Id = 121, Alpha2Code = "IQ", Name = "Iraque" },
                new Nationality { Id = 122, Alpha2Code = "IE", Name = "Irlanda" },
                new Nationality { Id = 123, Alpha2Code = "IS", Name = "Islândia" },
                new Nationality { Id = 124, Alpha2Code = "IL", Name = "Israel" },
                new Nationality { Id = 125, Alpha2Code = "IT", Name = "Itália" },
                new Nationality { Id = 126, Alpha2Code = "JM", Name = "Jamaica" },
                new Nationality { Id = 127, Alpha2Code = "JP", Name = "Japão" },
                new Nationality { Id = 128, Alpha2Code = "JE", Name = "Jersey" },
                new Nationality { Id = 129, Alpha2Code = "DJ", Name = "Jibuti" },
                new Nationality { Id = 130, Alpha2Code = "JO", Name = "Jordânia" },
                new Nationality { Id = 131, Alpha2Code = "YU", Name = "Jugoslávia (extinto)" },
                new Nationality { Id = 132, Alpha2Code = "KI", Name = "Kiribati" },
                new Nationality { Id = 133, Alpha2Code = "XK", Name = "Kosovo" },
                new Nationality { Id = 134, Alpha2Code = "KW", Name = "Kuwait" },
                new Nationality { Id = 135, Alpha2Code = "LA", Name = "Laos (República Popular Democrática do)" },
                new Nationality { Id = 136, Alpha2Code = "LS", Name = "Lesoto" },
                new Nationality { Id = 137, Alpha2Code = "LV", Name = "Letónia" },
                new Nationality { Id = 138, Alpha2Code = "LB", Name = "Líbano" },
                new Nationality { Id = 139, Alpha2Code = "LR", Name = "Libéria" },
                new Nationality { Id = 140, Alpha2Code = "LY", Name = "Líbia" },
                new Nationality { Id = 141, Alpha2Code = "LI", Name = "Liechtenstein" },
                new Nationality { Id = 142, Alpha2Code = "LT", Name = "Lituânia" },
                new Nationality { Id = 143, Alpha2Code = "LU", Name = "Luxemburgo" },
                new Nationality { Id = 144, Alpha2Code = "MO", Name = "Macau" },
                new Nationality { Id = 145, Alpha2Code = "MK", Name = "Macedónia (antiga República Jugoslava da)" },
                new Nationality { Id = 146, Alpha2Code = "MG", Name = "Madagáscar" },
                new Nationality { Id = 147, Alpha2Code = "MY", Name = "Malásia" },
                new Nationality { Id = 148, Alpha2Code = "MW", Name = "Malawi" },
                new Nationality { Id = 149, Alpha2Code = "MV", Name = "Maldivas" },
                new Nationality { Id = 150, Alpha2Code = "ML", Name = "Mali" },
                new Nationality { Id = 151, Alpha2Code = "MT", Name = "Malta" },
                new Nationality { Id = 152, Alpha2Code = "MA", Name = "Marrocos" },
                new Nationality { Id = 153, Alpha2Code = "MQ", Name = "Martinica" },
                new Nationality { Id = 154, Alpha2Code = "MU", Name = "Maurícias" },
                new Nationality { Id = 155, Alpha2Code = "MR", Name = "Mauritânia" },
                new Nationality { Id = 156, Alpha2Code = "YT", Name = "Mayotte" },
                new Nationality { Id = 157, Alpha2Code = "MX", Name = "México" },
                new Nationality { Id = 158, Alpha2Code = "FM", Name = "Micronésia (Estados Federados da)" },
                new Nationality { Id = 159, Alpha2Code = "MZ", Name = "Moçambique" },
                new Nationality { Id = 160, Alpha2Code = "MD", Name = "Moldova, República de" },
                new Nationality { Id = 161, Alpha2Code = "MC", Name = "Mónaco" },
                new Nationality { Id = 162, Alpha2Code = "MN", Name = "Mongólia" },
                new Nationality { Id = 163, Alpha2Code = "MS", Name = "Monserrate" },
                new Nationality { Id = 164, Alpha2Code = "ME", Name = "Montenegro" },
                new Nationality { Id = 165, Alpha2Code = "MM", Name = "Myanmar" },
                new Nationality { Id = 166, Alpha2Code = "NA", Name = "Namíbia" },
                new Nationality { Id = 167, Alpha2Code = "NR", Name = "Nauru" },
                new Nationality { Id = 168, Alpha2Code = "NP", Name = "Nepal" },
                new Nationality { Id = 169, Alpha2Code = "NI", Name = "Nicarágua" },
                new Nationality { Id = 170, Alpha2Code = "NE", Name = "Niger" },
                new Nationality { Id = 171, Alpha2Code = "NG", Name = "Nigéria" },
                new Nationality { Id = 172, Alpha2Code = "NU", Name = "Niue" },
                new Nationality { Id = 173, Alpha2Code = "NO", Name = "Noruega" },
                new Nationality { Id = 174, Alpha2Code = "NC", Name = "Nova Caledónia" },
                new Nationality { Id = 175, Alpha2Code = "NZ", Name = "Nova Zelândia" },
                new Nationality { Id = 176, Alpha2Code = "OM", Name = "Omã" },
                new Nationality { Id = 177, Alpha2Code = "NL", Name = "Países Baixos" },
                new Nationality { Id = 178, Alpha2Code = "PW", Name = "Palau" },
                new Nationality { Id = 179, Alpha2Code = "PA", Name = "Panamá" },
                new Nationality { Id = 180, Alpha2Code = "PG", Name = "Papuásia-Nova Guiné" },
                new Nationality { Id = 181, Alpha2Code = "PK", Name = "Paquistão" },
                new Nationality { Id = 182, Alpha2Code = "PY", Name = "Paraguai" },
                new Nationality { Id = 183, Alpha2Code = "PE", Name = "Peru" },
                new Nationality { Id = 184, Alpha2Code = "PN", Name = "Pitcairn" },
                new Nationality { Id = 185, Alpha2Code = "PF", Name = "Polinésia Francesa" },
                new Nationality { Id = 186, Alpha2Code = "PL", Name = "Polónia" },
                new Nationality { Id = 187, Alpha2Code = "PR", Name = "Porto Rico" },
                new Nationality { Id = 188, Alpha2Code = "PT", Name = "Portugal" },
                new Nationality { Id = 189, Alpha2Code = "KE", Name = "Quénia" },
                new Nationality { Id = 190, Alpha2Code = "KG", Name = "Quirguizistão" },
                new Nationality { Id = 191, Alpha2Code = "GB", Name = "Reino Unido" },
                new Nationality { Id = 192, Alpha2Code = "CZ", Name = "República Checa" },
                new Nationality { Id = 193, Alpha2Code = "DO", Name = "República Dominicana" },
                new Nationality { Id = 194, Alpha2Code = "RE", Name = "Reunião" },
                new Nationality { Id = 195, Alpha2Code = "RO", Name = "Roménia" },
                new Nationality { Id = 196, Alpha2Code = "RW", Name = "Ruanda" },
                new Nationality { Id = 197, Alpha2Code = "RU", Name = "Rússia (Federação da)" },
                new Nationality { Id = 198, Alpha2Code = "WS", Name = "Samoa" },
                new Nationality { Id = 199, Alpha2Code = "AS", Name = "Samoa Americana" },
                new Nationality { Id = 200, Alpha2Code = "SH", Name = "Santa Helena, Ascensão e Tristão da Cunha" },
                new Nationality { Id = 201, Alpha2Code = "LC", Name = "Santa Lúcia" },
                new Nationality { Id = 202, Alpha2Code = "VA", Name = "Santa Sé (Cidade Estado do Vaticano)" },
                new Nationality { Id = 203, Alpha2Code = "BL", Name = "São Bartolomeu" },
                new Nationality { Id = 204, Alpha2Code = "KN", Name = "São Cristóvão e Nevis" },
                new Nationality { Id = 205, Alpha2Code = "SM", Name = "São Marino" },
                new Nationality { Id = 206, Alpha2Code = "MF", Name = "São Martinho (parte francesa)" },
                new Nationality { Id = 207, Alpha2Code = "SX", Name = "São Martinho (parte holandesa)" },
                new Nationality { Id = 208, Alpha2Code = "PM", Name = "São Pedro e Miquelon" },
                new Nationality { Id = 209, Alpha2Code = "ST", Name = "São Tomé e Príncipe" },
                new Nationality { Id = 210, Alpha2Code = "VC", Name = "São Vicente e Granadinas" },
                new Nationality { Id = 211, Alpha2Code = "EH", Name = "Sara Ocidental" },
                new Nationality { Id = 212, Alpha2Code = "SN", Name = "Senegal" },
                new Nationality { Id = 213, Alpha2Code = "SL", Name = "Serra Leoa" },
                new Nationality { Id = 214, Alpha2Code = "RS", Name = "Sérvia" },
                new Nationality { Id = 215, Alpha2Code = "CS", Name = "Sérvia e Montenegro (extinto)" },
                new Nationality { Id = 216, Alpha2Code = "SC", Name = "Seychelles" },
                new Nationality { Id = 217, Alpha2Code = "SG", Name = "Singapura" },
                new Nationality { Id = 218, Alpha2Code = "SY", Name = "Síria (República Árabe da)" },
                new Nationality { Id = 219, Alpha2Code = "SO", Name = "Somália" },
                new Nationality { Id = 220, Alpha2Code = "LK", Name = "Sri Lanka" },
                new Nationality { Id = 221, Alpha2Code = "SZ", Name = "Suazilândia" },
                new Nationality { Id = 222, Alpha2Code = "SD", Name = "Sudão" },
                new Nationality { Id = 223, Alpha2Code = "SS", Name = "Sudão do Sul" },
                new Nationality { Id = 224, Alpha2Code = "SE", Name = "Suécia" },
                new Nationality { Id = 225, Alpha2Code = "CH", Name = "Suíça" },
                new Nationality { Id = 226, Alpha2Code = "SR", Name = "Suriname" },
                new Nationality { Id = 227, Alpha2Code = "SJ", Name = "Svalbard e a Ilha de Jan Mayen" },
                new Nationality { Id = 228, Alpha2Code = "TH", Name = "Tailândia" },
                new Nationality { Id = 229, Alpha2Code = "TW", Name = "Taiwan (Província da China)" },
                new Nationality { Id = 230, Alpha2Code = "TJ", Name = "Tajiquistão" },
                new Nationality { Id = 231, Alpha2Code = "TZ", Name = "Tanzânia, República Unida da" },
                new Nationality { Id = 232, Alpha2Code = "IO", Name = "Território Britânico do Oceano Índico" },
                new Nationality { Id = 233, Alpha2Code = "PS", Name = "Território Palestiniano Ocupado" },
                new Nationality { Id = 234, Alpha2Code = "TF", Name = "Territórios Franceses do Sul" },
                new Nationality { Id = 235, Alpha2Code = "TL", Name = "Timor Leste" },
                new Nationality { Id = 236, Alpha2Code = "TG", Name = "Togo" },
                new Nationality { Id = 237, Alpha2Code = "TK", Name = "Tokelau" },
                new Nationality { Id = 238, Alpha2Code = "TO", Name = "Tonga" },
                new Nationality { Id = 239, Alpha2Code = "TT", Name = "Trindade e Tobago" },
                new Nationality { Id = 240, Alpha2Code = "TN", Name = "Tunísia" },
                new Nationality { Id = 241, Alpha2Code = "TM", Name = "Turquemenistão" },
                new Nationality { Id = 242, Alpha2Code = "TR", Name = "Turquia" },
                new Nationality { Id = 243, Alpha2Code = "TV", Name = "Tuvalu" },
                new Nationality { Id = 244, Alpha2Code = "UA", Name = "Ucrânia" },
                new Nationality { Id = 245, Alpha2Code = "UG", Name = "Uganda" },
                new Nationality { Id = 246, Alpha2Code = "UY", Name = "Uruguai" },
                new Nationality { Id = 247, Alpha2Code = "UZ", Name = "Usbequistão" },
                new Nationality { Id = 248, Alpha2Code = "VU", Name = "Vanuatu" },
                new Nationality { Id = 249, Alpha2Code = "VE", Name = "Venezuela, República Bolivariana da" },
                new Nationality { Id = 250, Alpha2Code = "VN", Name = "Vietname" },
                new Nationality { Id = 251, Alpha2Code = "WF", Name = "Wallis e Futuna (Ilhas)" },
                new Nationality { Id = 252, Alpha2Code = "ZM", Name = "Zâmbia" },
                new Nationality { Id = 253, Alpha2Code = "ZW", Name = "Zimbabwe" }
                );

            // Seed data for the table 'Advisors'.
            modelBuilder.Entity<Advisor>().HasData(
                new Advisor {
                    Id = 1,
                    UserId = "1",
                    Name = "Ana Cristina Barata Pires Lopes",
                    Email = "anacris@ipt.pt",
                    IdentificationNumber = "225630605",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 2,
                    UserId = "2",
                    Name = "António Casimiro Teixeira Batista",
                    Email = "cbatista@ipt.pt",
                    IdentificationNumber = "252394020",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = false,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 3,
                    UserId = "3",
                    Name = "António Manuel Rodrigues Manso",
                    Email = "manso@ipt.pt",
                    IdentificationNumber = "215755812",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 4,
                    UserId = "4",
                    Name = "Bruno Manuel de Almeida Santos",
                    Email = "bruno.almeida@ipt.pt",
                    IdentificationNumber = "246221933",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = false,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 5,
                    UserId = "5",
                    Name = "Carlos David Magalhães Queiroz",
                    Email = "carloqrz@ipt.pt",
                    IdentificationNumber = "266415369",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = false,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 6,
                    UserId = "6",
                    Name = "Carlos Filipe Perquilhas Baptista",
                    Email = "carlos.perquilhas@ipt.pt",
                    IdentificationNumber = "213937042",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = false,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 7,
                    UserId = "7",
                    Name = "Francisco José Alexandre Nunes",
                    Email = "fnunes@ipt.pt",
                    IdentificationNumber = "233018131",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = false,
                    Specialist = true
                },
                new Advisor
                {
                    Id = 8,
                    UserId = "8",
                    Name = "José Casimiro Nunes Pereira",
                    Email = "casimiro@ipt.pt",
                    IdentificationNumber = "248716093",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 9,
                    UserId = "9",
                    Name = "Luís Miguel Lopes de Oliveira",
                    Email = "loliveira@ipt.pt",
                    IdentificationNumber = "223054321",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = true
                },
                new Advisor
                {
                    Id = 10,
                    UserId = "10",
                    Name = "Manuel Fernando Martins de Barros",
                    Email = "fmbarros@ipt.pt",
                    IdentificationNumber = "291610072",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 11,
                    UserId = "11",
                    Name = "Gabriel Pereira Pires",
                    Email = "gppires@ipt.pt",
                    IdentificationNumber = "209630108",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = false
                },
                new Advisor
                {
                    Id = 12,
                    UserId = "12",
                    Name = "Renato Eduardo Silva Panda",
                    Email = "renato.panda@ipt.pt",
                    IdentificationNumber = "266266568",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    External = false,
                    PhD = true,
                    Specialist = false
                }
                );

            // Seed data for the table 'Students'.
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 13,
                    UserId = "13",
                    Name = "Joni Correia",
                    Email = "aluno15501@ipt.pt",
                    IdentificationNumber = "289985692",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    StudentId = "15501",
                    Sex = PersonSex.male,
                    Address = "R Germana Tânger 75",
                    PostalCode = "2720-428 AMADORA"
                },
                new Student
                {
                    Id = 14,
                    UserId = "14",
                    Name = "Gonçalo Nunes",
                    Email = "aluno20568@ipt.pt",
                    IdentificationNumber = "202553205",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    StudentId = "20568",
                    Sex = PersonSex.male,
                    Address = "R Gago Coutinho 82",
                    PostalCode = "3885-467 ESMORIZ"
                },
                new Student
                {
                    Id = 15,
                    UserId = "15",
                    Name = "José Fernando Silva",
                    Email = "aluno20796@ipt.pt",
                    IdentificationNumber = "213517051",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    StudentId = "20796",
                    Sex = PersonSex.male,
                    Address = "R Figueiras 112",
                    PostalCode = "4515-323 LOMBA"
                },
                new Student
                {
                    Id = 16,
                    UserId = "16",
                    Name = "João Franscisco",
                    Email = "aluno21876@ipt.pt",
                    IdentificationNumber = "203512421",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    StudentId = "21876",
                    Sex = PersonSex.male,
                    Address = "R Irene Lisboa 99",
                    PostalCode = "2680-088 CAMARATE"
                },
                new Student
                {
                    Id = 17,
                    UserId = "17",
                    Name = "André Duarte de Sá",
                    Email = "aluno21296@ipt.pt",
                    IdentificationNumber = "296435511",
                    IdentificationTypeFK = 1,
                    NationalityFK = 188,
                    StudentId = "21296",
                    Sex = PersonSex.male,
                    Address = "Travessa Vale da Loura 11",
                    PostalCode = "2260-027 ATALAIA VNB"
                }
                );

            // Seed users data.
            string password = "User123.";
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1",
                    Email = "anacris@ipt.pt", NormalizedEmail = "ANACRIS@IPT.PT", EmailConfirmed = true,
                    UserName = "anacris@ipt.pt", NormalizedUserName = "ANACRIS@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "2",
                    Email = "cbatista@ipt.pt", NormalizedEmail = "CBATISTA@IPT.PT", EmailConfirmed = true,
                    UserName = "cbatista@ipt.pt", NormalizedUserName = "CBATISTA@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "3",
                    Email = "manso@ipt.pt", NormalizedEmail = "MANSO@IPT.PT", EmailConfirmed = true,
                    UserName = "manso@ipt.pt", NormalizedUserName = "MANSO@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "4",
                    Email = "bruno.almeida@ipt.pt", NormalizedEmail = "BRUNO.ALMEIDA@IPT.PT", EmailConfirmed = true,
                    UserName = "bruno.almeida@ipt.pt", NormalizedUserName = "BRUNO.ALMEIDA@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "5",
                    Email = "carloqrz@ipt.pt", NormalizedEmail = "CARLOQRZ@IPT.PT", EmailConfirmed = true,
                    UserName = "carloqrz@ipt.pt", NormalizedUserName = "CARLOQRZ@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "6",
                    Email = "carlos.perquilhas@ipt.pt", NormalizedEmail = "CARLOS.PERQUILHAS@IPT.PT", EmailConfirmed = true,
                    UserName = "carlos.perquilhas@ipt.pt", NormalizedUserName = "CARLOS.PERQUILHAS@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "7",
                    Email = "fnunes@ipt.pt", NormalizedEmail = "FNUNES@IPT.PT", EmailConfirmed = true,
                    UserName = "fnunes@ipt.pt", NormalizedUserName = "FNUNES@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "8",
                    Email = "casimiro@ipt.pt", NormalizedEmail = "CASIMIRO@IPT.PT", EmailConfirmed = true,
                    UserName = "casimiro@ipt.pt", NormalizedUserName = "CASIMIRO@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "9",
                    Email = "loliveira@ipt.pt",
                    NormalizedEmail = "LOLIVEIRA@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "loliveira@ipt.pt",
                    NormalizedUserName = "LOLIVEIRA@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "10",
                    Email = "fmbarros@ipt.pt",
                    NormalizedEmail = "FMBARROS@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "fmbarros@ipt.pt",
                    NormalizedUserName = "FMBARROS@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "11",
                    Email = "gppires@ipt.pt",
                    NormalizedEmail = "GPPIRES@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "gppires@ipt.pt",
                    NormalizedUserName = "GPPIRES@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "12",
                    Email = "renato.panda@ipt.pt",
                    NormalizedEmail = "RENATO.PANDA@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "renato.panda@ipt.pt",
                    NormalizedUserName = "RENATO.PANDA@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "13",
                    Email = "aluno15501@ipt.pt",
                    NormalizedEmail = "ALUNO15501@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "aluno15501@ipt.pt",
                    NormalizedUserName = "ALUNO15501@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "14",
                    Email = "aluno20568@ipt.pt",
                    NormalizedEmail = "ALUNO20568@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "aluno20568@ipt.pt",
                    NormalizedUserName = "ALUNO20568@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "15",
                    Email = "aluno20796@ipt.pt",
                    NormalizedEmail = "ALUNO20796@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "aluno20796@ipt.pt",
                    NormalizedUserName = "ALUNO20796@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "16",
                    Email = "aluno21876@ipt.pt",
                    NormalizedEmail = "ALUNO21876@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "aluno21876@ipt.pt",
                    NormalizedUserName = "ALUNO21876@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                },
                new IdentityUser
                {
                    Id = "17",
                    Email = "aluno21296@ipt.pt",
                    NormalizedEmail = "ALUNO21296@IPT.PT",
                    EmailConfirmed = true,
                    UserName = "aluno21296@ipt.pt",
                    NormalizedUserName = "ALUNO21296@IPT.PT",
                    PasswordHash = hasher.HashPassword(null, password)
                }
                );

            // Seed data for the table 'AspNetUserRoles'.
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "1" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "2" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "3" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "4" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "5" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "6" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "7" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "8" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "9" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "10" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "11" },
                new IdentityUserRole<string> { RoleId = "advisor", UserId = "12" },
                new IdentityUserRole<string> { RoleId = "student", UserId = "13" },
                new IdentityUserRole<string> { RoleId = "student", UserId = "14" },
                new IdentityUserRole<string> { RoleId = "student", UserId = "15" },
                new IdentityUserRole<string> { RoleId = "student", UserId = "16" },
                new IdentityUserRole<string> { RoleId = "student", UserId = "17" }
                );

            // Seed data for the table 'Enrollments'.
            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { Id = 1, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 162, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3 ,StudentFK = 13, CourseFK = 11 },
                new Enrollment { Id = 2, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 156, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 14, CourseFK = 11 },
                new Enrollment { Id = 3, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 162, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 15, CourseFK = 11 },
                new Enrollment { Id = 4, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 116, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 16, CourseFK = 11 },
                new Enrollment { Id = 5, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 168, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 17, CourseFK = 11 },
                
                new Enrollment { Id = 6, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 160, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 18, CourseFK = 11 },
                new Enrollment { Id = 7, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 150, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 19, CourseFK = 11 },
                new Enrollment { Id = 8, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 165, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 20, CourseFK = 11 },
                new Enrollment { Id = 9, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 121, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 21, CourseFK = 11 },
                new Enrollment { Id = 10, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 120, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 22, CourseFK = 11 },
                new Enrollment { Id = 11, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 155, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 23, CourseFK = 11 },
                new Enrollment { Id = 12, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 135, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 24, CourseFK = 11 },
                new Enrollment { Id = 13, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 130, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 25, CourseFK = 11 },
                new Enrollment { Id = 14, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 109, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 26, CourseFK = 11 },
                new Enrollment { Id = 15, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 155, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 27, CourseFK = 11 },
                new Enrollment { Id = 16, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 134, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 28, CourseFK = 11 },
                new Enrollment { Id = 17, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 129, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 29, CourseFK = 11 },
                new Enrollment { Id = 18, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 99, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 30, CourseFK = 11 },
                new Enrollment { Id = 19, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 149, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 31, CourseFK = 11 },
                new Enrollment { Id = 20, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 115, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 32, CourseFK = 11 },
                new Enrollment { Id = 21, EnrollmentStatus = EnrollmentStatus.ongoing, ECTS = 120, EnrollmentStartedFK = 3, EnrollmentCompletedFK = 3, StudentFK = 33, CourseFK = 11 }
                );

            // Seed data for the 'CourseAdvisors'.
            modelBuilder.Entity<CourseAdvisor>().HasData(
                new CourseAdvisor { Id = 1, AdvisorFK = 1, CourseFK = 10, IsAdmin = false },
                new CourseAdvisor { Id = 2, AdvisorFK = 1, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 3, AdvisorFK = 1, CourseFK = 30, IsAdmin = true },
                new CourseAdvisor { Id = 4, AdvisorFK = 2, CourseFK = 10, IsAdmin = false },
                new CourseAdvisor { Id = 5, AdvisorFK = 2, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 6, AdvisorFK = 3, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 7, AdvisorFK = 4, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 8, AdvisorFK = 5, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 9, AdvisorFK = 6, CourseFK = 10, IsAdmin = false },
                new CourseAdvisor { Id = 10, AdvisorFK = 6, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 11, AdvisorFK = 6, CourseFK = 13, IsAdmin = false },
                new CourseAdvisor { Id = 12, AdvisorFK = 6, CourseFK = 20, IsAdmin = false },
                new CourseAdvisor { Id = 13, AdvisorFK = 7, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 14, AdvisorFK = 7, CourseFK = 12, IsAdmin = false },
                new CourseAdvisor { Id = 15, AdvisorFK = 7, CourseFK = 29, IsAdmin = false },
                new CourseAdvisor { Id = 16, AdvisorFK = 8, CourseFK = 30, IsAdmin = false },
                new CourseAdvisor { Id = 17, AdvisorFK = 9, CourseFK = 11, IsAdmin = true },
                new CourseAdvisor { Id = 18, AdvisorFK = 9, CourseFK = 30, IsAdmin = false },
                new CourseAdvisor { Id = 19, AdvisorFK = 10, CourseFK = 10, IsAdmin = false },
                new CourseAdvisor { Id = 20, AdvisorFK = 10, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 21, AdvisorFK = 10, CourseFK = 29, IsAdmin = false },
                new CourseAdvisor { Id = 22, AdvisorFK = 11, CourseFK = 10, IsAdmin = false },
                new CourseAdvisor { Id = 23, AdvisorFK = 11, CourseFK = 29, IsAdmin = false },
                new CourseAdvisor { Id = 24, AdvisorFK = 11, CourseFK = 30, IsAdmin = false },
                new CourseAdvisor { Id = 25, AdvisorFK = 12, CourseFK = 11, IsAdmin = false },
                new CourseAdvisor { Id = 26, AdvisorFK = 12, CourseFK = 30, IsAdmin = false },
                new CourseAdvisor { Id = 27, AdvisorFK = 8, CourseFK = 11, IsAdmin = true }
                );

            // Seed data for the table 'Institutions'.
            modelBuilder.Entity<Institution>().HasData(
                new Institution { Id = 1, Name = "Instituto Politécnico de Tomar", Site = "www.ipt.pt" },
                new Institution { Id = 2, Name = "Softinsa - IBM", Site = "www.softinsa.pt" },
                new Institution { Id = 3, Name = "Cycloid", Site = "www.cycloid.pt" },
                new Institution { Id = 4, Name = "Kyntech", Site = "www.kyntech.pt" },
                new Institution { Id = 5, Name = "Critical Software", Site = "www.criticalsoftware.com" }
                );

        }

        // ---------------------------------------------------------------------------------------- //
        // ----- [Adding tables to database] ------------------------------------------------------ //
        // ---------------------------------------------------------------------------------------- //

        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<AccessType> AccessTypes { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationProposal> ApplicationProposals { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAdvisor> CourseAdvisors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<IdentificationType> IdentificationTypes { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<JuryMember> JuryMembers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<OrganicUnit> OrganicUnits { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDefense> ProjectDefenses { get; set; }
        public DbSet<ProjectValidation> ProjectsValidations { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<RepositoryCollection> RepositoryCollections { get; set; }
        public DbSet<ResearchProject> ResearchProjects { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}