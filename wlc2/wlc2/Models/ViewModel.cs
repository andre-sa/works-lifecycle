namespace wlc2.Models
{

    /// <summary>
    /// This class has the attributes used by ProjectsController.
    /// </summary>
    public class ProjectViewModel
    {
        public Project Project { get; set; }
        public List<Language> Languages { get; set; }
        public List<License> Licenses { get; set; }
        public List<AccessType> AccessTypes { get; set; }
    }
    
    /// <summary>
    /// This class has the attributes used by HomeController.
    /// </summary>
    public class ViewModel
    {
        
        public AcademicYear AcademicYear { get; set; }
        public List<Application> Applications { get; set; }
        public List<Proposal> ApprovedProposals { get; set; }
        public List<Proposal> Proposals { get; set; }
        public List<Project> Projects { get; set; }
        
        public Course Course { get; set; }

        public bool IsCourseAdmin { get; set; }

    }

    /// <summary>
    /// This class has the attributes to send to the View 'Applications/Details'.
    /// </summary>
    public class ApplicationViewModel
    {
        public Application Application { get; set; }
        public AcademicYear AcademicYear { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; }
        public List<ApplicationProposal> ApplicationProposals { get; set; }
    }

}
