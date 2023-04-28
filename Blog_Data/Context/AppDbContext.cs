using Blog_Entity.Entities;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;

namespace Blog_Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Images> Images { get; set; }
    }
}
