using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents a project defense data.
    /// </summary>
    public class ProjectDefense {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public ProjectDefense() { 
            JuryMembers = new HashSet<JuryMember>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Room where will be the project defense.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// Date of the project defense.
        /// </summary>
        public DateTime DefenseDate { get; set; }

        /**
         * Pode ainda ter um documento como a ata, notas e outros comentários.
         */

        /// <summary>
        /// FK for the project.
        /// </summary>
        [ForeignKey(nameof(Project))]
        public int ProjectFK { get; set; }
        public Project Project { get; set; }

        /// <summary>
        /// List of the defense's jury members.
        /// </summary>
        public ICollection<JuryMember> JuryMembers { get; set; }

    }
}
