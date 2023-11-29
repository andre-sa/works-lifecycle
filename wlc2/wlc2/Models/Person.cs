using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents a person.
    /// </summary>
    public class Person {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Person() {
            Courses = new HashSet<Course>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Account UserId for this person.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Name of the person.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email of the person.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Identification number of the person.
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// ORCID of the persons.
        /// </summary>
        public string ORCID { get; set; }

        [ForeignKey(nameof(IdentificationType))]
        public int IdentificationTypeFK { get; set; }
        /// <summary>
        /// Identification type of the person.
        /// </summary>
        public IdentificationType IdentificationType { get; set; }

        [ForeignKey(nameof(Nationality))]
        public int NationalityFK { get; set; }
        /// <summary>
        /// Nationality of the person.
        /// </summary>
        public Nationality Nationality { get; set; }

        /// <summary>
        /// List of courses.
        /// </summary>
        public ICollection<Course> Courses { get; set; }

    }

}
