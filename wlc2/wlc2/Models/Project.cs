using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the project submitted by a student.
    /// </summary>
    public class Project {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Project() { 
            RepositoryCollections   = new HashSet<RepositoryCollection>();
            ResearchProjects        = new HashSet<ResearchProject>();
            Advisors                = new HashSet<Advisor>();
            Students                = new HashSet<Student>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title of the project.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Abstract of the project.
        /// </summary>
        public string AbstractPT { get; set; }

        /// <summary>
        /// Abstract of the project.
        /// </summary>
        public string AbstractEN { get; set; }

        /// <summary>
        /// Project keywords in portuguese.
        /// </summary>
        public string KeywordsPT { get; set; }

        /// <summary>
        /// Project keywords in english.
        /// </summary>
        public string KeywordsEN { get; set; }

        public ProjectStatus ProjectStatus { get; set; }

        public int Grade { get; set; }

        /// <summary>
        /// Project Report
        /// </summary>
        public string ProjectReport { get; set; }

        /**
         * Foreign Keys.
         */

        [ForeignKey(nameof(Course))]
        public int CourseFK { get; set; }
        /// <summary>
        /// Project's course.
        /// </summary>
        public Course Course { get; set; }

        [ForeignKey(nameof(AcademicYear))]
        public int AcademicYearFK { get; set; }
        /// <summary>
        /// Project's academic year.
        /// </summary>
        public AcademicYear AcademicYear { get; set; }

        [ForeignKey(nameof(Language))]
        public int LanguageFK { get; set; }
        /// <summary>
        /// Project language.
        /// </summary>
        public Language Language { get; set; }

        [ForeignKey(nameof(AccessType))]
        public int AccessTypeFK { get; set; }
        /// <summary>
        /// Project access type.
        /// </summary>
        public AccessType AccessType { get; set; }

        [ForeignKey(nameof(License))]
        public int LicenseFK { get; set; }
        /// <summary>
        /// License used by this project.
        /// </summary>
        public License License { get; set; }

        //[ForeignKey(nameof(ProjectDefense))]
        //public int ProjectDefenseFK { get; set; }
        /// <summary>
        /// Project defense data for this project.
        /// </summary>
        public ProjectDefense ProjectDefense { get; set; }
        // TODO: confirmar relação 1-1

        /// <summary>
        /// List of students in the project.
        /// </summary>
        public ICollection<Student> Students { get; set; }

        /// <summary>
        /// List of repository collections used by the project.
        /// </summary>
        public ICollection<RepositoryCollection> RepositoryCollections { get; set; }

        /// <summary>
        /// List of the research projects that are associated to the project.
        /// </summary>
        public ICollection<ResearchProject> ResearchProjects { get; set; }

        /// <summary>
        /// List of advisors.
        /// </summary>
        public ICollection<Advisor> Advisors { get; set; }

    }

}
