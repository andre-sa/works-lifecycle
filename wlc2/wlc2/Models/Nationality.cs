using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the nationality of each person.
    /// </summary>
    public class Nationality {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Nationality() { 
            Persons = new HashSet<Person>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// International country code using the Alpha-2 Code system.
        /// </summary>
        [Display(Name = "Código (Alpha 2)")]
        public string Alpha2Code { get; set; }

        /// <summary>
        /// Name of the country.
        /// </summary>
        [Display(Name = "Nacionalidade")]
        public string Name { get; set; }

        /// <summary>
        /// List of persons of this nationality.
        /// </summary>
        public ICollection<Person> Persons { get; set; }

    }

}
