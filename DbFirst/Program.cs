using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{

    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advance = 3
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();

            var newCourse = new Course()
            {
                Level = Level.Intermediate
            };
            
            var courses = context.GetCourses();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }
        }
    }
}
