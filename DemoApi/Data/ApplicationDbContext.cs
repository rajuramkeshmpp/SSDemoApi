
using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
    }
}
