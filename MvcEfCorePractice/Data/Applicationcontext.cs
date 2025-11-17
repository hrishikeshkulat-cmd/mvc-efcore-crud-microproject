using Microsoft.EntityFrameworkCore;
using MvcEfCorePractice.Models;

namespace MvcEfCorePractice.Data
{
    public class Applicationdbcontext:DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext>options) :base(options)

        { }

        public DbSet<Student>students { get; set; }

        
    }
}
