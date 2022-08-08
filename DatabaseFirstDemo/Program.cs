using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var context = new DatabaseFirstDemoEntities();

            var post = new Post()
            {
                Body = "Body2",
                DatePublished = DateTime.Now,
                Title = "Title2"
            };
            context.Posts.Add(post);

            context.SaveChanges();
        }
    }
}
