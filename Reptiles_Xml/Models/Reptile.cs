using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Reptiles_Xml.Models
{
    public class Reptile
    {
        [Required(ErrorMessage = "A unique Id must be entered.")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Reptile Name")]
        public string Species { get; set; }

        [Display(Name = "Life Span")]
        public string LifeSpan { get; set; }

        public string Environment { get; set; }

        [Required]
        [Display(Name = "Experience Level")]
        [RegularExpression(@"\b(Beginner|Intermediate|Advanced)\b", ErrorMessage = "Please enter a valid Experience Level ('Beginner', 'Intermediate', or 'Advanced').")]
        public string ExperienceLevel { get; set; }

        [Required]
        [RegularExpression(@"^\d{0,8}(\.\d{1,2})?$", ErrorMessage = "Please enter a valid price.")]
        public double Price { get; set; }

        public string Image { get; set; }
    }
}