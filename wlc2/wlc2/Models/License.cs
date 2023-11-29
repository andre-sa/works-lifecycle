using System.ComponentModel.DataAnnotations;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the licenses that each project can use.
    /// </summary>
    public class License {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public License() { 
            Projects = new HashSet<Project>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// License name.
        /// </summary>
        [Display(Name = "Licença")]
        public string Name { get; set; }

        /// <summary>
        /// This is the license code used by RCAAP.
        /// </summary>
        [Display(Name = "Código RCAAP")]
        public string RcaapCode { get; set; }

        /// <summary>
        /// List of projects that use this license.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

    }

}
