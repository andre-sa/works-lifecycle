namespace wlc2.Models {

    /// <summary>
    /// This class has the Institution attributes.
    /// </summary>
    public class Institution {

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Institution() { 
            Advisors = new HashSet<Advisor>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Institution's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Institution's site.
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// Institution advisors list.
        /// </summary>
        public ICollection<Advisor> Advisors { get; set; }

    }

}
