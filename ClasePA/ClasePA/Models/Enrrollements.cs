using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasePA.Models
{
    public class Enrrollements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrrollementId { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Course Course { get; set; }

        public Students Student { get; set; }

    }
}
