using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the course discipline area according to the CNAEF.
    /// </summary>
    public class Area {

        /// <summary>
        /// Class Constructor.
        /// </summary>
        public Area() {
            Courses = new HashSet<Course>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Area name.
        /// </summary>
        [Display(Name = "Nome da Área")]
        [Required(ErrorMessage = "É obrigatório definir o nome da área.")]
        public string Name { get; set; }

        /// <summary>
        /// This is the area code used by Renates.
        /// </summary>
        [Display(Name = "Código RENATES")]
        [Required(ErrorMessage = "É obrigatório definir o código RENATES para a área.")]
        public string RenatesCode { get; set; }

        /// <summary>
        /// List of courses that uses this area
        /// </summary>
        public ICollection<Course> Courses { get; set; }

    }

}
