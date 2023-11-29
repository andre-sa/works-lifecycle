using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the language used in each project.
    /// </summary>
    public class Language {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Language() { 
            Projects = new HashSet<Project>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Language name.
        /// </summary>
        [Display(Name = "Idioma")]
        [Required(ErrorMessage = "É obrigatório definir um nome para o idioma.")]
        public string Name { get; set; }

        /// <summary>
        /// This is the language alpha 2 code.
        /// </summary>
        [Display(Name = "Código A2C")]
        [Required(ErrorMessage = "É obrigatório definir um código Alpha 2 para o idioma.")]
        public string Alpha2Code { get; set; }

        /// <summary>
        /// List of projects that use this language.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

    }

}
