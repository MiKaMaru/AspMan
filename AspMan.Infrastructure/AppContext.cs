using AspMan.Core;
using AspMan.Core.Models;
using AspMan.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AspMan.Infrastructure
{
    public class AppContext : DbContext, IContextConcurrency
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
        public DbSet<InputData> InputDatas { get; set; }
        public DbSet<OutputData> OutputDatas { get; set; }
        
        public DbSet<TaskAuthor> TaskAuthors { get; set; }
        public DbSet<TaskData> TaskDatas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // если везде перейдём на чисты ID, то нужно будет дополнять модель правилами oneToMany в обе стороны
            modelBuilder.Entity<TaskAuthor>().HasKey(sc => new {sc.AuthorId, sc.TaskId});

            modelBuilder.Entity<TaskData>().HasKey(sc => new { sc.InputDataId, sc.TaskId });
        }



        public AppContext()
        {
            //если нет БД, то создаст
            Database.EnsureCreated();
        }
        private string strSqlConn = "Server=P10131\\SQLEXPRESS;Database=hello1;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(strSqlConn);
            }
        }

        public void OnSave()
        {
            SaveChanges();
        }
        public async void OnSaveAsync()
        {
            await SaveChangesAsync();
        }
    }
}
