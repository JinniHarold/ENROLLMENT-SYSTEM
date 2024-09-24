using System.ComponentModel.DataAnnotations;

namespace ENROLLMENT_SYSTEM.Models.Entities
{
    public class Students
    {
        [Key]
        public int StudID { get; set; }

        public string StudLastName { get; set; }
        public string StudFirstName { get; set; }
        public string StudMidName { get; set; }
        public string StudCourse { get; set; }
        public int StudYear { get; set; }
        public string Studremarks { get; set; }

    }
}
