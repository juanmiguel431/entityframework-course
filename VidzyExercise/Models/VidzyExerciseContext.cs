using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VidzyExercise.Models
{
    public partial class VidzyExerciseContext : DbContext
    {
        public VidzyExerciseContext()
            : base("name=VidzyExercise")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
