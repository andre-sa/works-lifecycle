using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the collection in each project will be saved.
    /// </summary>
    public class RepositoryCollection {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public RepositoryCollection() {
            Projects = new HashSet<Project>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Repository name.
        /// </summary>
        [Display(Name = "Nome da Coleção")]
        [Required(ErrorMessage = "É obrigatório definir o nome da coleção.")]
        public string Name { get; set; }

        /* Foreign Keys */

        /// <summary>
        /// List of projects in this repository collection.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

        /// <summary>
        /// Organic unit FK.
        /// </summary>
        [ForeignKey(nameof(OrganicUnit))]
        public int OrganicUnitFK { get; set; }
        [Display(Name = "Unidade Orgânica")]
        [Required(ErrorMessage = "É obrigatório selecionar uma unidade orgânica.")]
        public OrganicUnit OrganicUnit { get; set; }

    }

}
