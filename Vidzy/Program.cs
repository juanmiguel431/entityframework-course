using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new VidzyDbContext())
            {
                context.AddVideo("Terminator", DateTime.Now, "Action");
                context.AddVideo("Clip", DateTime.Now, "Comedy");
                context.AddVideo("Sex Education", DateTime.Now, "Comedy");
                context.SaveChanges();
            }
        }
    }
}
