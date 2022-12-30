using Microsoft.EntityFrameworkCore;

namespace FrontToAdd.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<slider> sliders { get; set; }
        public DbSet<SecurityService> SecurityServices { get; set; }
    }
}
