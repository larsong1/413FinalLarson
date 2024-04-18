using Microsoft.EntityFrameworkCore;

namespace _413FinalLarson.Models
{
    public class FinalContext :DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }
        public DbSet<Entertainer> Entertainers { get; set; }
    }
}
