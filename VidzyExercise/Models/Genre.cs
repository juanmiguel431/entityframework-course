using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidzyExercise.Models
{
    public class Genre
    {
        public Genre()
        {
            Videos = new List<Video>();
        }
        
        public byte Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public IList<Video> Videos { get; set; }
    }
}