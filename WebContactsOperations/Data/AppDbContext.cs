using Microsoft.EntityFrameworkCore;
using WebContactsOperations.Models;

namespace WebContactsOperations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; } = null!;
    }
}
