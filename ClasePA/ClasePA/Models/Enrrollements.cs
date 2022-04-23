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

        //Esta instancia nos permite poder acceder a la informacion de la tabla course
        public Course Course { get; set; }
        //Esta instancia nos permite poder acceder a la informacion de la tabla student
        public Students Student { get; set; }

    }
}
