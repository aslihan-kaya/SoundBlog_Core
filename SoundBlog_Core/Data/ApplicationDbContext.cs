
using Microsoft.EntityFrameworkCore;
using SoundBlog.Models;

namespace SoundBlog_Core.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Type> Types { get; set; }

    }
}
