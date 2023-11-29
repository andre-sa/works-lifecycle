using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {
    
    /// <summary>
    /// This class represents the academic years.
    /// </summary>
    public class AcademicYear {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public AcademicYear() {
            Proposals       = new HashSet<Proposal>();
            Projects        = new HashSet<Project>();
            Courses         = new HashSet<Course>();
            Applications    = new HashSet<Application>();
        }
        
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the academic year. Like 2022/2023.
        /// </summary>
        [Display(Name = "Ano Académico")]
        [Required(ErrorMessage = "É obrigatório definir um nome para o ano académico.")]
        public string Name { get; set; }

        /// <summary>
        /// Is this academic year the current one?
        /// </summary>
        [Display(Name = "Atual")]
        [Required(ErrorMessage = "É obrigatório definir se este ano académico é currente ou não.")]
        public bool Current { get; set; }

        /// <summary>
        /// List of proposals in this academic year.
        /// </summary>
        public ICollection<Proposal> Proposals { get; set; }

        /// <summary>
        /// List of projects in this academic year.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

        /// <summary>
        /// List of courses in this academic year.
        /// </summary>
        public ICollection<Course> Courses { get; set; }

        /// <summary>
        /// List of applications in this academic year.
        /// </summary>
        public ICollection<Application> Applications { get; set; }
    }
}
