namespace wlc2.Models {

    /// <summary>
    /// This class represents the advisor.
    /// </summary>
    public class Advisor : Person {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Advisor() {
            Institutions        = new HashSet<Institution>();
            Proposals           = new HashSet<Proposal>();
            SupervisedProjects  = new HashSet<Project>();
            JuryParticipations  = new HashSet<JuryMember>();
        }

        /// <summary>
        /// Is the advisor external?
        /// </summary>
        public bool External { get; set; }

        /// <summary>
        /// PhD?
        /// </summary>
        public bool PhD { get; set; }

        /// <summary>
        /// Specialist area.
        /// </summary>
        public bool Specialist { get; set; }

        /// <summary>
        /// List of institutions.
        /// </summary>
        public ICollection<Institution> Institutions { get; set; }

        /// <summary>
        /// List of proposals.
        /// </summary>
        public ICollection<Proposal> Proposals { get; set; }

        /// <summary>
        /// List of associated projects.
        /// </summary>
        public ICollection<Project> SupervisedProjects { get; set; }

        /// <summary>
        /// List of participations as jury.
        /// </summary>
        public ICollection<JuryMember> JuryParticipations { get; set; }

    }

}
