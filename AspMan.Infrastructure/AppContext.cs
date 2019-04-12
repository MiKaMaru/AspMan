using AspMan.Core;
using AspMan.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AspMan.Infrastructure
{
    class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        //public с модели
        public DbSet<Author> Authors { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Complexity> Complexities { get; set; }


        public DbSet<TaskAuthor> TaskAuthors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // если везде перейдём на чисты ID, то нужно будет дополнять модель правилами oneToMany в обе стороны
            modelBuilder.Entity<TaskAuthor>().HasKey(sc => new {sc.AuthorId, sc.TaskId});
        }
    }
}
