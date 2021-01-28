using System;
using System.ComponentModel.DataAnnotations;

namespace thomasSecondWebApp.Models
{
    public class GradeCalculatorModel
    {
        [Required]
        [Range(0, 100)]
        public int assignments { get; set; }

        [Required]
        [Range(0, 100)]
        public int groupProjects { get; set; }

        [Required]
        [Range(0, 100)]
        public int quizzes { get; set; }

        [Required]
        [Range(0, 100)]
        public int exams { get; set; }

        [Required]
        [Range(0, 100)]
        public int intex { get; set; }
    }
}
