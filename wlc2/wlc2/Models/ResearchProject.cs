using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the research projects that each project can have.
    /// </summary>
    public class ResearchProject {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public ResearchProject() { 
            Projects = new HashSet<Project>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Research project name.
        /// </summary>
        [Display(Name = "Nome do Projeto de Investigação")]
        [Required(ErrorMessage = "É obrigatório definir o nome do projeto de investigação.")]
        public string Name { get; set; }

        /// <summary>
        /// This is the reference to the research project.
        /// </summary>
        [Display(Name = "Referência")]
        [Required(ErrorMessage = "É obrigatório definir a referência do projeto de investigação.")]
        public string Reference { get; set; }

        /* Foreign Keys */

        /// <summary>
        /// List of projects associated to this research project.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

    }

}
