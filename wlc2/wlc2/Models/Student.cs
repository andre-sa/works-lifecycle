namespace wlc2.Models {

    /// <summary>
    /// This class represents a student.
    /// </summary>
    public class Student : Person {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Student() {
            Projects        = new HashSet<Project>();
            Applications    = new HashSet<Application>();
            AutoProposals   = new HashSet<Proposal>();
            Enrollments     = new HashSet<Enrollment>();
        }

        /// <summary>
        /// Identification number of the student.
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// Sex of the student.
        /// </summary>
        public PersonSex Sex { get; set; }

        /// <summary>
        /// Address of the student.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Postal code of the student.
        /// </summary>
        public string PostalCode { get; set; }

        /* Foreign Keys */

        /// <summary>
        /// List of projects of the student.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

        /// <summary>
        /// Applications list of the student.
        /// </summary>
        public ICollection<Application> Applications { get; set; }

        /// <summary>
        /// Proposals list of the student.
        /// </summary>
        public ICollection<Proposal> AutoProposals { get; set; }

        /// <summary>
        /// Enrollment list of the student.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }

    }

}
