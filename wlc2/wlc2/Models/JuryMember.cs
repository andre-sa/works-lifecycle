using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {
    
    /// <summary>
    /// Member of a jury team.
    /// </summary>
    public class JuryMember {

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Jury member role.
        /// </summary>
        public JuryRole JuryMemberRole { get; set; }

        /// <summary>
        /// FK for the project defense.
        /// </summary>
        [ForeignKey(nameof(ProjectDefense))]
        public int ProjectDefenseFK { get; set; }
        public ProjectDefense ProjectDefense { get; set; }

        /// <summary>
        /// FK for the advisor.
        /// </summary>
        [ForeignKey(nameof(Advisor))]
        public int AdvisorFK { get; set; }
        public Advisor Advisor { get; set; }

    }

}
