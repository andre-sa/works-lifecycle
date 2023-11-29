using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {

    /// <summary>
    /// This class represents the access type that a project has.
    /// </summary>
    public class AccessType {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public AccessType() {
            Projects = new HashSet<Project>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Access type name.
        /// </summary>
        [Display(Name = "Tipo de Acesso")]
        public string Name { get; set; }

        /// <summary>
        /// This is the access type code used by Rcaap.
        /// </summary>
        [Display(Name = "Código RCAAP")]
        public string RcaapCode { get; set; }

        /**
         * Foreign Keys.
         */

        /// <summary>
        /// This is a list of projects that use this access type.
        /// </summary>
        public ICollection<Project> Projects { get; set; }

    }

}
