using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaUpdateDTO
    {
        [Required]
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string name { get; set; }

        public string details { get; set; }

        [Required]
        public double rate { get; set; }
        [Required]
        public int occupancy { get; set; }
        [Required]
        public int sqft { get; set; }
        [Required]
        public string imageUrl { get; set; }

        public string amenity { get; set; }
    }
}
