using System.Buffers;
using Microsoft.EntityFrameworkCore;
using mvcProject.Models;

namespace mvcProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Races> Races   {get; set;}
        public DbSet<Club> Clubs { get; set; }
        public DbSet<address> Addresses { get; set; }
    }
}