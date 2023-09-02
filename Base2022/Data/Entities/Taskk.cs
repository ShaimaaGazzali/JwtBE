
using System.ComponentModel.DataAnnotations.Schema;


namespace Base2022.Data.Entities
{
    public class TaskK 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id   { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SubmissionDate { get; set; }

        public string EmployeeId   { get; set; }
        public AppUser Employee { get; set; }
    }
}
