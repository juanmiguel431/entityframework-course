using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Hierarchy;

namespace VidzyExercise.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
        public byte GenreId { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}