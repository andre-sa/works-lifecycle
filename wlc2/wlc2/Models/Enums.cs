namespace wlc2.Models {
    
    public enum Degree
    {
        bachelor,
        master,
        doctorate
    }

    public enum ApplicationStatus {
        draft,
        submitted,
        validated,
        assigned,
        rejected
    }

    public enum ProposalStatus {
        draft,
        submitted,
        approved,
        assigned,
        cancelled
    }

    public enum JuryRole {
        main_examiner,      // arguente
        examiner,           // vogal
        president           // presidente
    }

    public enum PersonSex {
        male,
        female
    }

    public enum ProjectStatus {
        cancelled,
        ongoing,
        submitted,
        validated,
        defended,
        concluded
    }

    public enum EnrollmentStatus { 
        ongoing,
        concluded,
        dropped
    }

}
