using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {
    public class ProjectValidation {

        public int Id { get; set; }

        public bool Validated { get; set; }

        public DateTime ValidationDate { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonFK { get; set; }
        public Person Person { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectFK { get; set; }
        public Project Project { get; set; }

    }
}
