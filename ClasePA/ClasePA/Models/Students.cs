﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClasePA.Models
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public String FirsName { get; set; }
        public String LastName { get; set; }

        public DateTime EnrrollmentsDate { get; set; }

        public ICollection<Enrrollements> Enrrollements { get; set; }
    }
}
