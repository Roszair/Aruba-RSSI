using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class RSSIContext : DbContext
    {
        public RSSIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RSSIValue> RSSIValues {get; set;}
    }
}