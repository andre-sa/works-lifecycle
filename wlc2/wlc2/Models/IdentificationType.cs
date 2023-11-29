using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the identification types used by each person.
    /// </summary>
    public class IdentificationType {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public IdentificationType() { 
            Persons = new HashSet<Person>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the identification type used by a person.
        /// </summary>
        [Display(Name = "Tipo de Identificação")]
        [Required(ErrorMessage = "É obrigatório definir um nome para o tipo de identificação.")]
        public string Name { get; set; }

        /// <summary>
        /// This attribute is used for RENATES.
        /// </summary>
        [Display(Name = "Código RENATES")]
        [Required(ErrorMessage = "É obrigatório definir um código RENATES para o tipo de identificação.")]
        public string Code { get; set; }

        /* Foreign Keys */

        /// <summary>qq
        /// List of persons that uses this identification type.
        /// </summary>
        public ICollection<Person> Persons { get; set; }

    }

}
