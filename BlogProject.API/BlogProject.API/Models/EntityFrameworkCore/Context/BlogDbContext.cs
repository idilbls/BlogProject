using BlogProject.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Models.EntityFrameworkCore.Context
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Profile> Profiles { get; set; }

    }
}
