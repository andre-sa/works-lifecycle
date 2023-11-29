using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents an application.
    /// </summary>
    public class Application {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Application() {
            Students = new HashSet<Student>();
            ApplicationProposals = new HashSet<ApplicationProposal>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of submition.
        /// </summary>
        public DateTime SubmittedDate { get; set; }

        /// <summary>
        /// Application status.
        /// </summary>
        public ApplicationStatus ApplicationStatus { get; set; }

        /* Foreign Keys */

        [ForeignKey(nameof(Course))]
        public int CourseFK { get; set; }
        public Course Course { get; set; }

        [ForeignKey(nameof(AcademicYear))]
        public int AcademicYearFK { get; set; }
        public AcademicYear AcademicYear { get; set; }

        /// <summary>
        /// Student FK.
        /// </summary>
        public ICollection<Student> Students { get; set; }

        /// <summary>
        /// List of application proposals.
        /// </summary>
        public ICollection<ApplicationProposal> ApplicationProposals { get; set; }

        /* *************************************************** */

        /// <summary>
        /// Read only propriety to show the status as string translated to portuguese.
        /// </summary>
        [NotMapped] // This makes this propriety not mapped in database.
        public string ApplicationStatusDisplay
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case ApplicationStatus.draft:
                        return "Rascunho";
                    case ApplicationStatus.assigned:
                        return "Atribuido";
                    case ApplicationStatus.rejected:
                        return "Rejeitado";
                    case ApplicationStatus.submitted:
                        return "Submetido";
                    case ApplicationStatus.validated:
                        return "Validado";
                    default:
                        return ApplicationStatus.ToString(); // Default value if error in translation.
                }
            }
        }

    }

}
