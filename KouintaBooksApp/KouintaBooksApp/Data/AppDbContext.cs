using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace KouintaBooksApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<KouintaBook> KouintaBooks { get; set; }
    }
}
