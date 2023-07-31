﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string name { get; set; }

        public string details { get; set; }

        [Required]
        public double rate { get; set; }

        public int occupancy { get; set; }

        public int sqft { get; set; }

        public string imageUrl { get; set; }

        public string amenity { get; set; }
    }
}
