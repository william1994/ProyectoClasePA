using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasePA.Models
{
    public class Enrrollements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrrollementsId { get; set; }

        public int CourseID { get; set; }

        public int StudentID    { get; set; }

        public Course Courese { get; set; }

        public Students Students { get; set; }

    }
}
