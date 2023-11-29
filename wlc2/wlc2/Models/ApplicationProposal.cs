using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the association of an application to a proposal.
    /// </summary>
    public class ApplicationProposal {

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Prefered order fot this application.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// FK for the application.
        /// </summary>
        [ForeignKey(nameof(Aplication))]
        public int ApplicationFK { get; set; }
        public Application Aplication { get; set; }

        /// <summary>
        /// FK for the proposal.
        /// </summary>
        [ForeignKey(nameof(Proposal))]
        public int ProposalFK { get; set; }
        public Proposal Proposal { get; set; }

    }
}
