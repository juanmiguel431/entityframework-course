using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidzyExercise.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}