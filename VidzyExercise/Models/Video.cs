using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidzyExercise.Models
{
    public class Video
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public Genre Genre { get; set; }
    }
}