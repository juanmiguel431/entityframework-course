using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidzyExercise.Models
{
    public class Video
    {
        public Video()
        {
            Genres = new List<Genre>();
        }
        
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public IList<Genre> Genres { get; set; }
    }
}