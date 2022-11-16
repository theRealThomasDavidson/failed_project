﻿using System.ComponentModel.DataAnnotations;

namespace StudentProjectAttempt6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float grade { get; set; }

    }
}
