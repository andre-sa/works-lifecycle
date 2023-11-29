using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace wlc2.Models
{
    public class CourseAdvisor
    {
        public int Id { get; set; }

        public bool IsAdmin { get; set; }

        [ForeignKey(nameof(Advisor))]
        public int AdvisorFK { get; set; }
        public Advisor Advisor { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseFK { get; set; }
        public Course Course { get; set; }
    }

}
