using ASP.NET_Lab_3.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Lab_3.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { }
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Types> Types { get; set; }
    }

}
