using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the courses.
    /// </summary>
    public class Course {
        
        /// <summary>
        /// Class constructor.
        /// </summary>
        public Course() { 
            Projects        = new HashSet<Project>();
            Proposals       = new HashSet<Proposal>();
            Enrollments     = new HashSet<Enrollment>();
            AcademicYears   = new HashSet<AcademicYear>();
            Applications    = new HashSet<Application>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Course code.
        /// </summary>
        [Display(Name = "Código")]
        [Required(ErrorMessage = "É obrigatório definir um código para o curso.")]
        public string Code { get; set; }

        /// <summary>
        /// Course name.
        /// </summary>
        [Display(Name = "Nome do Curso")]
        [Required(ErrorMessage = "É obrigatório definir um nome para o curso.")]
        public string Name { get; set; }

        /// <summary>
        /// Course name abbreviation.
        /// </summary>
        [Display(Name = "Abreviação")]
        [Required(ErrorMessage = "É obrigatório definir uma abreviação para o nome do curso.")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Course degree (bachelor, master, doctorate)
        /// </summary>
        public Degree Degree { get; set; }

        /* Foreign Keys */

        /// <summary>
        /// Course organic unit (foreign key).
        /// </summary>
        [ForeignKey(nameof(OrganicUnit))]
        public int OrganicUnitFK { get; set; }
        [Display(Name = "Unidade Orgânica")]
        [Required(ErrorMessage = "É obrigatório definiar a unidade orgânica.")]
        public OrganicUnit OrganicUnit { get; set; }

        /// <summary>
        /// Course area (foreign key).
        /// </summary>
        [ForeignKey(nameof(Area))]
        public int AreaFK { get; set; }
        [Display(Name = "Área")]
        [Required(ErrorMessage = "É obrigatório definiar a área.")]
        public Area Area { get; set; }

        /// <summary>
        /// List of projects of this course.
        /// </summary>
        public ICollection<Application> Applications { get; set; }

        /// <summary>
        /// List of projects of this course.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

        /// <summary>
        /// List of projects proposals of this course.
        /// </summary>
        public ICollection<Proposal> Proposals { get; set; }

        /// <summary>
        /// List of Enrollment of this course.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }

        /// <summary>
        /// List of academic years that this course was active.
        /// </summary>
        public ICollection<AcademicYear> AcademicYears { get; set; }

    }

}
