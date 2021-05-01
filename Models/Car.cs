using System;
using System.ComponentModel.DataAnnotations;

namespace CaMS.Models
{
    public interface ICar
    {
        int Id { get; set; }
        string BrandName { get; set; }
        string ModelName { get; set; }
        string Descriptions { get; set; }
        DateTime ManufacturingYear { get; set; }
        string EngineCondition { get; set; }
        string CurrentPaint { get; set; }
        int NumberOfRepairs { get; set; }
        int NumberOfAccident { get; set; }
    }

    public class Car : ICar
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
        [Required]
        [Display(Name = "Model Name")]
        public string ModelName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        [Display(Name = "Descriptions")]
        public string Descriptions { get; set; }
        [Required]
        [Display(Name = "Manufacturing Year")]
        public DateTime ManufacturingYear { get; set; }
        [Required]
        [Display(Name = "Engine Condition")]
        public string EngineCondition { get; set; }
        [Required]
        [Display(Name = "Current Paint")]
        public string CurrentPaint { get; set; }
        [Display(Name = "Number of Repairs")]
        public int NumberOfRepairs { get; set; }
        [Display(Name = "Number of Accident")]
        public int NumberOfAccident { get; set; }

    }
}