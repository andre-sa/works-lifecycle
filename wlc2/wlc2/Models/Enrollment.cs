using System.ComponentModel.DataAnnotations.Schema;

namespace wlc2.Models {


    public class Enrollment {

        public int Id { get; set; }

        public EnrollmentStatus EnrollmentStatus { get; set; }

        public int ECTS { get; set; }

        [ForeignKey(nameof(EnrollmentStarted))]
        public int EnrollmentStartedFK { get; set; }
        public AcademicYear EnrollmentStarted { get; set; }

        [ForeignKey(nameof(EnrollmentCompleted))]
        public int EnrollmentCompletedFK { get; set; }
        public AcademicYear EnrollmentCompleted { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentFK { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseFK { get; set; }
        public Course Course { get; set; }

    }
}
