using System;
using System.ComponentModel.DataAnnotations; // REMEMEBR TO IMPORT THIS!!!

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }


        [Required]
        public string Location { get; set; }


        [Required]
        public string Language { get; set; }


        [MinLength(10)]
        [MaxLength(50)]
        public string Comments { get; set; }
    };
};