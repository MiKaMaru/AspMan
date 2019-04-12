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

    }
}
