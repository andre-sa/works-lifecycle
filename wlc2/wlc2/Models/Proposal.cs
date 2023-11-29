using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the proposals data.
    /// </summary>
    public class Proposal {

        // TODO: a proposal tem de ser validada pelos orientadores envolvidos.

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Proposal() {
            ApplicationProposals = new HashSet<ApplicationProposal>();
            ProponentStudents = new HashSet<Student>();
            Advisors = new HashSet<Advisor>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title of the proposal.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of the proposal.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Project status.
        /// </summary>
        public ProposalStatus ProposalStatus { get; set; }

        /* Foreign Keys */

        /// <summary>
        /// Course FK.
        /// </summary>
        [ForeignKey(nameof(Course))]
        public int CourseFK { get; set; }
        public Course Course { get; set; }

        /// <summary>
        /// Institution FK.
        /// </summary>
        [ForeignKey(nameof(Institution))]
        public int InstitutionFK { get; set; }
        public Institution Institution { get; set; }

        [ForeignKey(nameof(AcademicYear))]
        public int AcademicYearFK { get; set; }
        /// <summary>
        /// Project's academic year.
        /// </summary>
        public AcademicYear AcademicYear { get; set; }

        /// <summary>
        /// List of applications to the proposal.
        /// </summary>
        public ICollection<ApplicationProposal> ApplicationProposals { get; set; }

        /// <summary>
        /// List of proponent students to the proposal.
        /// </summary>
        public ICollection<Student> ProponentStudents { get; set; }

        /// <summary>
        /// List of proposal advisors.
        /// </summary>
        public ICollection<Advisor> Advisors { get; set; }

        /* *************************************************** */
        
        /// <summary>
        /// Read only propriety to show the status as string translated to portuguese.
        /// </summary>
        [NotMapped] // This makes this propriety not mapped in database.
        public string ProposalStatusDisplay
        {
            get
            {
                switch (ProposalStatus)
                {
                    case ProposalStatus.draft:
                        return "Rascunho";
                    case ProposalStatus.submitted:
                        return "Submetido";
                    case ProposalStatus.approved:
                        return "Aprovado";
                    case ProposalStatus.assigned:
                        return "Atribuído";
                    case ProposalStatus.cancelled:
                        return "Cancelado";
                    default:
                        return ProposalStatus.ToString(); // Default value if error in translation.
                }
            }
        }

    }

}
