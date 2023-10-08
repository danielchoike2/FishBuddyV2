
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FishBuddy.Models
{ 
       public enum ExpLevel
{
    Begginer,
    Intermediate,
    Expert 
}

    public enum Season
    {
        Spring,
        Summer,
        Fall,
        Winter 
    }
    public class FishSpecies
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Fish Name")]
        [StringLength(30, ErrorMessage = "Please enter a fish name 30 characters or less.")]
        public string? FishName { get; set; }


        [Display(Name = "Location")]
        public string? Location { get; set; }

        [Display(Name = "Experience Level")]
        public ExpLevel? ExperienceLevel { get; set; }

        [Display(Name = "Maximum Length")]
        public string? MaxLength { get; set; }

        [Display(Name = "Maximum Weight")]
        public string? MaxWeight { get; set; }

        [Display(Name = "Best Season T0 Catch")]
        public Season? BestSeason { get; set; }


    }
}
