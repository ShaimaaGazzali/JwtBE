
using Base2022.Data.Entities;


namespace Base2022.DTO
{
    public class TaskDto
    {
        public int? Id   { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SubmissionDate { get; set; }

        public string EmployeeId   { get; set; }
        public string Employee { get; set; }
    }
}
