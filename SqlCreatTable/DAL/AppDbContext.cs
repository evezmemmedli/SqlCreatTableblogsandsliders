using Microsoft.EntityFrameworkCore;
using SqlCreatTable.Models;

namespace SqlCreatTable.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<BlogDetails> Blogs { get; set; }   
    }

    
}
