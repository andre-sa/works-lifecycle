using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the organic units that each course has.
    /// </summary>
    public class OrganicUnit {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public OrganicUnit() { 
            Courses = new HashSet<Course>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Organic unit name.
        /// </summary>
        [Display(Name = "Unidade Orgânica")]
        [Required(ErrorMessage = "É obrigatório definir o nome da unidade orgânica.")]
        public string Name { get; set; }

        /// <summary>
        /// This is the organic unit external code.
        /// </summary>
        [Display(Name = "Código Externo")]
        [Required(ErrorMessage = "É obrigatório definir um código externo.")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// This is the organic unit abbreviation.
        /// </summary>
        [Display(Name = "Abreviação")]
        [Required(ErrorMessage = "É obrigatório definir uma abreviatura.")]
        public string Abbreviation { get; set; }

        /* Foreign Keys */

        /// <summary>
        /// List of this organic unit courses.
        /// </summary>
        public ICollection<Course> Courses { get; set; }

    }

}
