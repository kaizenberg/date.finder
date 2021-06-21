using Microsoft.EntityFrameworkCore;
using model.date.finder;

namespace data.date.finder
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}
